namespace DataBaseLab1_2
{
    partial class OpenDB
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
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.textDBName = new System.Windows.Forms.TextBox();
            this.DBName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(24, 56);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(263, 52);
            this.btnOpenDB.TabIndex = 3;
            this.btnOpenDB.Text = "Открыть базу данных";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // textDBName
            // 
            this.textDBName.Location = new System.Drawing.Point(12, 28);
            this.textDBName.Name = "textDBName";
            this.textDBName.Size = new System.Drawing.Size(294, 22);
            this.textDBName.TabIndex = 4;
            // 
            // DBName
            // 
            this.DBName.AutoSize = true;
            this.DBName.Location = new System.Drawing.Point(97, 9);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(122, 16);
            this.DBName.TabIndex = 5;
            this.DBName.Text = "Имя базы данных:";
            this.DBName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OpenDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 131);
            this.Controls.Add(this.DBName);
            this.Controls.Add(this.textDBName);
            this.Controls.Add(this.btnOpenDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OpenDB";
            this.Text = "OpenDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.Label DBName;
        public System.Windows.Forms.TextBox textDBName;
    }
}