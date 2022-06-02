namespace WFGoodFood.Control
{
    partial class UserControlDelivery
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnOrdersDeliv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::WFGoodFood.Properties.Resources.banner_pic;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(882, 530);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnOrdersDeliv
            // 
            this.btnOrdersDeliv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.btnOrdersDeliv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdersDeliv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrdersDeliv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.btnOrdersDeliv.Location = new System.Drawing.Point(766, 473);
            this.btnOrdersDeliv.Name = "btnOrdersDeliv";
            this.btnOrdersDeliv.Size = new System.Drawing.Size(85, 36);
            this.btnOrdersDeliv.TabIndex = 1;
            this.btnOrdersDeliv.Text = "Orders";
            this.btnOrdersDeliv.UseVisualStyleBackColor = false;
            this.btnOrdersDeliv.Click += new System.EventHandler(this.btnOrdersDeliv_Click);
            // 
            // UserControlDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnOrdersDeliv);
            this.Controls.Add(this.pictureBox);
            this.Name = "UserControlDelivery";
            this.Size = new System.Drawing.Size(882, 530);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnOrdersDeliv;
    }
}
