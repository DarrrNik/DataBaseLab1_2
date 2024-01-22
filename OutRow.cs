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
    public partial class OutRow : Form
    {
        DMS dms = new DMS();
        public OutRow(DMS dMS)
        {
            dms = dMS;
            InitializeComponent();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            bool fl = false;
            foreach (var i in dms.studentsData) if (txtId.Text == i[0]) fl = true;
            if (!fl)
            {
                MessageBox.Show("Нет данных по заданному id.");
                txtId.Text = string.Empty;
                return;
            }
            int id = int.Parse(txtId.Text);
            lblWriteName.Text = dms.studentsData[id][1];
            lblWriteSurname.Text = dms.studentsData[id][2];
            lblWritePatronymic.Text = dms.studentsData[id][3];
        }
    }
}
