using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.Runtime.InteropServices;

namespace Desktop
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// SendTo Command Exist Flags
        /// </summary>
        bool SendToFlag = false;
        string TargetPath = "";
        string FullName = "";
        string WorkingDirectory = "";
        string Description = "";
        string Arguments = "";
        string Hotkey = "";
        string IconLocation = "";

        public FrmMain()
        {
            InitializeComponent();

            Init();

            GetSendToButtonStatus();
        }

        #region //init func
        private void Init()
        {
            this.AllowDrop = true;
            this.tsslMsg.Text = "";

            this.cbDesktop.Checked = true;
            this.cbStartMenu.Checked = true;

            this.cbCtrl.Checked = true;
            this.cbShift.Checked = true;

            #region //get commandline args
            String[] args = System.Environment.GetCommandLineArgs();

            List<string> list = new List<string>();

            if (args.Length > 1)
            {
                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i].EndsWith(".exe"))
                    {
                        list.Add(args[i]);
                    }
                }
                if (list.Count > 0)
                {
                    string path = list[0];

                    this.tbPath.Text = path;

                    FullName = path.Substring(path.LastIndexOf(@"\") + 1);
                    FullName = FullName.Replace(".exe", "");

                    this.tbFullName.Text = FullName;
                }
            } 
            #endregion

            #region //add shortcut char
            for (int i = 0; i < 26; i++)
            {
                int tmp = i + 65;
                char ch = (char)tmp;
                this.cmbShutcuts.Items.Add(ch);
            }
            for (int i = 0; i < 10; i++)
            {
                this.cmbShutcuts.Items.Add(i);
            } 
            #endregion

            #region //add events
            this.btnBrowser.Click += new EventHandler(btnBrowser_Click);
            this.btnCreate.Click += new EventHandler(btnCreate_Click);
            this.btnClose.Click += new EventHandler(btnClose_Click);
            this.btnSendTo.Click += new EventHandler(btnSendTo_Click);
            this.lklblAboutAuthor.Click += new EventHandler(AboutAuthor_Click);
            this.lklblAboutSrc.Click += new EventHandler(AboutSrc_Click);
            this.DragEnter += new DragEventHandler(FrmMain_DragEnter);
            this.DragDrop += new DragEventHandler(FrmMain_DragDrop); 
            #endregion
        } 
        #endregion

        #region //Select app file
        /// <summary>
        /// Select app file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            Msg("", MSG_TYPE.ERROR);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "EXE可执行程序|*.exe";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.tbPath.Text = dialog.FileName;

                FullName = dialog.SafeFileName;

                FullName = FullName.Replace(".exe", "");

                this.tbFullName.Text = FullName;
            }
            else
            {
                this.tbPath.Text = "";
                this.tbFullName.Text = "";
            }
        } 
        #endregion

        #region //Create Shortcut
        /// <summary>
        /// Create Shortcut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            TargetPath = "";
            WorkingDirectory = "";
            Description = "";
            Arguments = "";
            Hotkey = "";
            IconLocation = "";

            if (string.IsNullOrEmpty(this.tbPath.Text.Trim()))
            {
                Msg("未选择文件", MSG_TYPE.ERROR);
                return;
            }
            if (!this.cbDesktop.Checked && !this.cbStartMenu.Checked)
            {
                Msg("未选择快捷方式类型", MSG_TYPE.ERROR);
                return;
            }

            if (this.cmbShutcuts.SelectedIndex > -1)
            {
                if (this.cbCtrl.Checked || this.cbShift.Checked || this.cbAlt.Checked)
                {
                    Hotkey += this.cbCtrl.Checked ? "CTRL+" : "";
                    Hotkey += this.cbShift.Checked ? "SHIFT+" : "";
                    Hotkey += this.cbAlt.Checked ? "ALT+" : "";
                    Hotkey += this.cmbShutcuts.Text;
                }
            }

            TargetPath = this.tbPath.Text.Trim();

            FullName = this.tbFullName.Text.Trim();
            WorkingDirectory = TargetPath.Replace(@"\" + FullName + ".exe", "");
            Description = this.rtbDescription.Text.Trim();
            Arguments = this.tbArguments.Text.Trim();
            IconLocation = string.Format("{0},0", TargetPath);//icon

            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();

            //Desktop
            if (this.cbDesktop.Checked)
            {
                string DesktopPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
                IWshRuntimeLibrary.IWshShortcut Desktop = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(DesktopPath + string.Format(@"\{0}.lnk", FullName));

                Desktop.TargetPath = TargetPath;
                Desktop.Arguments = Arguments;
                Desktop.Description = Description;
                Desktop.WorkingDirectory = WorkingDirectory;
                Desktop.IconLocation = IconLocation;
                Desktop.Hotkey = Hotkey;
                Desktop.WindowStyle = 1;
                Desktop.Save();
                Msg("创建快捷方式完成", MSG_TYPE.GREEN);
            }

            if (this.cbStartMenu.Checked)
            {
                //StartMenu
                string StartMenuPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.StartMenu);
                IWshRuntimeLibrary.IWshShortcut StartMenu = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(StartMenuPath + string.Format(@"\{0}.lnk", FullName));

                StartMenu.TargetPath = TargetPath;
                StartMenu.Arguments = Arguments;
                StartMenu.Description = Description;
                StartMenu.WorkingDirectory = WorkingDirectory;
                StartMenu.IconLocation = IconLocation;
                StartMenu.Hotkey = Hotkey;
                StartMenu.WindowStyle = 1;
                StartMenu.Save();
                Msg("创建快捷方式完成", MSG_TYPE.GREEN);
            }
        } 
        #endregion

        #region //Close
        /// <summary>
        /// //Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        } 
        #endregion

        #region //SendTo Command
        /// <summary>
        /// SendTo Command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendTo_Click(object sender, EventArgs e)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.SendTo);
            string link = string.Format(@"{0}\{1}.lnk", path, this.Text);

            if (!SendToFlag)
            {
                IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();

                IWshRuntimeLibrary.IWshShortcut SendTo = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(link);

                SendTo.TargetPath = this.GetType().Assembly.Location;
                SendTo.Arguments = "";
                SendTo.Description = "Windows系统快捷方法创建工具";
                SendTo.WorkingDirectory = System.Environment.CurrentDirectory;
                SendTo.IconLocation = string.Format("{0},0", this.GetType().Assembly.Location);
                SendTo.Hotkey = "CTRL+S";
                SendTo.WindowStyle = 1;
                SendTo.Save();
                Msg("删除\"发送到\"命令完成", MSG_TYPE.ERROR);
            }
            else
            {
                System.IO.File.Delete(link);
                Msg("删除\"发送到\"命令完成", MSG_TYPE.GREEN);
            }
            GetSendToButtonStatus();
        } 
        #endregion

        #region //about
        private void AboutAuthor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cnblogs.com/seayxu/");
        }

        private void AboutSrc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SeayXu/WinCShortcut");
        } 
        #endregion

        #region //drop files completed
        /// <summary>
        /// drop files completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (s.Length < 1)
            {
                return;
            }

            if (s[0].ToLower().EndsWith(".exe"))
            {
                this.tbPath.Text = s[0];

                FullName = this.tbPath.Text.Trim().Substring(this.tbPath.Text.Trim().LastIndexOf(@"\") + 1);
                FullName = FullName.Replace(".exe", "");

                this.tbFullName.Text = FullName;
            }
            else
            {
                Msg("拖放的文件只能是exe文件", MSG_TYPE.ERROR);
            }
        } 
        #endregion

        #region //drop files into
        /// <summary>
        /// drop files into
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            Msg("", MSG_TYPE.ERROR);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        } 
        #endregion

        #region //tip message display function
        /// <summary>
        /// tip message display function
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="type"></param>
        private void Msg(string msg, MSG_TYPE type)
        {
            Color color = Color.Blue;
            switch (type)
            {
                case MSG_TYPE.ERROR:
                    color = Color.Red;
                    break;
                case MSG_TYPE.BLUE:
                    color = Color.Blue;
                    break;
                case MSG_TYPE.GREEN:
                    color = Color.Green;
                    break;
            }
            this.tsslMsg.ForeColor = color;
            this.tsslMsg.Text = msg;
        } 
        #endregion

        #region //exist sendto command function
        /// <summary>
        /// exist sendto command function
        /// </summary>
        private bool ExistSendTo()
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.SendTo);
            string link = string.Format(@"{0}\{1}.lnk", path,this.Text);
            if (System.IO.File.Exists(link))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region //get sendto command status
        /// <summary>
        /// get sendto command status
        /// </summary>
        private void GetSendToButtonStatus()
        {
            if (ExistSendTo())
            {
                this.btnSendTo.Text = "删除鼠标右键\"发送到\"命令";
                SendToFlag = true;
            }
            else
            {
                this.btnSendTo.Text = "添加到鼠标右键\"发送到\"命令";
                SendToFlag = false;
            }
        }
        #endregion

        #region //tips message type color
        enum MSG_TYPE
        {
            ERROR = 0,
            BLUE = 1,
            GREEN = 2
        } 
        #endregion
    }
}
