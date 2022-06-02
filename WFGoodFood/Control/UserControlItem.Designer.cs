namespace WFGoodFood.Control
{
    partial class UserControlItem
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
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.lbPriceItem = new System.Windows.Forms.Label();
            this.btnItem = new System.Windows.Forms.Button();
            this.lbDesItem = new System.Windows.Forms.Label();
            this.lbNameItem = new System.Windows.Forms.Label();
            this.pBoxItem = new System.Windows.Forms.PictureBox();
            this.pnlCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.pnlCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategory.Controls.Add(this.lbPriceItem);
            this.pnlCategory.Controls.Add(this.btnItem);
            this.pnlCategory.Controls.Add(this.lbDesItem);
            this.pnlCategory.Controls.Add(this.lbNameItem);
            this.pnlCategory.Controls.Add(this.pBoxItem);
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(205, 130);
            this.pnlCategory.TabIndex = 2;
            // 
            // lbPriceItem
            // 
            this.lbPriceItem.AutoSize = true;
            this.lbPriceItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPriceItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.lbPriceItem.Location = new System.Drawing.Point(104, 35);
            this.lbPriceItem.Name = "lbPriceItem";
            this.lbPriceItem.Size = new System.Drawing.Size(0, 16);
            this.lbPriceItem.TabIndex = 5;
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.btnItem.FlatAppearance.BorderSize = 0;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.btnItem.Location = new System.Drawing.Point(104, 62);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(80, 20);
            this.btnItem.TabIndex = 4;
            this.btnItem.Text = "Order Now";
            this.btnItem.UseVisualStyleBackColor = false;
            // 
            // lbDesItem
            // 
            this.lbDesItem.AutoSize = true;
            this.lbDesItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDesItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lbDesItem.Location = new System.Drawing.Point(6, 91);
            this.lbDesItem.Name = "lbDesItem";
            this.lbDesItem.Size = new System.Drawing.Size(125, 30);
            this.lbDesItem.TabIndex = 2;
            this.lbDesItem.Text = "Alfalfa sprouts crown \r\nthese juicy burgers.\r\n";
            // 
            // lbNameItem
            // 
            this.lbNameItem.AutoSize = true;
            this.lbNameItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameItem.Location = new System.Drawing.Point(104, 12);
            this.lbNameItem.Name = "lbNameItem";
            this.lbNameItem.Size = new System.Drawing.Size(0, 16);
            this.lbNameItem.TabIndex = 1;
            // 
            // pBoxItem
            // 
            this.pBoxItem.Location = new System.Drawing.Point(6, 6);
            this.pBoxItem.Name = "pBoxItem";
            this.pBoxItem.Size = new System.Drawing.Size(80, 80);
            this.pBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxItem.TabIndex = 0;
            this.pBoxItem.TabStop = false;
            // 
            // UserControlItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCategory);
            this.Name = "UserControlItem";
            this.Size = new System.Drawing.Size(205, 130);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Label lbPriceItem;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Label lbDesItem;
        private System.Windows.Forms.Label lbNameItem;
        private System.Windows.Forms.PictureBox pBoxItem;
    }
}
