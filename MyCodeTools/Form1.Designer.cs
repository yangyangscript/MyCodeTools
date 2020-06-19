namespace MyCodeTools
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnClass = new System.Windows.Forms.Button();
            this.tbxShow = new System.Windows.Forms.TextBox();
            this.cbCopy = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegedit = new System.Windows.Forms.Button();
            this.btnRegeditCancel = new System.Windows.Forms.Button();
            this.StringIn = new System.Windows.Forms.Button();
            this.DDateSet = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(13, 22);
            this.tbxInput.Multiline = true;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(356, 416);
            this.tbxInput.TabIndex = 0;
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(375, 72);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(101, 33);
            this.btnClass.TabIndex = 2;
            this.btnClass.Text = "Class";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // tbxShow
            // 
            this.tbxShow.Location = new System.Drawing.Point(494, 22);
            this.tbxShow.Multiline = true;
            this.tbxShow.Name = "tbxShow";
            this.tbxShow.Size = new System.Drawing.Size(575, 416);
            this.tbxShow.TabIndex = 2;
            // 
            // cbCopy
            // 
            this.cbCopy.AutoSize = true;
            this.cbCopy.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCopy.Checked = true;
            this.cbCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCopy.Location = new System.Drawing.Point(375, 34);
            this.cbCopy.Name = "cbCopy";
            this.cbCopy.Size = new System.Drawing.Size(74, 19);
            this.cbCopy.TabIndex = 1;
            this.cbCopy.Text = "剪切板";
            this.cbCopy.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "AutoMapper";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "我的代码工具";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem2.Text = "退出";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // btnRegedit
            // 
            this.btnRegedit.Location = new System.Drawing.Point(375, 367);
            this.btnRegedit.Name = "btnRegedit";
            this.btnRegedit.Size = new System.Drawing.Size(101, 33);
            this.btnRegedit.TabIndex = 4;
            this.btnRegedit.Text = "开机启动";
            this.btnRegedit.UseVisualStyleBackColor = true;
            this.btnRegedit.Click += new System.EventHandler(this.btnRegedit_Click);
            // 
            // btnRegeditCancel
            // 
            this.btnRegeditCancel.Location = new System.Drawing.Point(375, 406);
            this.btnRegeditCancel.Name = "btnRegeditCancel";
            this.btnRegeditCancel.Size = new System.Drawing.Size(101, 33);
            this.btnRegeditCancel.TabIndex = 5;
            this.btnRegeditCancel.Text = "取消启动";
            this.btnRegeditCancel.UseVisualStyleBackColor = true;
            this.btnRegeditCancel.Click += new System.EventHandler(this.btnRegeditCancel_Click);
            // 
            // StringIn
            // 
            this.StringIn.Location = new System.Drawing.Point(375, 150);
            this.StringIn.Name = "StringIn";
            this.StringIn.Size = new System.Drawing.Size(101, 33);
            this.StringIn.TabIndex = 6;
            this.StringIn.Text = "StringIn";
            this.StringIn.UseVisualStyleBackColor = true;
            this.StringIn.Click += new System.EventHandler(this.StringIn_Click);
            // 
            // DDateSet
            // 
            this.DDateSet.Location = new System.Drawing.Point(376, 190);
            this.DDateSet.Name = "DDateSet";
            this.DDateSet.Size = new System.Drawing.Size(101, 33);
            this.DDateSet.TabIndex = 7;
            this.DDateSet.Text = "DDateSet";
            this.DDateSet.UseVisualStyleBackColor = true;
            this.DDateSet.Click += new System.EventHandler(this.DDateSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.DDateSet);
            this.Controls.Add(this.StringIn);
            this.Controls.Add(this.btnRegeditCancel);
            this.Controls.Add(this.btnRegedit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbCopy);
            this.Controls.Add(this.tbxShow);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.tbxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.TextBox tbxShow;
        private System.Windows.Forms.CheckBox cbCopy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btnRegedit;
        private System.Windows.Forms.Button btnRegeditCancel;
        private System.Windows.Forms.Button StringIn;
        private System.Windows.Forms.Button DDateSet;
    }
}

