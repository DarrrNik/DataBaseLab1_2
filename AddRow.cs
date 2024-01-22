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
    public partial class AddRow : Form
    {
        private DMS dms;
        public AddRow(DMS dMS)
        {
            dms = dMS;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text, surname = txtSurname.Text, patronymic = txtPatronymic.Text;
            int countSames = 0;
            for (int i = 0; i < dms.studentsData.Count; ++i)
                if (dms.studentsData[i][1] == name && (dms.studentsData[i][2] == surname || dms.studentsData[i][2] == surname + countSames.ToString()) && dms.studentsData[i][3] == patronymic)
                    ++countSames;
            dms.studentsData.Add(new List<string>() { dms.countStId.ToString(), name, surname + ((countSames == 0) ? ("") : (countSames.ToString())), patronymic });
            ++dms.countStId;
            this.Close();
        }
    }
}
