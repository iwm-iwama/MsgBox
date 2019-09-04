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
			this.TbText = new System.Windows.Forms.TextBox();
			this.CmsResult = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsResult_PgUp = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_PgDn = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_L1 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsResult_AllSelect = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_Copy = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_L2 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsResult_FontSizeUp = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_FontSizeDn = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnYes = new System.Windows.Forms.Button();
			this.BtnNo = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.CmsResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// TbText
			// 
			this.TbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbText.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.TbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbText.ContextMenuStrip = this.CmsResult;
			this.TbText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbText.ForeColor = System.Drawing.SystemColors.InfoText;
			this.TbText.Location = new System.Drawing.Point(5, 5);
			this.TbText.Margin = new System.Windows.Forms.Padding(0);
			this.TbText.MaxLength = 2147483647;
			this.TbText.Multiline = true;
			this.TbText.Name = "TbText";
			this.TbText.ReadOnly = true;
			this.TbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TbText.Size = new System.Drawing.Size(215, 40);
			this.TbText.TabIndex = 3;
			this.TbText.TabStop = false;
			this.TbText.WordWrap = false;
			// 
			// CmsResult
			// 
			this.CmsResult.BackColor = System.Drawing.SystemColors.Control;
			this.CmsResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsResult_PgUp,
            this.CmsResult_PgDn,
            this.CmsResult_L1,
            this.CmsResult_FontSizeUp,
            this.CmsResult_FontSizeDn,
            this.CmsResult_L2,
            this.CmsResult_AllSelect,
            this.CmsResult_Copy});
			this.CmsResult.Name = "CmsTbSaveFileName";
			this.CmsResult.Size = new System.Drawing.Size(197, 170);
			// 
			// CmsResult_PgUp
			// 
			this.CmsResult_PgUp.ForeColor = System.Drawing.Color.OrangeRed;
			this.CmsResult_PgUp.Name = "CmsResult_PgUp";
			this.CmsResult_PgUp.Size = new System.Drawing.Size(196, 22);
			this.CmsResult_PgUp.Text = "▲";
			this.CmsResult_PgUp.Click += new System.EventHandler(this.CmsResult_PgUp_Click);
			// 
			// CmsResult_PgDn
			// 
			this.CmsResult_PgDn.ForeColor = System.Drawing.Color.OrangeRed;
			this.CmsResult_PgDn.Name = "CmsResult_PgDn";
			this.CmsResult_PgDn.Size = new System.Drawing.Size(196, 22);
			this.CmsResult_PgDn.Text = "▼";
			this.CmsResult_PgDn.Click += new System.EventHandler(this.CmsResult_PgDn_Click);
			// 
			// CmsResult_L1
			// 
			this.CmsResult_L1.Name = "CmsResult_L1";
			this.CmsResult_L1.Size = new System.Drawing.Size(193, 6);
			// 
			// CmsResult_AllSelect
			// 
			this.CmsResult_AllSelect.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmsResult_AllSelect.Name = "CmsResult_AllSelect";
			this.CmsResult_AllSelect.Size = new System.Drawing.Size(196, 22);
			this.CmsResult_AllSelect.Text = "全選択";
			this.CmsResult_AllSelect.Click += new System.EventHandler(this.CmsResult_AllSelect_Click);
			// 
			// CmsResult_Copy
			// 
			this.CmsResult_Copy.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmsResult_Copy.Name = "CmsResult_Copy";
			this.CmsResult_Copy.Size = new System.Drawing.Size(196, 22);
			this.CmsResult_Copy.Text = "コピー";
			this.CmsResult_Copy.Click += new System.EventHandler(this.CmsResult_Copy_Click);
			// 
			// CmsResult_L2
			// 
			this.CmsResult_L2.Name = "CmsResult_L2";
			this.CmsResult_L2.Size = new System.Drawing.Size(193, 6);
			// 
			// CmsResult_FontSizeUp
			// 
			this.CmsResult_FontSizeUp.Name = "CmsResult_FontSizeUp";
			this.CmsResult_FontSizeUp.Size = new System.Drawing.Size(196, 22);
			this.CmsResult_FontSizeUp.Text = "フォントを大きくする";
			this.CmsResult_FontSizeUp.Click += new System.EventHandler(this.CmsResult_FontSizeUp_Click);
			// 
			// CmsResult_FontSizeDn
			// 
			this.CmsResult_FontSizeDn.Name = "CmsResult_FontSizeDn";
			this.CmsResult_FontSizeDn.Size = new System.Drawing.Size(196, 22);
			this.CmsResult_FontSizeDn.Text = "フォントを小さくする";
			this.CmsResult_FontSizeDn.Click += new System.EventHandler(this.CmsResult_FontSizeDn_Click);
			// 
			// BtnYes
			// 
			this.BtnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnYes.BackColor = System.Drawing.SystemColors.ControlLight;
			this.BtnYes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.BtnYes.FlatAppearance.BorderSize = 0;
			this.BtnYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
			this.BtnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.BtnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtnYes.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnYes.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnYes.Location = new System.Drawing.Point(10, 50);
			this.BtnYes.Margin = new System.Windows.Forms.Padding(0);
			this.BtnYes.Name = "BtnYes";
			this.BtnYes.Size = new System.Drawing.Size(63, 24);
			this.BtnYes.TabIndex = 0;
			this.BtnYes.Text = "はい";
			this.BtnYes.UseVisualStyleBackColor = false;
			this.BtnYes.Click += new System.EventHandler(this.Button0_Click);
			// 
			// BtnNo
			// 
			this.BtnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnNo.BackColor = System.Drawing.SystemColors.ControlLight;
			this.BtnNo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.BtnNo.FlatAppearance.BorderSize = 0;
			this.BtnNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
			this.BtnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.BtnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtnNo.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnNo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnNo.Location = new System.Drawing.Point(80, 50);
			this.BtnNo.Margin = new System.Windows.Forms.Padding(0);
			this.BtnNo.Name = "BtnNo";
			this.BtnNo.Size = new System.Drawing.Size(63, 24);
			this.BtnNo.TabIndex = 1;
			this.BtnNo.Text = "いいえ";
			this.BtnNo.UseVisualStyleBackColor = false;
			this.BtnNo.Click += new System.EventHandler(this.Button1_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.BtnCancel.FlatAppearance.BorderSize = 0;
			this.BtnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
			this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtnCancel.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnCancel.Location = new System.Drawing.Point(150, 50);
			this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(63, 24);
			this.BtnCancel.TabIndex = 2;
			this.BtnCancel.Text = "閉じる";
			this.BtnCancel.UseVisualStyleBackColor = false;
			this.BtnCancel.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(224, 81);
			this.Controls.Add(this.BtnYes);
			this.Controls.Add(this.BtnNo);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.TbText);
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(240, 120);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.CmsResult.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TbText;
		private System.Windows.Forms.Button BtnYes;
		private System.Windows.Forms.Button BtnNo;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.ContextMenuStrip CmsResult;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_PgUp;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_PgDn;
		private System.Windows.Forms.ToolStripSeparator CmsResult_L1;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_AllSelect;
		private System.Windows.Forms.ToolStripSeparator CmsResult_L2;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_Copy;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_FontSizeUp;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_FontSizeDn;
	}
}

