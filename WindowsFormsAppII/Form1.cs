using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCALCULAR_Click(object sender, EventArgs e)
        {
            int r = int.Parse(txtRENDA.Text);

            int el = int.Parse(txtELETRICA.Text);
            int ag = int.Parse(txtAGUA.Text);
            int tv = int.Parse(txtTV.Text);
            int al = int.Parse(txtALIMENTO.Text);
            int ou = int.Parse(txtOUTROS.Text);

            int g = el + ag + tv + al + ou;
            int s = r - g;

            lblGASTOS.Text = g.ToString("C");
            lblSALDO.Text = s.ToString("C");

            if (g > r)
            {
                lblSALDO.ForeColor = Color.Firebrick;
            }
        }

        private void btnNOVO_Click(object sender, EventArgs e)
        {
            txtRENDA.Clear();
            txtAGUA.Clear();
            txtELETRICA.Clear();
            txtTV.Clear();
            txtALIMENTO.Clear();
            txtOUTROS.Clear();

            lblGASTOS.Text = "0,00";
            lblSALDO.Text = "0,00";
            lblGASTOS.ForeColor = Color.Black;
            lblSALDO.ForeColor = Color.Black;
        }

        private void btnFECHAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
