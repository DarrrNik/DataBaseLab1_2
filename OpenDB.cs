using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLab1_2
{
    public partial class OpenDB : Form
    {
        private Main main;
        public static string DBname;

        public OpenDB(Main main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"..\..\Bases\" + textDBName.Text);
            DBname = dir.FullName;
            if (!dir.Exists || textDBName.Text == string.Empty) {
                MessageBox.Show("Базы данных с таким именем не существует.");
                return;
            }
            this.Close();
        }
    }
}
