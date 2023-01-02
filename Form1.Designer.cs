namespace iwm_MsgBox
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.BtnNo = new System.Windows.Forms.Button();
			this.BtnYes = new System.Windows.Forms.Button();
			this.CbAccept = new System.Windows.Forms.CheckBox();
			this.CmsResult = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsResult_AllCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_tss01 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsResult_FontSizeUp = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_FontSizeDn = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsTextSelect_コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_tss01 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsTextSelect_ネット検索 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_ネット検索_Google = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_ネット検索_YouTube = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_ネット検索_Wikipedia = new System.Windows.Forms.ToolStripMenuItem();
			this.TbText = new System.Windows.Forms.TextBox();
			this.CmsResult.SuspendLayout();
			this.CmsTextSelect.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.BtnCancel.FlatAppearance.BorderSize = 0;
			this.BtnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
			this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtnCancel.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnCancel.Location = new System.Drawing.Point(307, 408);
			this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(70, 24);
			this.BtnCancel.TabIndex = 4;
			this.BtnCancel.Text = "閉じる";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// BtnNo
			// 
			this.BtnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnNo.BackColor = System.Drawing.SystemColors.ControlLight;
			this.BtnNo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnNo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.BtnNo.FlatAppearance.BorderSize = 0;
			this.BtnNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
			this.BtnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.BtnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtnNo.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnNo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnNo.Location = new System.Drawing.Point(235, 408);
			this.BtnNo.Margin = new System.Windows.Forms.Padding(0);
			this.BtnNo.Name = "BtnNo";
			this.BtnNo.Size = new System.Drawing.Size(70, 24);
			this.BtnNo.TabIndex = 3;
			this.BtnNo.Text = "いいえ";
			this.BtnNo.UseVisualStyleBackColor = true;
			this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
			// 
			// BtnYes
			// 
			this.BtnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnYes.BackColor = System.Drawing.SystemColors.ControlLight;
			this.BtnYes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnYes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.BtnYes.FlatAppearance.BorderSize = 0;
			this.BtnYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
			this.BtnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.BtnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtnYes.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnYes.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnYes.Location = new System.Drawing.Point(163, 408);
			this.BtnYes.Margin = new System.Windows.Forms.Padding(0);
			this.BtnYes.Name = "BtnYes";
			this.BtnYes.Size = new System.Drawing.Size(70, 24);
			this.BtnYes.TabIndex = 2;
			this.BtnYes.Text = "はい";
			this.BtnYes.UseVisualStyleBackColor = true;
			this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
			// 
			// CbAccept
			// 
			this.CbAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CbAccept.AutoSize = true;
			this.CbAccept.BackColor = System.Drawing.SystemColors.Control;
			this.CbAccept.Checked = true;
			this.CbAccept.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CbAccept.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CbAccept.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CbAccept.Location = new System.Drawing.Point(10, 385);
			this.CbAccept.Margin = new System.Windows.Forms.Padding(0);
			this.CbAccept.Name = "CbAccept";
			this.CbAccept.Size = new System.Drawing.Size(157, 17);
			this.CbAccept.TabIndex = 1;
			this.CbAccept.Text = "上記内容を承諾します。";
			this.CbAccept.UseVisualStyleBackColor = true;
			this.CbAccept.CheckedChanged += new System.EventHandler(this.CbAccept_CheckedChanged);
			// 
			// CmsResult
			// 
			this.CmsResult.BackColor = System.Drawing.SystemColors.Control;
			this.CmsResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsResult_AllCopy,
			this.CmsResult_tss01,
			this.CmsResult_FontSizeUp,
			this.CmsResult_FontSizeDn});
			this.CmsResult.Name = "CmsTbSaveFileName";
			this.CmsResult.Size = new System.Drawing.Size(164, 76);
			this.CmsResult.Paint += new System.Windows.Forms.PaintEventHandler(this.CmsResult_Paint);
			// 
			// CmsResult_AllCopy
			// 
			this.CmsResult_AllCopy.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmsResult_AllCopy.Name = "CmsResult_AllCopy";
			this.CmsResult_AllCopy.Size = new System.Drawing.Size(163, 22);
			this.CmsResult_AllCopy.Text = "全コピー";
			this.CmsResult_AllCopy.Click += new System.EventHandler(this.CmsResult_AllCopy_Click);
			// 
			// CmsResult_tss01
			// 
			this.CmsResult_tss01.Name = "CmsResult_tss01";
			this.CmsResult_tss01.Size = new System.Drawing.Size(160, 6);
			// 
			// CmsResult_FontSizeUp
			// 
			this.CmsResult_FontSizeUp.Name = "CmsResult_FontSizeUp";
			this.CmsResult_FontSizeUp.Size = new System.Drawing.Size(163, 22);
			this.CmsResult_FontSizeUp.Text = "フォントを大きくする";
			this.CmsResult_FontSizeUp.Click += new System.EventHandler(this.CmsResult_FontSizeUp_Click);
			// 
			// CmsResult_FontSizeDn
			// 
			this.CmsResult_FontSizeDn.Name = "CmsResult_FontSizeDn";
			this.CmsResult_FontSizeDn.Size = new System.Drawing.Size(163, 22);
			this.CmsResult_FontSizeDn.Text = "フォントを小さくする";
			this.CmsResult_FontSizeDn.Click += new System.EventHandler(this.CmsResult_FontSizeDn_Click);
			// 
			// CmsTextSelect
			// 
			this.CmsTextSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsTextSelect_コピー,
			this.CmsTextSelect_tss01,
			this.CmsTextSelect_ネット検索});
			this.CmsTextSelect.Name = "CmsResult";
			this.CmsTextSelect.Size = new System.Drawing.Size(125, 54);
			// 
			// CmsTextSelect_コピー
			// 
			this.CmsTextSelect_コピー.Name = "CmsTextSelect_コピー";
			this.CmsTextSelect_コピー.Size = new System.Drawing.Size(124, 22);
			this.CmsTextSelect_コピー.Text = "コピー";
			this.CmsTextSelect_コピー.Click += new System.EventHandler(this.CmsTextSelect_コピー_Click);
			// 
			// CmsTextSelect_tss01
			// 
			this.CmsTextSelect_tss01.Name = "CmsTextSelect_tss01";
			this.CmsTextSelect_tss01.Size = new System.Drawing.Size(121, 6);
			// 
			// CmsTextSelect_ネット検索
			// 
			this.CmsTextSelect_ネット検索.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsTextSelect_ネット検索_Google,
			this.CmsTextSelect_ネット検索_YouTube,
			this.CmsTextSelect_ネット検索_Wikipedia});
			this.CmsTextSelect_ネット検索.Name = "CmsTextSelect_ネット検索";
			this.CmsTextSelect_ネット検索.Size = new System.Drawing.Size(124, 22);
			this.CmsTextSelect_ネット検索.Text = "ネット検索";
			// 
			// CmsTextSelect_ネット検索_Google
			// 
			this.CmsTextSelect_ネット検索_Google.Name = "CmsTextSelect_ネット検索_Google";
			this.CmsTextSelect_ネット検索_Google.Size = new System.Drawing.Size(126, 22);
			this.CmsTextSelect_ネット検索_Google.Text = "Google";
			this.CmsTextSelect_ネット検索_Google.Click += new System.EventHandler(this.CmsTextSelect_ネット検索_Google_Click);
			// 
			// CmsTextSelect_ネット検索_YouTube
			// 
			this.CmsTextSelect_ネット検索_YouTube.Name = "CmsTextSelect_ネット検索_YouTube";
			this.CmsTextSelect_ネット検索_YouTube.Size = new System.Drawing.Size(126, 22);
			this.CmsTextSelect_ネット検索_YouTube.Text = "YouTube";
			this.CmsTextSelect_ネット検索_YouTube.Click += new System.EventHandler(this.CmsTextSelect_ネット検索_YouTube_Click);
			// 
			// CmsTextSelect_ネット検索_Wikipedia
			// 
			this.CmsTextSelect_ネット検索_Wikipedia.Name = "CmsTextSelect_ネット検索_Wikipedia";
			this.CmsTextSelect_ネット検索_Wikipedia.Size = new System.Drawing.Size(126, 22);
			this.CmsTextSelect_ネット検索_Wikipedia.Text = "Wikipedia";
			this.CmsTextSelect_ネット検索_Wikipedia.Click += new System.EventHandler(this.CmsTextSelect_ネット検索_Wikipedia_Click);
			// 
			// TbText
			// 
			this.TbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TbText.BackColor = System.Drawing.Color.White;
			this.TbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbText.ContextMenuStrip = this.CmsResult;
			this.TbText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbText.ForeColor = System.Drawing.Color.Black;
			this.TbText.Location = new System.Drawing.Point(0, 0);
			this.TbText.Margin = new System.Windows.Forms.Padding(0);
			this.TbText.MaxLength = 2147483647;
			this.TbText.Multiline = true;
			this.TbText.Name = "TbText";
			this.TbText.ReadOnly = true;
			this.TbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TbText.Size = new System.Drawing.Size(383, 380);
			this.TbText.TabIndex = 0;
			this.TbText.TabStop = false;
			this.TbText.WordWrap = false;
			this.TbText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TbText_MouseUp);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(384, 441);
			this.Controls.Add(this.BtnYes);
			this.Controls.Add(this.BtnNo);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.TbText);
			this.Controls.Add(this.CbAccept);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(250, 160);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.CmsResult.ResumeLayout(false);
			this.CmsTextSelect.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnNo;
		private System.Windows.Forms.Button BtnYes;
		private System.Windows.Forms.CheckBox CbAccept;
		private System.Windows.Forms.ContextMenuStrip CmsResult;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_AllCopy;
		private System.Windows.Forms.ToolStripSeparator CmsResult_tss01;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_FontSizeUp;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_FontSizeDn;
		private System.Windows.Forms.ContextMenuStrip CmsTextSelect;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_コピー;
		private System.Windows.Forms.ToolStripSeparator CmsTextSelect_tss01;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_ネット検索;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_ネット検索_Google;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_ネット検索_YouTube;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_ネット検索_Wikipedia;
		private System.Windows.Forms.TextBox TbText;
	}
}

