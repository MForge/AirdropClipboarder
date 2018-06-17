using System;
using System.Windows.Forms;

namespace AirdropClipboarder
{
    public partial class LauncherConfig : Form
    {
        private Settings m_settings;

        public LauncherConfig()
        {
            try
            {
                InitializeComponent();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Airdrop Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public LauncherConfig(Settings aSettings, bool forceAdd = false)
        {
            try
            {
                InitializeComponent();
                m_settings = aSettings;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Airdrop Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void loadLaunchers()
        {
            try
            {
                tbTelegram.Text = m_settings.LauncherDic.getLink(utils.TelegramLnk);
                tbTwitter.Text = m_settings.LauncherDic.getLink(utils.TwitterLnk);
                tbFacebook.Text = m_settings.LauncherDic.getLink(utils.FacebookLnk);
                tbYoutube.Text = m_settings.LauncherDic.getLink(utils.YoutubeLnk);
                tbBtcTlk.Text = m_settings.LauncherDic.getLink(utils.BtcTlkLnk);
                tbMedium.Text = m_settings.LauncherDic.getLink(utils.MediumLnk);
                tbReddit.Text = m_settings.LauncherDic.getLink(utils.RedditLnk);
                tbLinkedin.Text = m_settings.LauncherDic.getLink(utils.LinkedinLnk);
                tbInstagram.Text = m_settings.LauncherDic.getLink(utils.InstagramLnk);
                tbDiscord.Text = m_settings.LauncherDic.getLink(utils.DiscordLnk);

                tbA.Text = m_settings.LauncherDic.getLink(utils.A);
                tbB.Text = m_settings.LauncherDic.getLink(utils.B);
                tbC.Text = m_settings.LauncherDic.getLink(utils.C);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Airdrop Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Airdrop Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCleanTelegram_Click(object sender, EventArgs e)
        {
            tbTelegram.Clear();
        }

        private void btnCleanTwitter_Click(object sender, EventArgs e)
        {
            tbTwitter.Clear();
        }

        private void btnCleanFacebook_Click(object sender, EventArgs e)
        {
            tbFacebook.Clear();
        }

        private void btnCleanYoutube_Click(object sender, EventArgs e)
        {
            tbYoutube.Clear();
        }

        private void btnCleanBtcTlk_Click(object sender, EventArgs e)
        {
            tbBtcTlk.Clear();
        }

        private void btnCleanMedium_Click(object sender, EventArgs e)
        {
            tbMedium.Clear();
        }

        private void btnCleanReddit_Click(object sender, EventArgs e)
        {
            tbReddit.Clear();
        }

        private void btnCleanLinkedIn_Click(object sender, EventArgs e)
        {
            tbLinkedin.Clear();
        }

        private void btnCleanInstagram_Click(object sender, EventArgs e)
        {
            tbInstagram.Clear();
        }

        private void btnCleanA_Click(object sender, EventArgs e)
        {
            tbA.Clear();
        }

        private void btnCleanB_Click(object sender, EventArgs e)
        {
            tbB.Clear();
        }

        private void btnCleanC_Click(object sender, EventArgs e)
        {
            tbC.Clear();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            try
            {
                m_settings.LauncherDic.clear();

                if (tbTelegram.Text != "")
                {
                    m_settings.LauncherDic.add(utils.TelegramLnk, tbTelegram.Text);
                }

                if (tbTwitter.Text != "")
                {
                    m_settings.LauncherDic.add(utils.TwitterLnk, tbTwitter.Text);
                }

                if (tbFacebook.Text != "")
                {
                    m_settings.LauncherDic.add(utils.FacebookLnk, tbFacebook.Text);
                }

                if (tbYoutube.Text != "")
                {
                    m_settings.LauncherDic.add(utils.YoutubeLnk, tbYoutube.Text);
                }

                if (tbBtcTlk.Text != "")
                {
                    m_settings.LauncherDic.add(utils.BtcTlkLnk, tbBtcTlk.Text);
                }

                if (tbMedium.Text != "")
                {
                    m_settings.LauncherDic.add(utils.MediumLnk, tbMedium.Text);
                }

                if (tbReddit.Text != "")
                {
                    m_settings.LauncherDic.add(utils.RedditLnk, tbReddit.Text);
                }

                if (tbLinkedin.Text != "")
                {
                    m_settings.LauncherDic.add(utils.LinkedinLnk, tbLinkedin.Text);
                }

                if (tbInstagram.Text != "")
                {
                    m_settings.LauncherDic.add(utils.InstagramLnk, tbInstagram.Text);
                }

                if (tbDiscord.Text != "")
                {
                    m_settings.LauncherDic.add(utils.DiscordLnk, tbDiscord.Text);
                }
                //--------------------------------------------------------------------------


                if (tbA.Text != "")
                {
                    m_settings.LauncherDic.add(utils.A, tbA.Text);
                }

                if (tbB.Text != "")
                {
                    m_settings.LauncherDic.add(utils.B, tbB.Text);
                }

                if (tbC.Text != "")
                {
                    m_settings.LauncherDic.add(utils.C, tbC.Text);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Airdrop Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LauncherConfig_Shown(object sender, EventArgs e)
        {
            loadLaunchers();
        }

        private void btnCleanDiscord_Click(object sender, EventArgs e)
        {
            tbDiscord.Clear();
        }
    }
}
