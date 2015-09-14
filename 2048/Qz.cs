using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Qz : UserControl
    {
        private int value = 0;
        private int n = 0;
        private int m = 0;

        public int Value
        {
            get { return this.value; }
            set { this.value = value; this.Refresh(); }
        }
        public Qz()
        {
            InitializeComponent();
        }

        private void Qz_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            switch (value)
            {
                case 0:
                    g.Clear(Color.FromArgb(204, 192, 178));
                    break;
                case 2:
                    g.Clear(Color.FromArgb(238, 228, 218));
                    g.DrawString("2", new Font("微软雅黑", 42, FontStyle.Bold), new SolidBrush(Color.FromArgb(121, 111, 101)), new PointF(14, 2));
                    break;
                case 4:
                    g.Clear(Color.FromArgb(236, 224, 200));
                    g.DrawString("4", new Font("微软雅黑", 42, FontStyle.Bold), new SolidBrush(Color.FromArgb(121, 111, 101)), new PointF(14, 2));
                    break;
                case 8:
                    g.Clear(Color.FromArgb(242, 177, 121));
                    g.DrawString("8", new Font("微软雅黑", 42, FontStyle.Bold), new SolidBrush(Color.White), new PointF(14, 2));
                    break;
                case 16:
                    g.Clear(Color.FromArgb(245, 149, 99));
                    g.DrawString("16", new Font("微软雅黑", 32, FontStyle.Bold), new SolidBrush(Color.White), new PointF(6, 12));
                    break;
                case 32:
                    g.Clear(Color.FromArgb(243, 124, 94));
                    g.DrawString("32", new Font("微软雅黑", 32, FontStyle.Bold), new SolidBrush(Color.White), new PointF(6, 12));
                    break;
                case 64:
                    g.Clear(Color.FromArgb(246, 93, 59));
                    g.DrawString("64", new Font("微软雅黑", 32, FontStyle.Bold), new SolidBrush(Color.White), new PointF(6, 12));
                    break;
                case 128:
                case 256:
                case 512:
                    g.Clear(Color.FromArgb(237, 204, 97));
                    g.DrawString(value.ToString(), new Font("微软雅黑", 26, FontStyle.Bold), new SolidBrush(Color.White), new PointF(1, 16));
                    break;
                case 1024:
                case 2048:
                    g.Clear(Color.FromArgb(237, 204, 97));
                    g.DrawString(value.ToString(), new Font("微软雅黑", 22, FontStyle.Bold), new SolidBrush(Color.White), new PointF(0, 20));
                    break;
                case 4096:
                    g.Clear(Color.FromArgb(237, 204, 97));
                    g.DrawString(value.ToString(), new Font("微软雅黑", 22, FontStyle.Bold), new SolidBrush(Color.FromArgb(121, 111, 101)), new PointF(0, 20));
                    break;
            }
            g.Dispose();
        }

        private void hb_Tick(object sender, EventArgs e)
        {
            switch (this.n)
            {
                case 0:
                    this.Left -= 1;
                    this.Top -= 1;
                    this.Width += 2;
                    this.Height += 2;
                    this.n++;
                    break;
                case 1:
                    this.Left -= 1;
                    this.Top -= 1;
                    this.Width += 2;
                    this.Height += 2;
                    this.n++;
                    break;
                case 2:
                    this.Left += 1;
                    this.Top += 1;
                    this.Width -= 2;
                    this.Height -= 2;
                    this.n++;
                    break;
                case 3:
                    this.Left += 1;
                    this.Top += 1;
                    this.Width -= 2;
                    this.Height -= 2;
                    this.n = 0;
                    this.hb.Enabled = false;
                    break;
            }
        }

        public void zj_Tick(object sender, EventArgs e)
        {
            switch (this.m)
            {
                case 0:
                    this.Left += 30;
                    this.Top += 30;
                    this.Width -= 60;
                    this.Height -= 60;
                    this.m++;
                    break;
                case 1:
                    this.Left -= 5;
                    this.Top -= 5;
                    this.Width += 10;
                    this.Height += 10;
                    this.m++;
                    break;
                case 2:
                    this.Left -= 5;
                    this.Top -= 5;
                    this.Width += 10;
                    this.Height += 10;
                    this.m++;
                    break;
                case 3:
                    this.Left -= 5;
                    this.Top -= 5;
                    this.Width += 10;
                    this.Height += 10;
                    this.m++;
                    break;
                case 4:
                    this.Left -= 5;
                    this.Top -= 5;
                    this.Width += 10;
                    this.Height += 10;
                    this.m++;
                    break;
                case 5:
                    this.Left -= 5;
                    this.Top -= 5;
                    this.Width += 10;
                    this.Height += 10;
                    this.m++;
                    break;
                case 6:
                    this.Left -= 5;
                    this.Top -= 5;
                    this.Width += 10;
                    this.Height += 10;
                    this.m = 0;
                    this.zj.Enabled = false;
                    break;
            }
        }

    }
}
