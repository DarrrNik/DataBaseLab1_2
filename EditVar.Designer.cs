namespace DataBaseLab1_2
{
    partial class EditVar
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtVariant = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(59, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(361, 22);
            this.txtId.TabIndex = 13;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(17, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id";
            // 
            // txtVariant
            // 
            this.txtVariant.Location = new System.Drawing.Point(59, 40);
            this.txtVariant.Name = "txtVariant";
            this.txtVariant.Size = new System.Drawing.Size(361, 22);
            this.txtVariant.TabIndex = 11;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(17, 43);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(34, 16);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "Path";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(20, 68);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEdit.Size = new System.Drawing.Size(400, 64);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // EditVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 141);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtVariant);
            this.Controls.Add(this.lblPath);
            this.Name = "EditVar";
            this.Text = "EditVar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtVariant;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnEdit;
    }
}