namespace Viewer1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._web = new System.Windows.Forms.WebBrowser();
            this._wtest = new System.Windows.Forms.ToolStripButton();
            this._wtest2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this._web);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._wtest,
            this._wtest2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(159, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // _web
            // 
            this._web.Dock = System.Windows.Forms.DockStyle.Fill;
            this._web.Location = new System.Drawing.Point(0, 0);
            this._web.MinimumSize = new System.Drawing.Size(20, 20);
            this._web.Name = "_web";
            this._web.Size = new System.Drawing.Size(800, 425);
            this._web.TabIndex = 0;
            // 
            // _wtest
            // 
            this._wtest.Image = ((System.Drawing.Image)(resources.GetObject("_wtest.Image")));
            this._wtest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._wtest.Name = "_wtest";
            this._wtest.Size = new System.Drawing.Size(55, 22);
            this._wtest.Text = "wtest";
            this._wtest.Click += new System.EventHandler(this._wtest_Click);
            // 
            // _wtest2
            // 
            this._wtest2.Image = ((System.Drawing.Image)(resources.GetObject("_wtest2.Image")));
            this._wtest2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._wtest2.Name = "_wtest2";
            this._wtest2.Size = new System.Drawing.Size(61, 22);
            this._wtest2.Text = "wtest2";
            this._wtest2.Click += new System.EventHandler(this._wtest2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewer1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.WebBrowser _web;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _wtest;
        private System.Windows.Forms.ToolStripButton _wtest2;
    }
}

