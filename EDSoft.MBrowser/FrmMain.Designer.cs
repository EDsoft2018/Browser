namespace EDSoft.MBrowser
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_number = new System.Windows.Forms.ToolStripTextBox();
            this.btn_stop = new System.Windows.Forms.ToolStripButton();
            this.txt_url = new System.Windows.Forms.ToolStripTextBox();
            this.btn_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lbl_url = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Start,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.txt_number,
            this.btn_stop,
            this.txt_url,
            this.btn_Open,
            this.toolStripButton1});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // btn_Start
            // 
            resources.ApplyResources(this.btn_Start, "btn_Start");
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // txt_number
            // 
            this.txt_number.Name = "txt_number";
            resources.ApplyResources(this.txt_number, "txt_number");
            // 
            // btn_stop
            // 
            resources.ApplyResources(this.btn_stop, "btn_stop");
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // txt_url
            // 
            this.txt_url.Name = "txt_url";
            resources.ApplyResources(this.txt_url, "txt_url");
            // 
            // btn_Open
            // 
            this.btn_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btn_Open, "btn_Open");
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lbl_url
            // 
            resources.ApplyResources(this.lbl_url, "lbl_url");
            this.lbl_url.Name = "lbl_url";
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Start;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txt_number;
        private System.Windows.Forms.ToolStripButton btn_stop;
        private System.Windows.Forms.ToolStripTextBox txt_url;
        private System.Windows.Forms.ToolStripButton btn_Open;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

