using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AMACC_CEBU_LIBRARY_SYSTEM
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void lnkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            authenticateform passfrm = new authenticateform();
            passfrm.Show();
        }


         //button to mem-panel form
        private void btnMempanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Members_Panel frm1 = new Members_Panel();
            frm1.Show();
        }

        //button to booktrans form
        private void btnBooktrans_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booktransaction frm2 = new Booktransaction();
            frm2.Show();
        }

        

        

       
    }
}
