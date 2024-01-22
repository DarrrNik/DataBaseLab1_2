namespace DataBaseLab1_2
{
    partial class DeleteVar
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblRowNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(349, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(33, 9);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(328, 22);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // lblRowNum
            // 
            this.lblRowNum.AutoSize = true;
            this.lblRowNum.Location = new System.Drawing.Point(9, 9);
            this.lblRowNum.Name = "lblRowNum";
            this.lblRowNum.Size = new System.Drawing.Size(18, 16);
            this.lblRowNum.TabIndex = 3;
            this.lblRowNum.Text = "id";
            // 
            // DeleteVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 88);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblRowNum);
            this.Name = "DeleteVar";
            this.Text = "DeleteVar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblRowNum;
    }
}