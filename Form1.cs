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

namespace WFA1
{
	public partial class Form1 : Form
	{
		private static readonly string VER = "MessageBox iwm20190809";

		private static readonly string[] ARGS = Environment.GetCommandLineArgs();
		private static readonly string PROGRAM = Path.GetFileName(ARGS[0]);

		private static readonly string CRLF = "\r\n";

		private static readonly string HELP =
			"【使い方】" + CRLF +
			$"  {PROGRAM} [オプション1] [オプション2] ..." + CRLF +
			CRLF +
			$"  (例) {PROGRAM} -size=240,160 -title=\"タイトル\" -text=\"あいうえお^\\nかき^\\tくけこ\" -textsize=9 -button=1,1" + CRLF +
			CRLF +
			"【オプション】" + CRLF +
			"  -size=width,height" + CRLF +
			"    (例) 240,160" + CRLF +
			CRLF +
			"  -title=\"\"" + CRLF +
			"    (例) \"タイトル\"" + CRLF +
			CRLF +
			"  -text=\"\"" + CRLF +
			"    改行 => ^\\n" + CRLF +
			"    タブ => ^\\t" + CRLF +
			"    (例) \"あいうえお^\\nかき^\\tくけこ\"" + CRLF +
			CRLF +
			"  -textsize=n" + CRLF +
			"    (例) 9" + CRLF +
			CRLF +
			"  -button=n,n" + CRLF +
			"    (例)" + CRLF +
			"      1,1 => [はい／いいえ／閉じる]" + CRLF +
			"      1,0 => [はい／閉じる]" + CRLF +
			"      0,1 => [いいえ／閉じる]" + CRLF +
			"      0,0 => [閉じる]" + CRLF +
			CRLF +
			"【戻り値】" + CRLF +
			"  [はい]   => 1" + CRLF +
			"  [いいえ] => 2" + CRLF +
			"  [閉じる] => 0" + CRLF
		;

		private static readonly int[] SIZE = { 400, 480 };
		private static readonly int[] TEXTSIZE = { 10, 10 * 16 };

		public Form1()
		{
			InitializeComponent();

			// 初期化
			Width = SIZE[0];
			Height = SIZE[1];
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

		private void CmsResult_AllSelect_Click(object sender, EventArgs e)
		{
			TbText.SelectAll();
		}

		private void CmsResult_Copy_Click(object sender, EventArgs e)
		{
			TbText.Copy();
		}

		private void CmsResult_FontSizeUp_Click(object sender, EventArgs e)
		{
			int i1 = (int)TbText.Font.Size * 2;

			if (i1 > TEXTSIZE[1])
			{
				i1 = TEXTSIZE[1];
			}

			TbText.Font = new Font(TbText.Font.FontFamily, i1);
		}

		private void CmsResult_FontSizeDn_Click(object sender, EventArgs e)
		{
			int i1 = (int)TbText.Font.Size / 2;

			if (i1 < TEXTSIZE[0])
			{
				i1 = TEXTSIZE[0];
			}

			TbText.Font = new Font(TbText.Font.FontFamily, i1);
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
