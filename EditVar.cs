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
    public partial class EditVar : Form
    {
        DMS dms;
        public EditVar(DMS dMS)
        {
            dms = dMS;
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool fl = false;
            int ind = -1;
            for(int i = 0; i < dms.variantsData.Count; ++i) if (dms.variantsData[i][0] == txtId.Text) {fl = true; ind = i;}
            if (!fl)
            {
                MessageBox.Show("Нет данных по заданному id.");
                txtId.Text = string.Empty;
                return;
            }
            int countSame = 0;
            for (int i = 0;i < dms.variantsData.Count;++i) if (dms.variantsData[i][1] ==  txtVariant.Text || dms.variantsData[i][1] == txtVariant.Text + countSame.ToString())  countSame++;
            dms.variantsData[ind][1] = txtVariant.Text + ((countSame == 0) ? ("") : (countSame.ToString()));
            this.Close();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
