namespace WFGoodFood.GUI
{
    partial class LoginForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtboxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtboxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.ButLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbClear = new System.Windows.Forms.Label();
            this.cboxRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pbIconPass = new System.Windows.Forms.PictureBox();
            this.pbIconUser = new System.Windows.Forms.PictureBox();
            this.pBImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(82, 68);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(190, 37);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "My Food App";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.Location = new System.Drawing.Point(85, 150);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(62, 13);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "User Name";
            // 
            // txtboxUserName
            // 
            this.txtboxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtboxUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtboxUserName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtboxUserName.BorderThickness = 0;
            this.txtboxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxUserName.DefaultText = "";
            this.txtboxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxUserName.DisabledState.Parent = this.txtboxUserName;
            this.txtboxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtboxUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxUserName.FocusedState.Parent = this.txtboxUserName;
            this.txtboxUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxUserName.HoverState.Parent = this.txtboxUserName;
            this.txtboxUserName.Location = new System.Drawing.Point(88, 169);
            this.txtboxUserName.Name = "txtboxUserName";
            this.txtboxUserName.PasswordChar = '\0';
            this.txtboxUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtboxUserName.PlaceholderText = "";
            this.txtboxUserName.SelectedText = "";
            this.txtboxUserName.ShadowDecoration.Parent = this.txtboxUserName;
            this.txtboxUserName.Size = new System.Drawing.Size(200, 30);
            this.txtboxUserName.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.Location = new System.Drawing.Point(85, 241);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtboxPassword.BorderThickness = 0;
            this.txtboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxPassword.DefaultText = "";
            this.txtboxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxPassword.DisabledState.Parent = this.txtboxPassword;
            this.txtboxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtboxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxPassword.FocusedState.Parent = this.txtboxPassword;
            this.txtboxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxPassword.HoverState.Parent = this.txtboxPassword;
            this.txtboxPassword.Location = new System.Drawing.Point(88, 260);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtboxPassword.PlaceholderText = "";
            this.txtboxPassword.SelectedText = "";
            this.txtboxPassword.ShadowDecoration.Parent = this.txtboxPassword;
            this.txtboxPassword.Size = new System.Drawing.Size(200, 30);
            this.txtboxPassword.TabIndex = 7;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(88, 197);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 8;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(88, 288);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator2.TabIndex = 9;
            // 
            // ButLogin
            // 
            this.ButLogin.BorderRadius = 20;
            this.ButLogin.CheckedState.Parent = this.ButLogin;
            this.ButLogin.CustomImages.Parent = this.ButLogin;
            this.ButLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButLogin.DisabledState.Parent = this.ButLogin;
            this.ButLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.ButLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButLogin.ForeColor = System.Drawing.Color.White;
            this.ButLogin.HoverState.Parent = this.ButLogin;
            this.ButLogin.Location = new System.Drawing.Point(101, 341);
            this.ButLogin.Name = "ButLogin";
            this.ButLogin.ShadowDecoration.Parent = this.ButLogin;
            this.ButLogin.Size = new System.Drawing.Size(125, 42);
            this.ButLogin.TabIndex = 10;
            this.ButLogin.Text = "Login";
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClose.Location = new System.Drawing.Point(9, 6);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(20, 21);
            this.lbClose.TabIndex = 11;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            this.lbClose.MouseEnter += new System.EventHandler(this.lbClose_MouseEnter);
            this.lbClose.MouseLeave += new System.EventHandler(this.lbClose_MouseLeave);
            // 
            // lbClear
            // 
            this.lbClear.AutoSize = true;
            this.lbClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.lbClear.Location = new System.Drawing.Point(145, 404);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(38, 17);
            this.lbClear.TabIndex = 12;
            this.lbClear.Text = "Clear";
            this.lbClear.MouseEnter += new System.EventHandler(this.lbClear_MouseEnter);
            this.lbClear.MouseLeave += new System.EventHandler(this.lbClear_MouseLeave);
            // 
            // cboxRole
            // 
            this.cboxRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.cboxRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.cboxRole.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cboxRole.BorderThickness = 0;
            this.cboxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.cboxRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxRole.FocusedState.Parent = this.cboxRole;
            this.cboxRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxRole.HoverState.Parent = this.cboxRole;
            this.cboxRole.ItemHeight = 30;
            this.cboxRole.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.cboxRole.ItemsAppearance.Parent = this.cboxRole;
            this.cboxRole.Location = new System.Drawing.Point(153, 127);
            this.cboxRole.Name = "cboxRole";
            this.cboxRole.ShadowDecoration.Parent = this.cboxRole;
            this.cboxRole.Size = new System.Drawing.Size(140, 36);
            this.cboxRole.TabIndex = 13;
            // 
            // pbIconPass
            // 
            this.pbIconPass.Image = global::WFGoodFood.Properties.Resources.icons8_key_24px;
            this.pbIconPass.Location = new System.Drawing.Point(51, 272);
            this.pbIconPass.Name = "pbIconPass";
            this.pbIconPass.Size = new System.Drawing.Size(25, 25);
            this.pbIconPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconPass.TabIndex = 6;
            this.pbIconPass.TabStop = false;
            // 
            // pbIconUser
            // 
            this.pbIconUser.Image = global::WFGoodFood.Properties.Resources.icons8_user_24px;
            this.pbIconUser.Location = new System.Drawing.Point(52, 177);
            this.pbIconUser.Name = "pbIconUser";
            this.pbIconUser.Size = new System.Drawing.Size(25, 25);
            this.pbIconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconUser.TabIndex = 3;
            this.pbIconUser.TabStop = false;
            // 
            // pBImg
            // 
            this.pBImg.Image = global::WFGoodFood.Properties.Resources.bl011;
            this.pBImg.Location = new System.Drawing.Point(323, 1);
            this.pBImg.Name = "pBImg";
            this.pBImg.Size = new System.Drawing.Size(308, 449);
            this.pBImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBImg.TabIndex = 0;
            this.pBImg.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.cboxRole);
            this.Controls.Add(this.lbClear);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.ButLogin);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.pbIconPass);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtboxUserName);
            this.Controls.Add(this.pbIconUser);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pBImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbIconPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBImg;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox pbIconUser;
        private Guna.UI2.WinForms.Guna2TextBox txtboxUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.PictureBox pbIconPass;
        private Guna.UI2.WinForms.Guna2TextBox txtboxPassword;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button ButLogin;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbClear;
        private Guna.UI2.WinForms.Guna2ComboBox cboxRole;
    }
}