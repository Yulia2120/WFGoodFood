namespace WFGoodFood.GUI
{
    partial class FormLoading
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
            this.panLoad = new System.Windows.Forms.Panel();
            this.panMove = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLoad
            // 
            this.panLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.panLoad.Controls.Add(this.panMove);
            this.panLoad.Location = new System.Drawing.Point(182, 332);
            this.panLoad.Name = "panLoad";
            this.panLoad.Size = new System.Drawing.Size(257, 5);
            this.panLoad.TabIndex = 1;
            // 
            // panMove
            // 
            this.panMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panMove.Location = new System.Drawing.Point(186, 0);
            this.panMove.Name = "panMove";
            this.panMove.Size = new System.Drawing.Size(70, 5);
            this.panMove.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(245, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Wait...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sarllina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(208, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 75);
            this.label2.TabIndex = 3;
            this.label2.Text = "GoodFood";
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoading";
            this.Load += new System.EventHandler(this.FormLoading_Load);
            this.panLoad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panLoad;
        private System.Windows.Forms.Panel panMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}