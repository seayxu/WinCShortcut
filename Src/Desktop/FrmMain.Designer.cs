namespace Desktop
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbArguments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbShutcuts = new System.Windows.Forms.ComboBox();
            this.cbAlt = new System.Windows.Forms.CheckBox();
            this.cbShift = new System.Windows.Forms.CheckBox();
            this.cbCtrl = new System.Windows.Forms.CheckBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.cbStartMenu = new System.Windows.Forms.CheckBox();
            this.cbDesktop = new System.Windows.Forms.CheckBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tsslMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSendTo = new System.Windows.Forms.Button();
            this.lklblAboutAuthor = new System.Windows.Forms.LinkLabel();
            this.lklblAboutSrc = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lklblAboutSrc);
            this.groupBox1.Controls.Add(this.lklblAboutAuthor);
            this.groupBox1.Controls.Add(this.btnSendTo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "关于";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFullName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbArguments);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbShutcuts);
            this.groupBox2.Controls.Add(this.cbAlt);
            this.groupBox2.Controls.Add(this.cbShift);
            this.groupBox2.Controls.Add(this.cbCtrl);
            this.groupBox2.Controls.Add(this.rtbDescription);
            this.groupBox2.Controls.Add(this.cbStartMenu);
            this.groupBox2.Controls.Add(this.cbDesktop);
            this.groupBox2.Controls.Add(this.btnBrowser);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbPath);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "创建快捷方式";
            // 
            // StatusBar
            // 
            this.StatusBar.AutoSize = false;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMsg});
            this.StatusBar.Location = new System.Drawing.Point(0, 278);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(281, 22);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "状态栏";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(54, 45);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(211, 21);
            this.tbFullName.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "名称：";
            // 
            // tbArguments
            // 
            this.tbArguments.Location = new System.Drawing.Point(54, 116);
            this.tbArguments.Name = "tbArguments";
            this.tbArguments.Size = new System.Drawing.Size(211, 21);
            this.tbArguments.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "参数：";
            // 
            // cmbShutcuts
            // 
            this.cmbShutcuts.DropDownHeight = 120;
            this.cmbShutcuts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShutcuts.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbShutcuts.FormattingEnabled = true;
            this.cmbShutcuts.IntegralHeight = false;
            this.cmbShutcuts.Location = new System.Drawing.Point(225, 141);
            this.cmbShutcuts.Name = "cmbShutcuts";
            this.cmbShutcuts.Size = new System.Drawing.Size(40, 22);
            this.cmbShutcuts.TabIndex = 29;
            // 
            // cbAlt
            // 
            this.cbAlt.AutoSize = true;
            this.cbAlt.Location = new System.Drawing.Point(176, 144);
            this.cbAlt.Name = "cbAlt";
            this.cbAlt.Size = new System.Drawing.Size(42, 16);
            this.cbAlt.TabIndex = 26;
            this.cbAlt.Text = "Alt";
            this.cbAlt.UseVisualStyleBackColor = true;
            // 
            // cbShift
            // 
            this.cbShift.AutoSize = true;
            this.cbShift.Location = new System.Drawing.Point(116, 144);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(54, 16);
            this.cbShift.TabIndex = 27;
            this.cbShift.Text = "Shift";
            this.cbShift.UseVisualStyleBackColor = true;
            // 
            // cbCtrl
            // 
            this.cbCtrl.AutoSize = true;
            this.cbCtrl.Location = new System.Drawing.Point(64, 144);
            this.cbCtrl.Name = "cbCtrl";
            this.cbCtrl.Size = new System.Drawing.Size(48, 16);
            this.cbCtrl.TabIndex = 28;
            this.cbCtrl.Text = "Ctrl";
            this.cbCtrl.UseVisualStyleBackColor = true;
            // 
            // rtbDescription
            // 
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescription.Location = new System.Drawing.Point(54, 70);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(211, 39);
            this.rtbDescription.TabIndex = 25;
            this.rtbDescription.Text = "";
            // 
            // cbStartMenu
            // 
            this.cbStartMenu.AutoSize = true;
            this.cbStartMenu.Location = new System.Drawing.Point(18, 192);
            this.cbStartMenu.Name = "cbStartMenu";
            this.cbStartMenu.Size = new System.Drawing.Size(72, 16);
            this.cbStartMenu.TabIndex = 24;
            this.cbStartMenu.Text = "开始菜单";
            this.cbStartMenu.UseVisualStyleBackColor = true;
            // 
            // cbDesktop
            // 
            this.cbDesktop.AutoSize = true;
            this.cbDesktop.Location = new System.Drawing.Point(18, 174);
            this.cbDesktop.Name = "cbDesktop";
            this.cbDesktop.Size = new System.Drawing.Size(48, 16);
            this.cbDesktop.TabIndex = 23;
            this.cbDesktop.Text = "桌面";
            this.cbDesktop.UseVisualStyleBackColor = true;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(243, 20);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(22, 21);
            this.btnBrowser.TabIndex = 21;
            this.btnBrowser.Text = "…";
            this.btnBrowser.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(190, 173);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "快捷键：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "描述：";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(54, 20);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(190, 21);
            this.tbPath.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "路径：";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(109, 173);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 32);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "创建";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // tsslMsg
            // 
            this.tsslMsg.ActiveLinkColor = System.Drawing.Color.Gray;
            this.tsslMsg.Name = "tsslMsg";
            this.tsslMsg.Size = new System.Drawing.Size(32, 17);
            this.tsslMsg.Text = "就绪";
            this.tsslMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSendTo
            // 
            this.btnSendTo.Location = new System.Drawing.Point(18, 17);
            this.btnSendTo.Name = "btnSendTo";
            this.btnSendTo.Size = new System.Drawing.Size(180, 31);
            this.btnSendTo.TabIndex = 0;
            this.btnSendTo.Text = "添加到鼠标右键\"发送到\"命令";
            this.btnSendTo.UseVisualStyleBackColor = true;
            // 
            // lklblAboutAuthor
            // 
            this.lklblAboutAuthor.AutoSize = true;
            this.lklblAboutAuthor.Location = new System.Drawing.Point(206, 19);
            this.lklblAboutAuthor.Name = "lklblAboutAuthor";
            this.lklblAboutAuthor.Size = new System.Drawing.Size(53, 12);
            this.lklblAboutAuthor.TabIndex = 1;
            this.lklblAboutAuthor.TabStop = true;
            this.lklblAboutAuthor.Text = "关于作者";
            // 
            // lklblAboutSrc
            // 
            this.lklblAboutSrc.AutoSize = true;
            this.lklblAboutSrc.Location = new System.Drawing.Point(206, 36);
            this.lklblAboutSrc.Name = "lklblAboutSrc";
            this.lklblAboutSrc.Size = new System.Drawing.Size(53, 12);
            this.lklblAboutSrc.TabIndex = 1;
            this.lklblAboutSrc.TabStop = true;
            this.lklblAboutSrc.Text = "项目源码";
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 300);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快捷方式创建工具";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbArguments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbShutcuts;
        private System.Windows.Forms.CheckBox cbAlt;
        private System.Windows.Forms.CheckBox cbShift;
        private System.Windows.Forms.CheckBox cbCtrl;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.CheckBox cbStartMenu;
        private System.Windows.Forms.CheckBox cbDesktop;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslMsg;
        private System.Windows.Forms.Button btnSendTo;
        private System.Windows.Forms.LinkLabel lklblAboutAuthor;
        private System.Windows.Forms.LinkLabel lklblAboutSrc;


    }
}

