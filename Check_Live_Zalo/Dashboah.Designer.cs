namespace Check_Live_Zalo
{
    partial class Dashboah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboah));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCheckStatus = new Guna.UI2.WinForms.Guna2Button();
            this.PhoneNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_fail = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_Profile = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_listProfile = new Guna.UI2.WinForms.Guna2ComboBox();
            this.menu_cbxXOA = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.xAOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_profile = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_AddProfile = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.lb_SL = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_VHH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Profile)).BeginInit();
            this.menu_cbxXOA.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.BorderRadius = 5;
            this.btnCheckStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnCheckStatus, "btnCheckStatus");
            this.btnCheckStatus.ForeColor = System.Drawing.Color.White;
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.PhoneNumberTextBox.BorderRadius = 5;
            this.PhoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberTextBox.DefaultText = "";
            this.PhoneNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.PhoneNumberTextBox, "PhoneNumberTextBox");
            this.PhoneNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.PhoneNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumberTextBox.Multiline = true;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.PasswordChar = '\0';
            this.PhoneNumberTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.PhoneNumberTextBox.PlaceholderText = "";
            this.PhoneNumberTextBox.SelectedText = "";
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // txt_fail
            // 
            this.txt_fail.BorderRadius = 5;
            this.txt_fail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fail.DefaultText = "";
            this.txt_fail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_fail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_fail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.txt_fail, "txt_fail");
            this.txt_fail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fail.Multiline = true;
            this.txt_fail.Name = "txt_fail";
            this.txt_fail.PasswordChar = '\0';
            this.txt_fail.PlaceholderText = "";
            this.txt_fail.SelectedText = "";
            this.txt_fail.TextChanged += new System.EventHandler(this.txt_fail_TextChanged);
            // 
            // dgv_Profile
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Profile.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Profile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Profile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgv_Profile, "dgv_Profile");
            this.dgv_Profile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Profile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SDT,
            this.status,
            this.name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Profile.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Profile.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Profile.Name = "dgv_Profile";
            this.dgv_Profile.RowHeadersVisible = false;
            this.dgv_Profile.RowTemplate.Height = 25;
            this.dgv_Profile.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Profile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Profile.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Profile.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Profile.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Profile.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Profile.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Profile.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Profile.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Profile.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Profile.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Profile.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Profile.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Profile.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Profile.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_Profile.ThemeStyle.ReadOnly = false;
            this.dgv_Profile.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Profile.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Profile.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Profile.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Profile.ThemeStyle.RowsStyle.Height = 25;
            this.dgv_Profile.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Profile.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            resources.ApplyResources(this.STT, "STT");
            this.STT.Name = "STT";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SDT.DataPropertyName = "SDT";
            resources.ApplyResources(this.SDT, "SDT");
            this.SDT.Name = "SDT";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.status.DataPropertyName = "status";
            resources.ApplyResources(this.status, "status");
            this.status.Name = "status";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            // 
            // cbx_listProfile
            // 
            this.cbx_listProfile.BackColor = System.Drawing.Color.Transparent;
            this.cbx_listProfile.BorderRadius = 5;
            this.cbx_listProfile.ContextMenuStrip = this.menu_cbxXOA;
            this.cbx_listProfile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_listProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_listProfile.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_listProfile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.cbx_listProfile, "cbx_listProfile");
            this.cbx_listProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_listProfile.Items.AddRange(new object[] {
            resources.GetString("cbx_listProfile.Items")});
            this.cbx_listProfile.Name = "cbx_listProfile";
            this.cbx_listProfile.StartIndex = 0;
            // 
            // menu_cbxXOA
            // 
            this.menu_cbxXOA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xAOSToolStripMenuItem});
            this.menu_cbxXOA.Name = "menu_cbxXOA";
            this.menu_cbxXOA.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menu_cbxXOA.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.menu_cbxXOA.RenderStyle.ColorTable = null;
            this.menu_cbxXOA.RenderStyle.RoundedEdges = true;
            this.menu_cbxXOA.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.menu_cbxXOA.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menu_cbxXOA.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.menu_cbxXOA.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.menu_cbxXOA.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            resources.ApplyResources(this.menu_cbxXOA, "menu_cbxXOA");
            // 
            // xAOSToolStripMenuItem
            // 
            this.xAOSToolStripMenuItem.Name = "xAOSToolStripMenuItem";
            resources.ApplyResources(this.xAOSToolStripMenuItem, "xAOSToolStripMenuItem");
            this.xAOSToolStripMenuItem.Click += new System.EventHandler(this.xAOSToolStripMenuItem_Click);
            // 
            // txt_profile
            // 
            this.txt_profile.BorderRadius = 5;
            this.txt_profile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_profile.DefaultText = "";
            this.txt_profile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_profile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_profile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_profile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_profile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txt_profile, "txt_profile");
            this.txt_profile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_profile.Name = "txt_profile";
            this.txt_profile.PasswordChar = '\0';
            this.txt_profile.PlaceholderText = "";
            this.txt_profile.SelectedText = "";
            // 
            // btn_AddProfile
            // 
            this.btn_AddProfile.BorderRadius = 5;
            this.btn_AddProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btn_AddProfile, "btn_AddProfile");
            this.btn_AddProfile.ForeColor = System.Drawing.Color.White;
            this.btn_AddProfile.Name = "btn_AddProfile";
            this.btn_AddProfile.Click += new System.EventHandler(this.btn_AddProfile_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel1, "guna2HtmlLabel1");
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            // 
            // btn_Login
            // 
            this.btn_Login.BorderRadius = 5;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btn_Login, "btn_Login");
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lb_SL
            // 
            this.lb_SL.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lb_SL, "lb_SL");
            this.lb_SL.Name = "lb_SL";
            // 
            // lb_VHH
            // 
            this.lb_VHH.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lb_VHH, "lb_VHH");
            this.lb_VHH.Name = "lb_VHH";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dgv_Profile);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.Name = "guna2Panel1";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.cbx_listProfile);
            this.guna2Panel3.Controls.Add(this.btn_AddProfile);
            this.guna2Panel3.Controls.Add(this.txt_profile);
            this.guna2Panel3.Controls.Add(this.btn_Login);
            resources.ApplyResources(this.guna2Panel3, "guna2Panel3");
            this.guna2Panel3.Name = "guna2Panel3";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.PhoneNumberTextBox);
            this.guna2Panel2.Controls.Add(this.btnCheckStatus);
            this.guna2Panel2.Controls.Add(this.txt_fail);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            resources.ApplyResources(this.guna2Panel2, "guna2Panel2");
            this.guna2Panel2.Name = "guna2Panel2";
            // 
            // Dashboah
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lb_VHH);
            this.Controls.Add(this.lb_SL);
            this.Name = "Dashboah";
            this.Opacity = 0.95D;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboah_FormClosed);
            this.Load += new System.EventHandler(this.Dashboah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Profile)).EndInit();
            this.menu_cbxXOA.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCheckStatus;
        private Guna.UI2.WinForms.Guna2TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox txt_fail;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Profile;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_listProfile;
        private Guna.UI2.WinForms.Guna2TextBox txt_profile;
        private Guna.UI2.WinForms.Guna2Button btn_AddProfile;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip menu_cbxXOA;
        private System.Windows.Forms.ToolStripMenuItem xAOSToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_SL;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_VHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    }
}

