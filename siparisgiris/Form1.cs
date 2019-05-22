using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siparisgiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        TextBox txtboxSiparis = new TextBox();
        int siparisno;
        private void girişDüzeltmeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Label lbsip = new Label();
            lbsip.Text = "Sipariş No";
            Button btnGonder = new Button();
            btnGonder.Text = "Gönder";
            flowLayoutPanel1.Controls.Add(lbsip);
            flowLayoutPanel1.Controls.Add(txtboxSiparis);
            flowLayoutPanel1.Controls.Add(btnGonder);

            btnGonder.Click += new EventHandler(btngonder_click);
        }

        private void btngonder_click(object sender, EventArgs e)
        {
            SiparisKontrol();
            
        }

        private void SiparisKontrol()
        {
            siparisno = Convert.ToInt32(txtboxSiparis.Text);
            Orders order = db.Set<Orders>().Find(siparisno);
            if (order == null)
            {
                MessageBox.Show("Böyle bir sipariş bulunamadı.");
            }
            else
            {
                frmorder frm = new frmorder(siparisno);
                frm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void yeniGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmyenisiparis frm = new frmyenisiparis();
            frm.Show();
        }
    }
}
