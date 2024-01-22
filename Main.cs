using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace DataBaseLab1_2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            CreateDB createDB = new CreateDB();
            createDB.ShowDialog();
            CreateSavesDir(createDB.newDBName.Text);
        }

        private void CreateSavesDir(string baseName)
        {
            DirectoryInfo dir = new DirectoryInfo("..\\..\\Bases\\"+ baseName);
            dir.CreateSubdirectory("Saves");
            dir = new DirectoryInfo(dir.FullName + "\\Saves");
            dir.CreateSubdirectory("Save");
            using (File.Create(dir.FullName + "\\LastSave.txt")) { };
            File.WriteAllText(dir.FullName + "\\LastSave.txt", dir.FullName + "\\Save");
        }

        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Bases\");
            OpenDB openDB = new OpenDB(this);
            openDB.ShowDialog();
            if (openDB.textDBName.Text == string.Empty) { return; }
            DMS dms = new DMS();
            dms.ShowDialog();
            //this.Hide();
        }
    }
}
