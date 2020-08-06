namespace olive.Form
{
	partial class Frm_bookinDelay
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.sb_cancel = new DevExpress.XtraEditors.SimpleButton();
			this.sb_ok = new DevExpress.XtraEditors.SimpleButton();
			this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.te_bk005 = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.te_bk003 = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.be_position = new DevExpress.XtraEditors.ButtonEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.session1 = new DevExpress.Xpo.Session(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.te_bk005.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.te_bk003.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.be_position.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
			this.SuspendLayout();
			// 
			// sb_cancel
			// 
			this.sb_cancel.Appearance.BackColor = System.Drawing.Color.Aqua;
			this.sb_cancel.Appearance.ForeColor = System.Drawing.Color.Black;
			this.sb_cancel.Appearance.Options.UseBackColor = true;
			this.sb_cancel.Appearance.Options.UseForeColor = true;
			this.sb_cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.sb_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.sb_cancel.Location = new System.Drawing.Point(294, 229);
			this.sb_cancel.LookAndFeel.UseDefaultLookAndFeel = false;
			this.sb_cancel.Name = "sb_cancel";
			this.sb_cancel.Size = new System.Drawing.Size(124, 30);
			this.sb_cancel.TabIndex = 77;
			this.sb_cancel.Text = "关闭";
			// 
			// sb_ok
			// 
			this.sb_ok.Appearance.BackColor = System.Drawing.Color.LightGreen;
			this.sb_ok.Appearance.ForeColor = System.Drawing.Color.Black;
			this.sb_ok.Appearance.Options.UseBackColor = true;
			this.sb_ok.Appearance.Options.UseForeColor = true;
			this.sb_ok.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.sb_ok.Location = new System.Drawing.Point(164, 229);
			this.sb_ok.LookAndFeel.UseDefaultLookAndFeel = false;
			this.sb_ok.Name = "sb_ok";
			this.sb_ok.Size = new System.Drawing.Size(124, 30);
			this.sb_ok.TabIndex = 76;
			this.sb_ok.Text = "确定";
			// 
			// dateEdit1
			// 
			this.dateEdit1.EditValue = null;
			this.dateEdit1.Location = new System.Drawing.Point(115, 166);
			this.dateEdit1.Name = "dateEdit1";
			this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit1.Size = new System.Drawing.Size(125, 28);
			this.dateEdit1.TabIndex = 75;
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Image = null;
			this.labelControl4.AppearanceDisabled.Image = null;
			this.labelControl4.AppearanceHovered.Image = null;
			this.labelControl4.AppearancePressed.Image = null;
			this.labelControl4.Location = new System.Drawing.Point(19, 170);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(72, 22);
			this.labelControl4.TabIndex = 74;
			this.labelControl4.Text = "截至日期";
			// 
			// te_bk005
			// 
			this.te_bk005.Location = new System.Drawing.Point(115, 114);
			this.te_bk005.Name = "te_bk005";
			this.te_bk005.Properties.ReadOnly = true;
			this.te_bk005.Size = new System.Drawing.Size(302, 28);
			this.te_bk005.TabIndex = 73;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Image = null;
			this.labelControl3.AppearanceDisabled.Image = null;
			this.labelControl3.AppearanceHovered.Image = null;
			this.labelControl3.AppearancePressed.Image = null;
			this.labelControl3.Location = new System.Drawing.Point(19, 118);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(72, 22);
			this.labelControl3.TabIndex = 72;
			this.labelControl3.Text = "联系电话";
			// 
			// te_bk003
			// 
			this.te_bk003.Location = new System.Drawing.Point(115, 63);
			this.te_bk003.Name = "te_bk003";
			this.te_bk003.Properties.ReadOnly = true;
			this.te_bk003.Size = new System.Drawing.Size(125, 28);
			this.te_bk003.TabIndex = 71;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Image = null;
			this.labelControl2.AppearanceDisabled.Image = null;
			this.labelControl2.AppearanceHovered.Image = null;
			this.labelControl2.AppearancePressed.Image = null;
			this.labelControl2.Location = new System.Drawing.Point(19, 65);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(54, 22);
			this.labelControl2.TabIndex = 70;
			this.labelControl2.Text = "预定人";
			// 
			// be_position
			// 
			this.be_position.Location = new System.Drawing.Point(115, 11);
			this.be_position.Name = "be_position";
			this.be_position.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.be_position.Properties.ReadOnly = true;
			this.be_position.Size = new System.Drawing.Size(302, 28);
			this.be_position.TabIndex = 69;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Image = null;
			this.labelControl1.AppearanceDisabled.Image = null;
			this.labelControl1.AppearanceHovered.Image = null;
			this.labelControl1.AppearancePressed.Image = null;
			this.labelControl1.Location = new System.Drawing.Point(19, 15);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(72, 22);
			this.labelControl1.TabIndex = 68;
			this.labelControl1.Text = "墓穴位置";
			// 
			// session1
			// 
			this.session1.IsObjectModifiedOnNonPersistentPropertyChange = null;
			this.session1.TrackPropertiesModifications = false;
			// 
			// Frm_bookinDelay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 279);
			this.Controls.Add(this.sb_cancel);
			this.Controls.Add(this.sb_ok);
			this.Controls.Add(this.dateEdit1);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.te_bk005);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.te_bk003);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.be_position);
			this.Controls.Add(this.labelControl1);
			this.Name = "Frm_bookinDelay";
			this.Text = "预定延期";
			this.Load += new System.EventHandler(this.Frm_bookinDelay_Load);
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.te_bk005.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.te_bk003.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.be_position.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton sb_cancel;
		private DevExpress.XtraEditors.SimpleButton sb_ok;
		private DevExpress.XtraEditors.DateEdit dateEdit1;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.TextEdit te_bk005;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit te_bk003;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.ButtonEdit be_position;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.Xpo.Session session1;
	}
}