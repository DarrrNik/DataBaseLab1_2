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
    public partial class ChoiceSaveId : Form
    {
        DMS dms;
        public ChoiceSaveId(DMS dMS)
        {
            dms = dMS;
            InitializeComponent();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(OpenDB.DBname + "\\Saves");
            if (dir.GetDirectories().Count() <= int.Parse(txtNumber.Text)) { MessageBox.Show("Нет сохранения с таким номером."); return; }
            dms.pathSaves = OpenDB.DBname + "\\Saves\\Save" + ((int.Parse(txtNumber.Text) == 0) ? ("") : (txtNumber.Text));
            dms.studentsData = null;
            dms.testingData = null;
            dms.countStId = 0;
            this.Close();
        }
    }
}
