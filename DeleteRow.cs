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
    public partial class DeleteRow : Form
    {
        DMS dms;
        public DeleteRow(DMS dMS)
        {
            dms = dMS;
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int ind = -1;
            for (int i = 0; i < dms.studentsData.Count; i++) if (dms.studentsData[i][0] == txtNumber.Text) ind = i;
            if (ind == -1)
            {
                MessageBox.Show("Нет данных по заданному id."); 
                txtNumber.Text = string.Empty; 
                return;
            }
            dms.studentsData.Remove(dms.studentsData[ind]);
            dms.testingData.Remove(dms.testingData[ind]);
            this.Close();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
