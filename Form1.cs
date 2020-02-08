using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Diagnostics;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Text.RegularExpressions;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace iwm_MsgBox
{
	public partial class Form1 : Form
	{
		private const string VER = "MessageBox iwm20200208";
		private const string NL = "\r\n";

		private static readonly string[] ARGS = Environment.GetCommandLineArgs();
		private static readonly string PROGRAM = Path.GetFileName(ARGS[0]);

		private static readonly string HELP =
			"【使い方】" + NL +
			$"  {PROGRAM} [オプション1] [オプション2] ..." + NL +
			NL +
			$"  (例) {PROGRAM} -size=240,160 -title=\"タイトル\" -text=\"あいうえお^\\nかき^\\tくけこ\" -textsize=10 -button=1,1 -button2=\"はい\",\"いいえ\",\"閉じる\"" + NL +
			NL +
			"【オプション】" + NL +
			"  -size=width,height" + NL +
			"    (例) 240,160" + NL +
			NL +
			"  -title=\"\"" + NL +
			"    (例) \"タイトル\"" + NL +
			NL +
			"  -text=\"\"" + NL +
			"    改行 => ^\\n" + NL +
			"    タブ => ^\\t" + NL +
			"    (例) \"あいうえお^\\nかき^\\tくけこ\"" + NL +
			NL +
			"  -textsize=n" + NL +
			"    (例) 10" + NL +
			NL +
			"  -button=n,n" + NL +
			"    (例)" + NL +
			"      1,1 => [はい／いいえ／閉じる]" + NL +
			"      1,0 => [はい／閉じる]" + NL +
			"      0,1 => [いいえ／閉じる]" + NL +
			"      0,0 => [閉じる]" + NL +
			NL +
			"  -button2=\"はい\",\"いいえ\",\"閉じる\"" + NL +
			"    (例) \"Yes\",\"No\",\"Cancel\"" + NL +
			NL +
			"【戻り値】" + NL +
			"  [はい]   => 1" + NL +
			"  [いいえ] => 2" + NL +
			"  [閉じる] => 0" + NL
		;

		private static readonly int[] TEXTSIZE = { 10, 10 * 3 };

		public Form1()
		{
			InitializeComponent();

			// 初期化
			Text = "";
			TbText.Text = "";
			BtnYes.Visible = false;
			BtnNo.Visible = false;

			int iChkCnt = 0;

			// [0] は Program なので読み飛ばす
			for (int _i1 = 1; _i1 < ARGS.Length; _i1++)
			{
				string _s1 = ARGS[_i1];
				string[] _as1;

				if (Regex.IsMatch(_s1, @"^\-size\=\d+\,\d+"))
				{
					_as1 = _s1.Substring(6).Split(',');

					int _iW = int.Parse(_as1[0]);
					int _iH = int.Parse(_as1[1]);

					if (_iW < MinimumSize.Width)
					{
						_iW = MinimumSize.Width;
					}
					else if (_iW > Screen.PrimaryScreen.WorkingArea.Width)
					{
						_iW = Screen.PrimaryScreen.WorkingArea.Width;
					}

					if (_iH < MinimumSize.Height)
					{
						_iH = MinimumSize.Height;
					}
					else if (_iH > Screen.PrimaryScreen.WorkingArea.Height)
					{
						_iH = Screen.PrimaryScreen.WorkingArea.Height;
					}

					Width = _iW;
					Height = _iH;
				}
				else if (Regex.IsMatch(_s1, @"^\-title\=.+"))
				{
					Text = _s1.Substring(7);
					++iChkCnt;
				}
				else if (Regex.IsMatch(_s1, @"^\-text\=.+"))
				{
					string _s2 = _s1.Substring(6);

					// 特殊文字変換
					_s2 = Regex.Replace(_s2, @"\^\\n|\r*\n", "\r\n");
					_s2 = Regex.Replace(_s2, @"\^\\t", "\t");

					TbText.Text = _s2;
					++iChkCnt;
				}
				else if (Regex.IsMatch(_s1, @"^\-textsize\=\d+"))
				{
					string _s2 = _s1.Substring(10);
					int _i2 = int.Parse(_s2);

					if (_i2 < TEXTSIZE[0])
					{
						_i2 = TEXTSIZE[0];
					}

					if (_i2 > TEXTSIZE[1])
					{
						_i2 = TEXTSIZE[1];
					}

					TbText.Font = new Font(TbText.Font.FontFamily, _i2);
				}
				else if (Regex.IsMatch(_s1, @"^\-button\=\d+\,\d+"))
				{
					_as1 = _s1.Substring(8).Split(',');
					BtnYes.Visible = int.Parse(_as1[0]) > 0 ? true : false;
					BtnNo.Visible = int.Parse(_as1[1]) > 0 ? true : false;
				}
				else if (Regex.IsMatch(_s1, @"^\-button2\=.+\,.+\,.+"))
				{
					_as1 = _s1.Substring(9).Split(',');

					BtnYes.Text = _as1[0];
					BtnNo.Text = _as1[1];
					BtnCancel.Text = _as1[2];
				}
			}

			// help
			if (iChkCnt == 0)
			{
				Text = VER;
				TbText.Text = HELP;
			}
		}

		private Point MousePoint;

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				MousePoint = new Point(e.X, e.Y);
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				Left += e.X - MousePoint.X;
				Top += e.Y - MousePoint.Y;
			}
		}

		private void Button0_Click(object sender, EventArgs e)
		{
			Pub.Rtn = 1;
			Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Pub.Rtn = 2;
			Close();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Pub.Rtn = 0;
			Close();
		}

		private void CmsResult_PgUp_Click(object sender, EventArgs e)
		{
			TbText.Select(0, 0);
			_ = TbText.Focus();
			TbText.ScrollToCaret();
		}

		private void CmsResult_PgDn_Click(object sender, EventArgs e)
		{
			TbText.Select(TbText.TextLength, 0);
			_ = TbText.Focus();
			TbText.ScrollToCaret();
		}

		private void CmsResult_FontSizeUp_Click(object sender, EventArgs e)
		{
			int i1 = (int)TbText.Font.Size + 5;

			if (i1 > TEXTSIZE[1])
			{
				i1 = TEXTSIZE[1];
			}

			TbText.Font = new Font(TbText.Font.FontFamily, i1);
		}

		private void CmsResult_FontSizeDn_Click(object sender, EventArgs e)
		{
			int i1 = (int)TbText.Font.Size - 5;

			if (i1 < TEXTSIZE[0])
			{
				i1 = TEXTSIZE[0];
			}

			TbText.Font = new Font(TbText.Font.FontFamily, i1);
		}

		private void CmsResult_AllSelect_Click(object sender, EventArgs e)
		{
			TbText.SelectAll();
		}

		private void CmsResult_Copy_Click(object sender, EventArgs e)
		{
			TbText.Copy();
		}
	}

	public class Pub
	{
		public static int Rtn = 0;
	}

	public class Program
	{
		private static int Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());

			// Return
			int rtn = Pub.Rtn;

			// For Script's
			Console.Write(rtn);

			// DOS %errorlevel%
			return rtn;
		}
	}
}
