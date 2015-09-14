namespace _2048
{
    partial class Qz
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hb = new System.Windows.Forms.Timer(this.components);
            this.zj = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hb
            // 
            this.hb.Interval = 25;
            this.hb.Tick += new System.EventHandler(this.hb_Tick);
            // 
            // zj
            // 
            this.zj.Interval = 10;
            this.zj.Tick += new System.EventHandler(this.zj_Tick);
            // 
            // Qz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Qz";
            this.Size = new System.Drawing.Size(80, 80);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Qz_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer hb;
        public System.Windows.Forms.Timer zj;


    }
}
