using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GYM_DevExpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FrmEkipman fr;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new FrmEkipman();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        frmPersonel fr4;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr4 == null)
            {
                fr4 = new frmPersonel();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }

        private void BtnYeniUye_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYeniUye frm = new frmYeniUye();
            frm.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}