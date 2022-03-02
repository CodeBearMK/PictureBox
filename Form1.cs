using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {

        int current;
        int rate;
        int wide, high, pX, pY;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            wide = pic.Width;
            high = pic.Height;
            pX = pic.Left;
            pY = pic.Top;
            current = 1;
            rate = 80;
            FigShow();
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            if (rate > 10)
            {
                rate -= 10;
                FigShow();
            }
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            if (rate < 100)
            {
                rate += 10;
                FigShow();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            current++;
            FigShow();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            current--;
            FigShow();
        }

        private void FigShow()
        {
            lblCurrent.Text = "第 " + current + " 張圖像";
            pic.Image = Image.FromFile(@"D:\img\" + current + ".jpg");
            if (current == 1) btnPre.Enabled = false;
            else btnPre.Enabled = true;
            if (current == 3) btnNext.Enabled = false;
            else btnNext.Enabled = true;

            lblRate.Text = "圖像顯示比例：" + rate + "%";
            int W = wide * rate / 100;
            int H = high * rate / 100;
            pic.Size = new Size(W, H);
            pic.Location = new Point(pX + (wide - W) / 2, (pY + (high - H) / 2));
        }
    }
}
