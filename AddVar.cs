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
    public partial class AddVar : Form
    {
        DMS dms;
        public AddVar(DMS dms)
        {
            InitializeComponent();
            this.dms = dms;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int countSame = 0;
            for (int i = 0; i < dms.variantsData.Count; ++i) if (dms.variantsData[i][1] == txtPath.Text || dms.variantsData[i][1] == txtPath.Text + countSame.ToString()) countSame++;
            dms.variantsData.Add(new List<string>() { dms.countVarId.ToString(), txtPath.Text + ((countSame == 0) ? ("") : (countSame.ToString())) });
            ++dms.countVarId;
            this.Close();
        }
    }
}
