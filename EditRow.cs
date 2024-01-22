using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBaseLab1_2
{
    public partial class EditRow : Form
    {
        DMS dms;
        public EditRow(DMS dMS)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool fl = false;
            int ind = -1;
            for (int i = 0; i < dms.studentsData.Count; ++i) if (dms.studentsData[i][0] == txtId.Text) {fl = true; ind = i; break;}
            if (!fl)
            {
                MessageBox.Show("Нет данных по заданному id.");
                txtId.Text = string.Empty;
                return;
            }
            int countSames = 0;
            string var = (txtVar.Text == string.Empty) ? (dms.studentsData[ind][0]) : (txtVar.Text);
            string name = (txtName.Text == string.Empty) ? (dms.studentsData[ind][1]) : (txtName.Text);
            string surname = (txtSurname.Text == string.Empty) ? (dms.studentsData[ind][2]) : (txtSurname.Text);
            string patronymic = (txtPatronymic.Text == string.Empty) ? (dms.studentsData[ind][3]) : (txtPatronymic.Text);
            for (int i = 0; i < dms.studentsData.Count; ++i)
                if (dms.studentsData[i][1] == name && (dms.studentsData[i][2] == surname || dms.studentsData[i][2] == surname + countSames.ToString()) && dms.studentsData[i][3] == patronymic)
                    ++countSames;
            dms.testingData[ind][1] = var;
            dms.studentsData[ind][1] = name;
            dms.studentsData[ind][2] = (countSames == 0) ? (surname): (surname + countSames.ToString());
            dms.studentsData[ind][3] = patronymic;
            this.Close();
        }
    }
}
