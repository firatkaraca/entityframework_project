using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0_EntityProjeUygulama
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void fRM__Load(object sender, EventArgs e)
        {
            GraphicsPath gpath = new GraphicsPath();
            Point[] pnt = new Point[8];
            pnt[0] = new Point(50, 0);
            pnt[1] = new Point(0, 60);
            pnt[2] = new Point(20, 200);
            pnt[3] = new Point(0, 300);
            pnt[4] = new Point(40, 800);
            pnt[5] = new Point(600, 800);
            pnt[6] = new Point(600, 250);
            pnt[7] = new Point(1300, 0);


            gpath.AddPolygon(pnt);
            Region bolge = new Region(gpath);
            this.Region = bolge;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntityUrunEntities db = new DbEntityUrunEntities();

            var sorgu = from x in db.TBLADMIN where x.KULLANICI == textBox1.Text && x.SIFRE == textBox2.Text select x;
            if (sorgu.Any())    
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı & Şifre","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
