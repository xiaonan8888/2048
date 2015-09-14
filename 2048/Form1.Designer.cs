namespace _2048
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reset = new System.Windows.Forms.Button();
            this.pic_bj = new System.Windows.Forms.PictureBox();
            this.scores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxScores = new System.Windows.Forms.Label();
            this.restore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bj)).BeginInit();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.reset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reset.Location = new System.Drawing.Point(67, 33);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(100, 33);
            this.reset.TabIndex = 0;
            this.reset.Text = "重新开始";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // pic_bj
            // 
            this.pic_bj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.pic_bj.Location = new System.Drawing.Point(67, 78);
            this.pic_bj.Name = "pic_bj";
            this.pic_bj.Size = new System.Drawing.Size(100, 50);
            this.pic_bj.TabIndex = 1;
            this.pic_bj.TabStop = false;
            // 
            // scores
            // 
            this.scores.AutoSize = true;
            this.scores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.scores.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scores.ForeColor = System.Drawing.Color.White;
            this.scores.Location = new System.Drawing.Point(382, 21);
            this.scores.MinimumSize = new System.Drawing.Size(60, 45);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(60, 45);
            this.scores.TabIndex = 2;
            this.scores.Text = "0";
            this.scores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "得分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(291, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "最高得分";
            // 
            // maxScores
            // 
            this.maxScores.AutoSize = true;
            this.maxScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.maxScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxScores.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxScores.ForeColor = System.Drawing.Color.White;
            this.maxScores.Location = new System.Drawing.Point(282, 21);
            this.maxScores.MinimumSize = new System.Drawing.Size(90, 45);
            this.maxScores.Name = "maxScores";
            this.maxScores.Size = new System.Drawing.Size(90, 45);
            this.maxScores.TabIndex = 4;
            this.maxScores.Text = "0";
            this.maxScores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.maxScores.DoubleClick += new System.EventHandler(this.maxScores_DoubleClick);
            // 
            // restore
            // 
            this.restore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.restore.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restore.Location = new System.Drawing.Point(185, 33);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(67, 33);
            this.restore.TabIndex = 6;
            this.restore.Text = "恢复";
            this.restore.UseVisualStyleBackColor = false;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(524, 539);
            this.Controls.Add(this.restore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxScores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.pic_bj);
            this.Controls.Add(this.reset);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_bj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.PictureBox pic_bj;
        private System.Windows.Forms.Label scores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maxScores;
        private System.Windows.Forms.Button restore;

    }
}

