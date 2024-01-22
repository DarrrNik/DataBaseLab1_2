using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLab1_2
{
    public partial class DeleteVar : Form
    {
        DMS dms;
        public DeleteVar(DMS dms)
        {
            InitializeComponent();
            this.dms = dms;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ind = -1;
            for (int i = 0; i < dms.variantsData.Count; i++) if (dms.variantsData[i][0] == txtNumber.Text) ind = i;
            if (ind == -1)
            {
                MessageBox.Show("Нет данных по заданному id.");
                txtNumber.Text = string.Empty;
                return;
            }
            dms.variantsData.Remove(dms.variantsData[ind]);
            for (int i = 0; dms.testingData != null && i < dms.testingData.Count; ++i) 
                if (dms.testingData[i][1] == txtNumber.Text)
                    dms.testingData[i][1] = dms.variantsData[dms.rand.Next(0, dms.variantsData.Count)][0];
            this.Close();
        }
    }
}
