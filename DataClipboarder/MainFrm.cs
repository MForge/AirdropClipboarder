using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace AirdropClipboarder
{
    public partial class AirdropClipboarderMain : Form
    {
        // pour le process focus
        [DllImport("user32.dll")]
        private static extern
        bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern
            bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern
            bool IsIconic(IntPtr hWnd);

        private const int SW_HIDE = 0;
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        private const int SW_SHOWNOACTIVATE = 4;
        private const int SW_RESTORE = 9;
        private const int SW_SHOWDEFAULT = 10;

        private SettingsMgr m_SettingsMgr;
        private Boolean isLoadingSettings = false;

        public AirdropClipboarderMain()
        {
            InitializeComponent();

            // change version : Properties / AssemblyInfo.cs
            string version = (FileVersionInfo.GetVersionInfo((Assembly.GetExecutingAssembly()).Location)).FileVersion; // or fvi.ProductVersion
            this.Text = this.Text + " - MForge.org - v." + version.Remove(version.Length - 4);

            loadSettings();
            loadDatas();
            activeLaunchers();
        }

        public void loadSettings()
        {
            m_SettingsMgr = new SettingsMgr();

            if (File.Exists(SettingsMgr.fileName))
            {
                isLoadingSettings = true;

                m_SettingsMgr.loadFromXml();

                isLoadingSettings = false;
            }
        }

        private void updateSettings()
        {
            if ((m_SettingsMgr != null) && (!isLoadingSettings))
            {
                saveSettings();
            }
        }

        private void showLog(string aLog)
        {
            if (logsRTB.Text == "")
            {
                logsRTB.AppendText(aLog);
            }
            else
            {
                logsRTB.AppendText(Environment.NewLine + aLog);
            }

            logsRTB.SelectionStart = logsRTB.Text.Length;
            logsRTB.ScrollToCaret();
        }

        public void saveSettings()
        {
            m_SettingsMgr.saveToXml();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void closeTSMI_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AirdopClipboarderMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MainIcon.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void loadDatas()
        {
            dgvDatas.Rows.Clear();
            dgvDatas.Refresh();

            foreach (Data data in m_SettingsMgr.MyDataList)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dgvDatas, data.MyData, data.Description);

                dgvDatas.Rows.Add(row);
            }

            dgvDatas.ClearSelection();
        }

        private void activeLaunchers()
        {
            try
            {
                if (m_SettingsMgr.MyLaunchers.getLink(utils.TelegramLnk) != "")
                    btnLaunchTelegram.Enabled = true;
                else
                    btnLaunchTelegram.Enabled = false;

                if (m_SettingsMgr.MyLaunchers.getLink(utils.TwitterLnk) != "")
                    btnLaunchTwitter.Enabled = true;
                else
                    btnLaunchTwitter.Enabled = false;

                if (m_SettingsMgr.MyLaunchers.getLink(utils.FacebookLnk) != "")
                    btnLaunchFacebook.Enabled = true;
                else
                    btnLaunchFacebook.Enabled = false;

                if (m_SettingsMgr.MyLaunchers.getLink(utils.YoutubeLnk) != "")              
                    btnLaunchYoutube.Enabled = true;
                else
                    btnLaunchYoutube.Enabled = false;

                if (m_SettingsMgr.MyLaunchers.getLink(utils.BtcTlkLnk) != "")               
                    btnLaunchBctTlk.Enabled = true;
                else
                    btnLaunchBctTlk.Enabled = false;

                if (m_SettingsMgr.MyLaunchers.getLink(utils.MediumLnk) != "")               
                    btnLaunchMedium.Enabled = true;
                else
                    btnLaunchMedium.Enabled = false;

                if (m_SettingsMgr.MyLaunchers.getLink(utils.RedditLnk) != "")                
                    btnLaunchReddit.Enabled = true;
                else
                    btnLaunchReddit.Enabled = false;

                if (m_SettingsMgr.MyLaunchers.getLink(utils.LinkedinLnk) != "")                
                    btnLaunchLinkedin.Enabled = true;
                else
                    btnLaunchLinkedin.Enabled = false;

                if (m_SettingsMgr.MyLaunchers.getLink(utils.InstagramLnk) != "")             
                    btnLaunchInstagram.Enabled = true;
                else
                    btnLaunchInstagram.Enabled = false;

                if (m_SettingsMgr.MyLaunchers.getLink(utils.DiscordLnk) != "")
                    btnLaunchDiscord.Enabled = true;
                else
                    btnLaunchDiscord.Enabled = false;
                //-------------------------------------------

                if (m_SettingsMgr.MyLaunchers.getLink(utils.A) != "")               
                    btnLaunchA.Enabled = true;
                else
                    btnLaunchA.Enabled = false;

                if (m_SettingsMgr.MyLaunchers.getLink(utils.B) != "")
                    btnLaunchB.Enabled = true;
                else
                    btnLaunchB.Enabled = false;

                if (m_SettingsMgr.MyLaunchers.getLink(utils.C) != "")
                    btnLaunchC.Enabled = true;
                else
                    btnLaunchC.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Airdrop Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void btnBTC_Click(object sender, EventArgs e)
        {
            dgvDatas.ClearSelection();
            Clipboard.SetText(tbBTC.Text);
            showLog(@"""BTC"" address copied to the clipboard.");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            dgvDatas.ClearSelection();
            Clipboard.SetText(tbETH.Text);
            showLog(@"""ETH"" address copied to the clipboard.");
        }

        private void AirdropClipboarderMain_Shown(object sender, EventArgs e)
        {
            dgvDatas.ClearSelection();
        }

        private void dgvDatas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedData = dgvDatas.Rows[dgvDatas.CurrentCell.RowIndex].Cells[0].Value.ToString();

            Clipboard.SetText(selectedData);
            showLog(@"""" + selectedData + @""" copied to the clipboard.");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDatasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataListFrm frmMiner = new DataListFrm(m_SettingsMgr.MySettings);
            frmMiner.ShowDialog();
            saveSettings();
            loadDatas();
        }

        private void AirdropClipboarderMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WindowLocation != null)
            {
                this.Location = Properties.Settings.Default.WindowLocation;
            }

            if (Properties.Settings.Default.WindowsSize != null)
            {
                this.Size = Properties.Settings.Default.WindowsSize;
            }

            
        }

        private void AirdopClipboarderMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowLocation = this.Location;

            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.WindowsSize = this.Size;
            }
            else
            {
                Properties.Settings.Default.WindowsSize = this.RestoreBounds.Size;
            }
            Properties.Settings.Default.Save();
        }

        private void dgvDatas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvDatas.ClearSelection();
        }

        private void btnLaunchLinkedin_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.LinkedinLnk));
        }

        private void launchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LauncherConfig frmLaunchers = new LauncherConfig(m_SettingsMgr.MySettings);
            frmLaunchers.ShowDialog();
            saveSettings();
            activeLaunchers();
        }

        private void btnWWW_Click(object sender, EventArgs e)
        {
            startProc("http://www.mforge.org");
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            startProc("https://www.youtube.com/channel/UCJxJRCVHtH8ou97JK_CXn_g");
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            startProc("https://www.facebook.com/MForge-397373667285919");
        }

        private void btngitHub_Click(object sender, EventArgs e)
        {
            startProc("https://github.com/MForge");
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            startProc("https://twitter.com/MForgeM");
        }

        private void btnLaunchTelegram_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.TelegramLnk));
        }

        private void btnLaunchTwitter_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.TwitterLnk));
        }

        private void btnLaunchFacebook_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.FacebookLnk));
        }

        private void btnLaunchYoutube_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.YoutubeLnk));
        }

        private void btnLaunchBctTlk_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.BtcTlkLnk));
        }

        private void btnLaunchMedium_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.MediumLnk));
        }

        private void btnLaunchReddit_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.RedditLnk));
        }

        private void btnLaunchInstagram_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.InstagramLnk));
        }

        private void btnLaunchA_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.A));
        }

        private void btnLaunchB_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.B));
        }

        private void btnLaunchC_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.C));
        }
        private void startProc(string aCommand)
        {
            try
            {
                Process.Start(aCommand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Airdrop Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLaunchDiscord_Click(object sender, EventArgs e)
        {
            startProc(m_SettingsMgr.MyLaunchers.getLink(utils.DiscordLnk));
        }
    }
}