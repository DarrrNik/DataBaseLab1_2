namespace DataBaseLab1_2
{
    partial class OutRow
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
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWriteName = new System.Windows.Forms.Label();
            this.lblWriteSurname = new System.Windows.Forms.Label();
            this.lblWritePatronymic = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Location = new System.Drawing.Point(92, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(320, 22);
            this.txtId.TabIndex = 11;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "Id";
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(12, 90);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(74, 16);
            this.lblPatronymic.TabIndex = 14;
            this.lblPatronymic.Text = "Patronymic";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 64);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 16);
            this.lblSurname.TabIndex = 13;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblWriteName
            // 
            this.lblWriteName.AutoSize = true;
            this.lblWriteName.Location = new System.Drawing.Point(92, 38);
            this.lblWriteName.Name = "lblWriteName";
            this.lblWriteName.Size = new System.Drawing.Size(0, 16);
            this.lblWriteName.TabIndex = 15;
            // 
            // lblWriteSurname
            // 
            this.lblWriteSurname.AutoSize = true;
            this.lblWriteSurname.Location = new System.Drawing.Point(92, 64);
            this.lblWriteSurname.Name = "lblWriteSurname";
            this.lblWriteSurname.Size = new System.Drawing.Size(0, 16);
            this.lblWriteSurname.TabIndex = 16;
            // 
            // lblWritePatronymic
            // 
            this.lblWritePatronymic.AutoSize = true;
            this.lblWritePatronymic.Location = new System.Drawing.Point(92, 90);
            this.lblWritePatronymic.Name = "lblWritePatronymic";
            this.lblWritePatronymic.Size = new System.Drawing.Size(0, 16);
            this.lblWritePatronymic.TabIndex = 17;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(12, 109);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(396, 64);
            this.btnOut.TabIndex = 18;
            this.btnOut.Text = "Вывести";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // OutRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 181);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.lblWritePatronymic);
            this.Controls.Add(this.lblWriteSurname);
            this.Controls.Add(this.lblWriteName);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "OutRow";
            this.Text = "OutRow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWriteName;
        private System.Windows.Forms.Label lblWriteSurname;
        private System.Windows.Forms.Label lblWritePatronymic;
        private System.Windows.Forms.Button btnOut;
    }
}