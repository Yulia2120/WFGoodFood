﻿namespace WFGoodFood
{
    partial class ProductForm
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
            this.lbClose = new System.Windows.Forms.Label();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lbDelivery = new System.Windows.Forms.Label();
            this.lbrestor = new System.Windows.Forms.Label();
            this.lbIcon = new System.Windows.Forms.Label();
            this.userControlHome = new WFGoodFood.Control.UserControlHome();
            this.userControlCategory = new WFGoodFood.Control.UserControlCategory();
            this.pnlSide.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClose.Location = new System.Drawing.Point(860, 5);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(20, 19);
            this.lbClose.TabIndex = 12;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            this.lbClose.MouseEnter += new System.EventHandler(this.lbClose_MouseEnter);
            this.lbClose.MouseLeave += new System.EventHandler(this.lbClose_MouseLeave);
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pnlSide.Controls.Add(this.pnlRed);
            this.pnlSide.Controls.Add(this.btnManagement);
            this.pnlSide.Controls.Add(this.btnDelivery);
            this.pnlSide.Controls.Add(this.btnCategory);
            this.pnlSide.Controls.Add(this.btnHome);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(200, 650);
            this.pnlSide.TabIndex = 13;
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.pnlRed.Location = new System.Drawing.Point(3, 98);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(5, 45);
            this.pnlRed.TabIndex = 16;
            // 
            // btnManagement
            // 
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.btnManagement.Location = new System.Drawing.Point(0, 251);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(200, 45);
            this.btnManagement.TabIndex = 3;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            // 
            // btnDelivery
            // 
            this.btnDelivery.FlatAppearance.BorderSize = 0;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.btnDelivery.Location = new System.Drawing.Point(3, 200);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(200, 45);
            this.btnDelivery.TabIndex = 2;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.btnCategory.Location = new System.Drawing.Point(0, 149);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(200, 45);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Сategory";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.btnHome.Location = new System.Drawing.Point(0, 98);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.pnlTop.Controls.Add(this.lbDelivery);
            this.pnlTop.Controls.Add(this.lbrestor);
            this.pnlTop.Controls.Add(this.lbIcon);
            this.pnlTop.Controls.Add(this.lbClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(884, 92);
            this.pnlTop.TabIndex = 14;
            // 
            // lbDelivery
            // 
            this.lbDelivery.AutoSize = true;
            this.lbDelivery.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.lbDelivery.Location = new System.Drawing.Point(27, 64);
            this.lbDelivery.Name = "lbDelivery";
            this.lbDelivery.Size = new System.Drawing.Size(57, 17);
            this.lbDelivery.TabIndex = 2;
            this.lbDelivery.Text = "Delivery";
            // 
            // lbrestor
            // 
            this.lbrestor.AutoSize = true;
            this.lbrestor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbrestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.lbrestor.Location = new System.Drawing.Point(27, 42);
            this.lbrestor.Name = "lbrestor";
            this.lbrestor.Size = new System.Drawing.Size(72, 17);
            this.lbrestor.TabIndex = 1;
            this.lbrestor.Text = "Restaurant";
            // 
            // lbIcon
            // 
            this.lbIcon.AutoSize = true;
            this.lbIcon.Font = new System.Drawing.Font("Sarllina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.lbIcon.Location = new System.Drawing.Point(15, 9);
            this.lbIcon.Name = "lbIcon";
            this.lbIcon.Size = new System.Drawing.Size(95, 33);
            this.lbIcon.TabIndex = 0;
            this.lbIcon.Text = "GoodFood";
            // 
            // userControlHome
            // 
            this.userControlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.userControlHome.Location = new System.Drawing.Point(202, 95);
            this.userControlHome.Name = "userControlHome";
            this.userControlHome.Size = new System.Drawing.Size(880, 530);
            this.userControlHome.TabIndex = 15;
            // 
            // userControlCategory
            // 
            this.userControlCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.userControlCategory.Location = new System.Drawing.Point(202, 95);
            this.userControlCategory.Name = "userControlCategory";
            this.userControlCategory.Size = new System.Drawing.Size(882, 530);
            this.userControlCategory.TabIndex = 16;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1084, 650);
            this.Controls.Add(this.userControlCategory);
            this.Controls.Add(this.userControlHome);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.pnlSide.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lbIcon;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbrestor;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Label lbDelivery;
        private Control.UserControlHome userControlHome;
        private Control.UserControlCategory userControlCategory;
    }
}