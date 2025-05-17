namespace Mini_Case_Study
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_disableds = new System.Windows.Forms.CheckBox();
            this.b_SaveUser = new System.Windows.Forms.Button();
            this.b_NewUser = new System.Windows.Forms.Button();
            this.GB_UserInfo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_roles = new System.Windows.Forms.ComboBox();
            this.Cb_IsEnabled = new System.Windows.Forms.CheckBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_displayname = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_UserInfo = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.GB_UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.cb_disableds);
            this.groupBox1.Controls.Add(this.b_SaveUser);
            this.groupBox1.Controls.Add(this.b_NewUser);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cb_disableds
            // 
            this.cb_disableds.AutoSize = true;
            this.cb_disableds.Location = new System.Drawing.Point(147, 30);
            this.cb_disableds.Name = "cb_disableds";
            this.cb_disableds.Size = new System.Drawing.Size(122, 17);
            this.cb_disableds.TabIndex = 3;
            this.cb_disableds.Text = "Hide Disabled Users";
            this.cb_disableds.UseVisualStyleBackColor = true;
            this.cb_disableds.CheckedChanged += new System.EventHandler(this.cb_disableds_CheckedChanged);
            // 
            // b_SaveUser
            // 
            this.b_SaveUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_SaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_SaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_SaveUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_SaveUser.Location = new System.Drawing.Point(822, 12);
            this.b_SaveUser.Name = "b_SaveUser";
            this.b_SaveUser.Size = new System.Drawing.Size(117, 50);
            this.b_SaveUser.TabIndex = 2;
            this.b_SaveUser.Text = "Save User";
            this.b_SaveUser.UseVisualStyleBackColor = false;
            this.b_SaveUser.Visible = false;
            this.b_SaveUser.Click += new System.EventHandler(this.b_SaveUser_Click);
            // 
            // b_NewUser
            // 
            this.b_NewUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_NewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_NewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_NewUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_NewUser.Location = new System.Drawing.Point(11, 12);
            this.b_NewUser.Name = "b_NewUser";
            this.b_NewUser.Size = new System.Drawing.Size(117, 50);
            this.b_NewUser.TabIndex = 1;
            this.b_NewUser.Text = "+ New User";
            this.b_NewUser.UseVisualStyleBackColor = false;
            this.b_NewUser.Click += new System.EventHandler(this.b_NewUser_Click);
            // 
            // GB_UserInfo
            // 
            this.GB_UserInfo.Controls.Add(this.panel1);
            this.GB_UserInfo.Controls.Add(this.cb_roles);
            this.GB_UserInfo.Controls.Add(this.Cb_IsEnabled);
            this.GB_UserInfo.Controls.Add(this.tb_email);
            this.GB_UserInfo.Controls.Add(this.tb_phone);
            this.GB_UserInfo.Controls.Add(this.tb_displayname);
            this.GB_UserInfo.Controls.Add(this.tb_Username);
            this.GB_UserInfo.Controls.Add(this.label5);
            this.GB_UserInfo.Controls.Add(this.label6);
            this.GB_UserInfo.Controls.Add(this.label7);
            this.GB_UserInfo.Controls.Add(this.label4);
            this.GB_UserInfo.Controls.Add(this.label3);
            this.GB_UserInfo.Controls.Add(this.label2);
            this.GB_UserInfo.Controls.Add(this.label1);
            this.GB_UserInfo.Location = new System.Drawing.Point(448, 75);
            this.GB_UserInfo.Name = "GB_UserInfo";
            this.GB_UserInfo.Size = new System.Drawing.Size(499, 427);
            this.GB_UserInfo.TabIndex = 2;
            this.GB_UserInfo.TabStop = false;
            this.GB_UserInfo.Text = "groupBox2";
            this.GB_UserInfo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 63);
            this.panel1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(21, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "New User";
            // 
            // cb_roles
            // 
            this.cb_roles.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cb_roles.FormattingEnabled = true;
            this.cb_roles.Items.AddRange(new object[] {
            "Guest",
            "Admin",
            "SuperAdmin"});
            this.cb_roles.Location = new System.Drawing.Point(172, 318);
            this.cb_roles.Name = "cb_roles";
            this.cb_roles.Size = new System.Drawing.Size(135, 21);
            this.cb_roles.TabIndex = 13;
            this.cb_roles.Text = "Select Role";
            // 
            // Cb_IsEnabled
            // 
            this.Cb_IsEnabled.AutoSize = true;
            this.Cb_IsEnabled.Location = new System.Drawing.Point(172, 373);
            this.Cb_IsEnabled.Name = "Cb_IsEnabled";
            this.Cb_IsEnabled.Size = new System.Drawing.Size(15, 14);
            this.Cb_IsEnabled.TabIndex = 3;
            this.Cb_IsEnabled.UseVisualStyleBackColor = true;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(172, 252);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(315, 30);
            this.tb_email.TabIndex = 12;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(172, 199);
            this.tb_phone.Multiline = true;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(315, 30);
            this.tb_phone.TabIndex = 11;
            // 
            // tb_displayname
            // 
            this.tb_displayname.Location = new System.Drawing.Point(172, 142);
            this.tb_displayname.Multiline = true;
            this.tb_displayname.Name = "tb_displayname";
            this.tb_displayname.Size = new System.Drawing.Size(315, 30);
            this.tb_displayname.TabIndex = 10;
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(172, 88);
            this.tb_Username.Multiline = true;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(315, 30);
            this.tb_Username.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enabled";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "User Roles :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(28, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Display Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // DGV_UserInfo
            // 
            this.DGV_UserInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_UserInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_UserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_UserInfo.Location = new System.Drawing.Point(0, 75);
            this.DGV_UserInfo.Name = "DGV_UserInfo";
            this.DGV_UserInfo.ReadOnly = true;
            this.DGV_UserInfo.Size = new System.Drawing.Size(442, 418);
            this.DGV_UserInfo.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mini_Case_Study.Properties.Resources.piworks_share;
            this.pictureBox1.Location = new System.Drawing.Point(439, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 490);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGV_UserInfo);
            this.Controls.Add(this.GB_UserInfo);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB_UserInfo.ResumeLayout(false);
            this.GB_UserInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_disableds;
        private System.Windows.Forms.Button b_SaveUser;
        private System.Windows.Forms.Button b_NewUser;
        private System.Windows.Forms.GroupBox GB_UserInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_roles;
        private System.Windows.Forms.CheckBox Cb_IsEnabled;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_displayname;
        private System.Windows.Forms.DataGridView DGV_UserInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

