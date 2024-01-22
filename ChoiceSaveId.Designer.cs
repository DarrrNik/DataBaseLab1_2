namespace DataBaseLab1_2
{
    partial class ChoiceSaveId
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblSaveNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 40);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(359, 40);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Загрузить";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(146, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(225, 22);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // lblSaveNum
            // 
            this.lblSaveNum.AutoSize = true;
            this.lblSaveNum.Location = new System.Drawing.Point(9, 15);
            this.lblSaveNum.Name = "lblSaveNum";
            this.lblSaveNum.Size = new System.Drawing.Size(129, 16);
            this.lblSaveNum.TabIndex = 3;
            this.lblSaveNum.Text = "Номер сохранения";
            // 
            // ChoiceSaveId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 92);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblSaveNum);
            this.Name = "ChoiceSaveId";
            this.Text = "ChoiceSaveId";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblSaveNum;
    }
}