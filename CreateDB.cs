using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataBaseLab1_2
{
    public partial class CreateDB : Form
    {
        public CreateDB()
        {
            InitializeComponent();
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"..\..\Bases");
            directoryInfo.CreateSubdirectory(newDBName.Text);
            this.Close();
        }
    }
}
