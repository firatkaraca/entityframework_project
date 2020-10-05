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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Width = 33;
            pictureBox1.Height = 33;
            pictureBox1.Location = new Point(678, 0);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Width = 26;
            pictureBox1.Height = 26;
            pictureBox1.Location = new Point(685, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Size = new Size(216, 186);
            button1.Location = new Point(25, 32);
            button1.Font = new Font("Segoe Script", 17, FontStyle.Bold);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(178, 157);
            button1.Location = new Point(35, 47);
            button1.Font = new Font("Segoe Script", 13);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Size = new Size(216, 186);
            button2.Location = new Point(235,32);
            button2.Font = new Font("Segoe Script", 17, FontStyle.Bold);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(178,157);
            button2.Location = new Point(250,47);
            button2.Font = new Font("Segoe Script", 13);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Size = new Size(216, 186);
            button3.Location = new Point(459,32);
            button3.Font = new Font("Segoe Script", 17, FontStyle.Bold);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new Size(178, 157);
            button3.Location = new Point(469,47);
            button3.Font = new Font("Segoe Script", 13);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKategori fr = new FrmKategori();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrun fr = new FrmUrun();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            //GraphicsPath sekil = new GraphicsPath();
            //sekil.AddEllipse(0, 0, this.Width, this.Height);
            //Region sekilbolge = new Region(sekil);
            //this.Region = sekilbolge;

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

        private void button3_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik();
            fr.Show();
        }
    }
}
