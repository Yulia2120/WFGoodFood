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
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbClear = new System.Windows.Forms.Label();
            this.pBImg = new System.Windows.Forms.PictureBox();
            this.txtboxUserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Sarllina", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(83, 43);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(158, 58);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "GoodFood";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.Location = new System.Drawing.Point(60, 150);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(65, 16);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "User Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.Location = new System.Drawing.Point(60, 241);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(58, 16);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClose.Location = new System.Drawing.Point(9, 6);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(20, 19);
            this.lbClose.TabIndex = 11;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            this.lbClose.MouseEnter += new System.EventHandler(this.lbClose_MouseEnter);
            this.lbClose.MouseLeave += new System.EventHandler(this.lbClose_MouseLeave);
            // 
            // lbClear
            // 
            this.lbClear.AutoSize = true;
            this.lbClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.lbClear.Location = new System.Drawing.Point(134, 402);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(43, 17);
            this.lbClear.TabIndex = 12;
            this.lbClear.Text = "Clear";
            this.lbClear.Click += new System.EventHandler(this.lbClear_Click);
            this.lbClear.MouseEnter += new System.EventHandler(this.lbClear_MouseEnter);
            this.lbClear.MouseLeave += new System.EventHandler(this.lbClear_MouseLeave);
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
            // txtboxUserName
            // 
            this.txtboxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtboxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxUserName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(121)))), ((int)(((byte)(122)))));
            this.txtboxUserName.Location = new System.Drawing.Point(63, 187);
            this.txtboxUserName.Name = "txtboxUserName";
            this.txtboxUserName.Size = new System.Drawing.Size(210, 15);
            this.txtboxUserName.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(63, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 3);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(63, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 3);
            this.panel2.TabIndex = 16;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(121)))), ((int)(((byte)(122)))));
            this.txtboxPassword.Location = new System.Drawing.Point(63, 279);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(210, 15);
            this.txtboxPassword.TabIndex = 15;
            this.txtboxPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(113, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.comboBoxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(121)))), ((int)(((byte)(122)))));
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.comboBoxLogin.Location = new System.Drawing.Point(152, 150);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(121, 25);
            this.comboBoxLogin.TabIndex = 18;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.comboBoxLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxUserName);
            this.Controls.Add(this.lbClear);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pBImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pBImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBImg;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
   
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbClear;
        private System.Windows.Forms.TextBox txtboxUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxLogin;
    }
}