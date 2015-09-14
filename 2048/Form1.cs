using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        private Qz[,] qz = new Qz[4,4];
        private int[,] old_qz = new int[4,4];
        private const int QZ_SPACING = 16;//间距
        private const int QZ_SIZE = 80;//大小
        private const int QZ_TOP = 80;
        private const int QZ_LEFT = 60;

        public Form1()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    qz[i, j] = new Qz();
                    qz[i, j].Left = QZ_LEFT + QZ_SPACING * (j + 1) + QZ_SIZE * j;
                    qz[i, j].Top = QZ_TOP + QZ_SPACING * (i + 1) + QZ_SIZE * i;
                    this.Controls.Add(qz[i, j]);
                }
            }

            InitializeComponent();
            
            //最高得分
            this.maxScores.Text = new RegistryHelper().GetRegistryData(Registry.CurrentUser, "SOFTWARE\\2048", "MaxScores");

            //显示
            pic_bj.Left = QZ_LEFT;
            pic_bj.Top = QZ_TOP;
            pic_bj.Width = QZ_SPACING * 5 + QZ_SIZE * 4;
            pic_bj.Height = QZ_SPACING * 5 + QZ_SIZE * 4;
            this.start();
        }

        private void start()
        {
            RegistryHelper rh = new RegistryHelper();
            //是否修改最高得分
            if (int.Parse(this.scores.Text) > int.Parse(this.maxScores.Text))
            {
                rh.SetRegistryData(Registry.CurrentUser, "SOFTWARE\\2048", "MaxScores", this.scores.Text);
                this.maxScores.Text = this.scores.Text;
            }

            //重置界面
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    qz[i, j].Value = 0;
                }
            }
            this.restore.Enabled = false;
            this.scores.Text = "0";
            CL.zj(qz);
            CL.zj(qz);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.start();
        }

        private void restore_Click(object sender, EventArgs e)
        {
            //恢复操作
            this.restore.Enabled = false;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    qz[i, j].Value = old_qz[i, j];

                }
            }
            this.scores.Text = (int.Parse(this.scores.Text) - CL.Score).ToString();//恢复得分
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                //备份，用于恢复上一步
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        old_qz[i, j] = qz[i, j].Value;

                    }
                }

                //开始合并
                bool b = false;
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        b = CL.up(qz);
                        break;
                    case Keys.Down:
                        b = CL.down(qz);
                        break;
                    case Keys.Left:
                        b = CL.left(qz);
                        break;
                    case Keys.Right:
                        b = CL.right(qz);
                        break;
                }

                if (b)
                {
                    this.scores.Text = (int.Parse(this.scores.Text) + CL.Score).ToString();//计算总得分
                    this.restore.Enabled = true;

                    CL.zj(qz);//增加一粒棋子
                    if (CL.isover(qz))//判断是否结束
                    {
                        MessageBox.Show("游戏结束，你的得分是" + this.scores.Text + "。", "提示");
                        this.reset_Click(sender, e);
                    }
                }
            }
        }

        private void maxScores_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除最高得分吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //删除最高得分记录
                new RegistryHelper().SetRegistryData(Registry.CurrentUser, "SOFTWARE\\2048", "MaxScores", "0");
                this.maxScores.Text = "0";    
            }          
        }
    }
}
