using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace iwm_MsgBox
{
	public partial class Form1 : Form
	{
		private const string VER = "MessageBox iwm20201118";
		private const string NL = "\r\n";

		private static readonly string[] ARGS = Environment.GetCommandLineArgs();
		private static readonly string PROGRAM = Path.GetFileName(ARGS[0]);

		private static readonly int[] TEXTSIZE = { 10, 10 * 3 };

		private readonly int[] TbText_HEIGHT = { 0, 0 };
		private readonly int[] BtnYes_POSX = { 0, 0 };

		private TextBox TB = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// 初期化
			Text = "";
			TbText.Text = "";
			TbText_HEIGHT[0] = TbText.Height;
			TbText_HEIGHT[1] = TbText_HEIGHT[0] + 20;
			BtnYes_POSX[0] = BtnYes.Location.X;
			BtnYes_POSX[1] = BtnNo.Location.X;
			BtnYes.Visible = false;
			BtnNo.Visible = false;
			CbAccept.Checked = true;
			TbText.Height = TbText_HEIGHT[1];

			int iW = Width;
			int iH = Height;

			// [0] は Program なので読み飛ばす
			for (int _i1 = 1; _i1 < ARGS.Length; _i1++)
			{
				string _s1 = ARGS[_i1];
				string[] _as1;

				if (Regex.IsMatch(_s1, @"^\-size\=\d+\,\d+"))
				{
					_as1 = _s1.Substring(6).Split(',');

					iW = int.Parse(_as1[0]);
					iH = int.Parse(_as1[1]);

					if (iW < MinimumSize.Width)
					{
						iW = MinimumSize.Width;
					}
					else if (iW > Screen.PrimaryScreen.WorkingArea.Width)
					{
						iW = Screen.PrimaryScreen.WorkingArea.Width;
					}

					if (iH < MinimumSize.Height)
					{
						iH = MinimumSize.Height;
					}
					else if (iH > Screen.PrimaryScreen.WorkingArea.Height)
					{
						iH = Screen.PrimaryScreen.WorkingArea.Height;
					}
				}
				else if (Regex.IsMatch(_s1, @"^\-title\=.+"))
				{
					Text = _s1.Substring(7);
				}
				else if (Regex.IsMatch(_s1, @"^\-text\=.+"))
				{
					string _s2 = _s1.Substring(6);

					// 特殊文字変換
					_s2 = Regex.Replace(_s2, @"\\\\n|\r*\n", NL);
					_s2 = Regex.Replace(_s2, @"\\\\t", "\t");

					TbText.Text = _s2;
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
				else if (Regex.IsMatch(_s1, @"^\-checkbox\=.*"))
				{
					CbAccept.Text = _s1.Substring(10);
					CbAccept.Checked = false;
					TbText.Height = TbText_HEIGHT[0];
				}
				else if (Regex.IsMatch(_s1, @"^\-button\=\d+\,\d+"))
				{
					_as1 = _s1.Substring(8).Split(',');
					BtnYes.Visible = int.Parse(_as1[0]) > 0;
					BtnNo.Visible = int.Parse(_as1[1]) > 0;
				}
				else if (Regex.IsMatch(_s1, @"^\-buttontext\=.+\,.+\,.+"))
				{
					_as1 = _s1.Substring(12).Split(',');
					BtnYes.Text = _as1[0];
					BtnNo.Text = _as1[1];
					BtnCancel.Text = _as1[2];
				}
			}

			// 再描画
			BtnYes.Enabled = CbAccept.Checked;
			BtnYes.Location = BtnYes.Visible && !BtnNo.Visible ? new Point(BtnYes_POSX[1], BtnYes.Location.Y) : new Point(BtnYes_POSX[0], BtnYes.Location.Y);
			Width = iW;
			Height = iH;

			// help
			if (TbText.TextLength == 0)
			{
				if (Text.Length == 0)
				{
					Text = VER;
				}

				TbText.Text = 
					"【使い方】" + NL +
					$"  {PROGRAM} [オプション] ..." + NL +
					NL +
					$"  (例) {PROGRAM} -size={MinimumSize.Width},{MinimumSize.Height} -title=\"タイトル\" -text=\"あいうえお\\\\nかき\\\\tくけこ\" -textsize={TEXTSIZE[0]} -checkbox=\"上記内容を承諾します。\" -button=1,1 -buttontext=\"はい\",\"いいえ\",\"閉じる\"" + NL +
					NL +
					"【オプション】" + NL +
					"  -size=width,height" + NL +
					$"    (例) {MinimumSize.Width},{MinimumSize.Height}" + NL +
					NL +
					"  -title=\"\"" + NL +
					"    (例) \"タイトル\"" + NL +
					NL +
					"  -text=\"\"" + NL +
					"    (例) \"あいうえお\\\\nかき\\\\tくけこ\"" + NL +
					"    改行 => \\\\n" + NL +
					"    タブ => \\\\t" + NL +
					NL +
					"  -textsize=n" + NL +
					$"    (例) {TEXTSIZE[0]}" + NL +
					NL +
					"  -checkbox=\"\"" + NL +
					"    (例) \"上記内容を承諾します。\"" + NL +
					NL +
					"  -button=n,n" + NL +
					"    (例)" + NL +
					"      1,1 => [はい] [いいえ] [閉じる]" + NL +
					"      1,0 => [はい] [閉じる]" + NL +
					"      0,1 => [いいえ] [閉じる]" + NL +
					"      0,0 => [閉じる]" + NL +
					NL +
					"  -buttontext=\"\",\"\",\"\"" + NL +
					"    (例) \"はい\",\"いいえ\",\"閉じる\"" + NL +
					NL +
					"【戻り値】" + NL +
					"  [はい]   => 1" + NL +
					"  [いいえ] => 2" + NL +
					"  [閉じる] => 0" + NL
				;
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

		private void TbText_MouseUp(object sender, MouseEventArgs e)
		{
			CmsTextSelect_Open(e, TbText);
		}

		private void CbAccept_CheckedChanged(object sender, EventArgs e)
		{
			if (CbAccept.Checked)
			{
				BtnYes.Enabled = true;
				_ = BtnYes.Focus();
			}
			else
			{
				BtnYes.Enabled = false;
				_ = BtnNo.Focus();
			}
		}

		private void BtnYes_Click(object sender, EventArgs e)
		{
			Pub.Rtn = 1;
			Close();
		}

		private void BtnNo_Click(object sender, EventArgs e)
		{
			Pub.Rtn = 2;
			Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Pub.Rtn = 0;
			Close();
		}

		private void CmsResult_Paint(object sender, PaintEventArgs e)
		{
			CmsResult_FontSizeUp.Enabled = (int)TbText.Font.Size < TEXTSIZE[1];
			CmsResult_FontSizeDn.Enabled = (int)TbText.Font.Size > TEXTSIZE[0];
		}

		private void CmsResult_AllCopy_Click(object sender, EventArgs e)
		{
			TbText.SelectAll();
			TbText.Copy();
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

		private void CmsTextSelect_Open(MouseEventArgs e, TextBox Tb)
		{
			if (Tb.SelectionLength > 0 && e.Button == MouseButtons.Left)
			{
				TB = Tb;
				CmsTextSelect.Show(Cursor.Position);
			}
		}

		private void CmsTextSelect_コピー_Click(object sender, EventArgs e)
		{
			TB.Copy();
		}

		private void CmsTextSelect_ネット検索_Google_Click(object sender, EventArgs e)
		{
			SubNetSearch("https://www.google.co.jp/search?q=");
		}

		private void CmsTextSelect_ネット検索_YouTube_Click(object sender, EventArgs e)
		{
			SubNetSearch("https://www.youtube.com/results?search_query=");
		}

		private void CmsTextSelect_ネット検索_Wikipedia_Click(object sender, EventArgs e)
		{
			SubNetSearch("https://ja.wikipedia.org/wiki/");
		}

		private void SubNetSearch(string url)
		{
			_ = Process.Start(url + HttpUtility.UrlEncode(TB.SelectedText));
		}
	}

	public class Pub
	{
		public static int Rtn = 0;
	}

	public class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());

			Console.Write(Pub.Rtn);
		}
	}
}
