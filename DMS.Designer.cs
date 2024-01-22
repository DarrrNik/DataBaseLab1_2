namespace DataBaseLab1_2
{
    partial class DMS
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
            this.openTable = new System.Windows.Forms.OpenFileDialog();
            this.btnGenerateTables = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.btnChoice = new System.Windows.Forms.Button();
            this.btnEditVar = new System.Windows.Forms.Button();
            this.btnDeleteVar = new System.Windows.Forms.Button();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutVar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openTable
            // 
            this.openTable.Filter = "*.txt|";
            // 
            // btnGenerateTables
            // 
            this.btnGenerateTables.Location = new System.Drawing.Point(459, 12);
            this.btnGenerateTables.Name = "btnGenerateTables";
            this.btnGenerateTables.Size = new System.Drawing.Size(124, 70);
            this.btnGenerateTables.TabIndex = 1;
            this.btnGenerateTables.Text = "Сгенерировать таблицы";
            this.btnGenerateTables.UseVisualStyleBackColor = true;
            this.btnGenerateTables.Click += new System.EventHandler(this.btnGenerateTables_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(141, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(11, 371);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(11, 409);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(124, 32);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Вывести";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewSave
            // 
            this.btnNewSave.Location = new System.Drawing.Point(117, 12);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(116, 70);
            this.btnNewSave.TabIndex = 7;
            this.btnNewSave.Text = "Новое \r\nсохранение";
            this.btnNewSave.UseVisualStyleBackColor = true;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.Location = new System.Drawing.Point(12, 50);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(99, 32);
            this.btnChoice.TabIndex = 8;
            this.btnChoice.Text = "Выбрать";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // btnEditVar
            // 
            this.btnEditVar.Location = new System.Drawing.Point(329, 371);
            this.btnEditVar.Name = "btnEditVar";
            this.btnEditVar.Size = new System.Drawing.Size(124, 32);
            this.btnEditVar.TabIndex = 11;
            this.btnEditVar.Text = "Изменить";
            this.btnEditVar.UseVisualStyleBackColor = true;
            this.btnEditVar.Click += new System.EventHandler(this.btnEditVar_Click);
            // 
            // btnDeleteVar
            // 
            this.btnDeleteVar.Location = new System.Drawing.Point(459, 372);
            this.btnDeleteVar.Name = "btnDeleteVar";
            this.btnDeleteVar.Size = new System.Drawing.Size(124, 32);
            this.btnDeleteVar.TabIndex = 10;
            this.btnDeleteVar.Text = "Удалить";
            this.btnDeleteVar.UseVisualStyleBackColor = true;
            this.btnDeleteVar.Click += new System.EventHandler(this.btnDeleteVar_Click);
            // 
            // btnAddVar
            // 
            this.btnAddVar.Location = new System.Drawing.Point(459, 410);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(124, 32);
            this.btnAddVar.TabIndex = 9;
            this.btnAddVar.Text = "Добавить";
            this.btnAddVar.UseVisualStyleBackColor = true;
            this.btnAddVar.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Студенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Варианты";
            // 
            // btnOutVar
            // 
            this.btnOutVar.Location = new System.Drawing.Point(329, 410);
            this.btnOutVar.Name = "btnOutVar";
            this.btnOutVar.Size = new System.Drawing.Size(124, 32);
            this.btnOutVar.TabIndex = 15;
            this.btnOutVar.Text = "Вывести";
            this.btnOutVar.UseVisualStyleBackColor = true;
            this.btnOutVar.Click += new System.EventHandler(this.btnOutVar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 247);
            this.dataGridView1.TabIndex = 16;
            // 
            // DMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOutVar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditVar);
            this.Controls.Add(this.btnDeleteVar);
            this.Controls.Add(this.btnAddVar);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.btnNewSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGenerateTables);
            this.Name = "DMS";
            this.Text = "DMS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openTable;
        private System.Windows.Forms.Button btnGenerateTables;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewSave;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.Button btnEditVar;
        private System.Windows.Forms.Button btnDeleteVar;
        private System.Windows.Forms.Button btnAddVar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutVar;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}