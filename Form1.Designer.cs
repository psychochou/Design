namespace Design
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RGB = new System.Windows.Forms.ToolStripSplitButton();
            this.获取屏幕颜色F1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBHEXF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBHEXF3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HEX = new System.Windows.Forms.ToolStripButton();
            this.switchCaseButton = new System.Windows.Forms.ToolStripSplitButton();
            this.生成字母表和数字大写ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.英文到中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排序空白分割后最后一个ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.中 = new System.Windows.Forms.ToolStripButton();
            this.生成二维码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qrButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RGB,
            this.HEX,
            this.switchCaseButton,
            this.中,
            this.qrButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(205, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RGB
            // 
            this.RGB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RGB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.获取屏幕颜色F1ToolStripMenuItem,
            this.rGBHEXF2ToolStripMenuItem,
            this.rGBHEXF3ToolStripMenuItem});
            this.RGB.Image = ((System.Drawing.Image)(resources.GetObject("RGB.Image")));
            this.RGB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RGB.Name = "RGB";
            this.RGB.Size = new System.Drawing.Size(49, 22);
            this.RGB.Text = "RGB";
            this.RGB.ButtonClick += new System.EventHandler(this.RGB_ButtonClick);
            this.RGB.Click += new System.EventHandler(this.RGB_Click);
            // 
            // 获取屏幕颜色F1ToolStripMenuItem
            // 
            this.获取屏幕颜色F1ToolStripMenuItem.Name = "获取屏幕颜色F1ToolStripMenuItem";
            this.获取屏幕颜色F1ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.获取屏幕颜色F1ToolStripMenuItem.Text = "获取屏幕颜色（F1）";
            this.获取屏幕颜色F1ToolStripMenuItem.Click += new System.EventHandler(this.获取屏幕颜色F1ToolStripMenuItem_Click);
            // 
            // rGBHEXF2ToolStripMenuItem
            // 
            this.rGBHEXF2ToolStripMenuItem.Name = "rGBHEXF2ToolStripMenuItem";
            this.rGBHEXF2ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rGBHEXF2ToolStripMenuItem.Text = "RGB-HEX(F2)";
            this.rGBHEXF2ToolStripMenuItem.Click += new System.EventHandler(this.rGBHEXF2ToolStripMenuItem_Click);
            // 
            // rGBHEXF3ToolStripMenuItem
            // 
            this.rGBHEXF3ToolStripMenuItem.Name = "rGBHEXF3ToolStripMenuItem";
            this.rGBHEXF3ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rGBHEXF3ToolStripMenuItem.Text = "RGB-HEX(F3)";
            this.rGBHEXF3ToolStripMenuItem.Click += new System.EventHandler(this.rGBHEXF3ToolStripMenuItem_Click);
            // 
            // HEX
            // 
            this.HEX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HEX.Image = ((System.Drawing.Image)(resources.GetObject("HEX.Image")));
            this.HEX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HEX.Name = "HEX";
            this.HEX.Size = new System.Drawing.Size(36, 22);
            this.HEX.Text = "HEX";
            this.HEX.Click += new System.EventHandler(this.HEX_Click);
            // 
            // switchCaseButton
            // 
            this.switchCaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.switchCaseButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成字母表和数字大写ToolStripMenuItem,
            this.toolStripSeparator1,
            this.英文到中文ToolStripMenuItem,
            this.排序空白分割后最后一个ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.生成二维码ToolStripMenuItem});
            this.switchCaseButton.Image = ((System.Drawing.Image)(resources.GetObject("switchCaseButton.Image")));
            this.switchCaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.switchCaseButton.Name = "switchCaseButton";
            this.switchCaseButton.Size = new System.Drawing.Size(32, 22);
            this.switchCaseButton.Text = "切换大小写";
            this.switchCaseButton.ButtonClick += new System.EventHandler(this.switchCaseButton_ButtonClick);
            // 
            // 生成字母表和数字大写ToolStripMenuItem
            // 
            this.生成字母表和数字大写ToolStripMenuItem.Name = "生成字母表和数字大写ToolStripMenuItem";
            this.生成字母表和数字大写ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.生成字母表和数字大写ToolStripMenuItem.Text = "生成字母表和数字（大写）";
            this.生成字母表和数字大写ToolStripMenuItem.Click += new System.EventHandler(this.生成字母表和数字大写ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // 英文到中文ToolStripMenuItem
            // 
            this.英文到中文ToolStripMenuItem.Name = "英文到中文ToolStripMenuItem";
            this.英文到中文ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.英文到中文ToolStripMenuItem.Text = "英文到中文";
            // 
            // 排序空白分割后最后一个ToolStripMenuItem
            // 
            this.排序空白分割后最后一个ToolStripMenuItem.Name = "排序空白分割后最后一个ToolStripMenuItem";
            this.排序空白分割后最后一个ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.排序空白分割后最后一个ToolStripMenuItem.Text = "排序（空白分割后最后一个）";
            this.排序空白分割后最后一个ToolStripMenuItem.Click += new System.EventHandler(this.排序空白分割后最后一个ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(232, 22);
            this.toolStripMenuItem2.Text = "123";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 中
            // 
            this.中.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.中.Image = ((System.Drawing.Image)(resources.GetObject("中.Image")));
            this.中.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.中.Name = "中";
            this.中.Size = new System.Drawing.Size(24, 22);
            this.中.Text = "中";
            this.中.Click += new System.EventHandler(this.中_Click);
            // 
            // 生成二维码ToolStripMenuItem
            // 
            this.生成二维码ToolStripMenuItem.Name = "生成二维码ToolStripMenuItem";
            this.生成二维码ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.生成二维码ToolStripMenuItem.Text = "生成二维码";
            this.生成二维码ToolStripMenuItem.Click += new System.EventHandler(this.生成二维码ToolStripMenuItem_Click);
            // 
            // qrButton
            // 
            this.qrButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.qrButton.Image = ((System.Drawing.Image)(resources.GetObject("qrButton.Image")));
            this.qrButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.qrButton.Name = "qrButton";
            this.qrButton.Size = new System.Drawing.Size(30, 22);
            this.qrButton.Text = "QR";
            this.qrButton.Click += new System.EventHandler(this.qrButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 25);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton HEX;
        private System.Windows.Forms.ToolStripSplitButton switchCaseButton;
        private System.Windows.Forms.ToolStripMenuItem 生成字母表和数字大写ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton RGB;
        private System.Windows.Forms.ToolStripMenuItem 获取屏幕颜色F1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 英文到中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 中;
        private System.Windows.Forms.ToolStripMenuItem 排序空白分割后最后一个ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBHEXF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBHEXF3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 生成二维码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton qrButton;
    }
}

