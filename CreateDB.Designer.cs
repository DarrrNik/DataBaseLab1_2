namespace DataBaseLab1_2
{
    partial class CreateDB
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
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.newDBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(28, 56);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(263, 52);
            this.btnCreateDB.TabIndex = 0;
            this.btnCreateDB.Text = "Создать новую базу данных";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // newDBName
            // 
            this.newDBName.Location = new System.Drawing.Point(12, 28);
            this.newDBName.Name = "newDBName";
            this.newDBName.Size = new System.Drawing.Size(294, 22);
            this.newDBName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя новой базы данных:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newDBName);
            this.Controls.Add(this.btnCreateDB);
            this.Name = "CreateDB";
            this.Text = "Новая база данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox newDBName;
    }
}