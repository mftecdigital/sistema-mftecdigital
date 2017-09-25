using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFTD
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if(prgbarLoading.Value < 100)
            {
                prgbarLoading.Value = prgbarLoading.Value + 2;
            }
            else
            {
                timerLoading.Enabled = false;
                frmLogin frl = new frmLogin();
                frl.Show();
                
                //frmMFTD formMF = new frmMFTD();
                //formMF.Show();
                this.Visible = false;
            }
        }
    }
}
