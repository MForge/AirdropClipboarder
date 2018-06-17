namespace AirdropClipboarder
{
    partial class AirdropClipboarderMain
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
            this.gbDatas = new System.Windows.Forms.GroupBox();
            this.dgvDatas = new System.Windows.Forms.DataGridView();
            this.descriptionClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDonation = new System.Windows.Forms.GroupBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.btngitHub = new System.Windows.Forms.Button();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnYoutube = new System.Windows.Forms.Button();
            this.btnWWW = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBTC = new System.Windows.Forms.Button();
            this.tbETH = new System.Windows.Forms.TextBox();
            this.tbBTC = new System.Windows.Forms.TextBox();
            this.lblETH = new System.Windows.Forms.Label();
            this.lblBTC = new System.Windows.Forms.Label();
            this.gbLogs = new System.Windows.Forms.GroupBox();
            this.logsRTB = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDatasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLaunchers = new System.Windows.Forms.GroupBox();
            this.btnLaunchDiscord = new System.Windows.Forms.Button();
            this.btnLaunchA = new System.Windows.Forms.Button();
            this.btnLaunchB = new System.Windows.Forms.Button();
            this.btnLaunchC = new System.Windows.Forms.Button();
            this.btnLaunchInstagram = new System.Windows.Forms.Button();
            this.btnLaunchLinkedin = new System.Windows.Forms.Button();
            this.btnLaunchReddit = new System.Windows.Forms.Button();
            this.btnLaunchMedium = new System.Windows.Forms.Button();
            this.btnLaunchBctTlk = new System.Windows.Forms.Button();
            this.btnLaunchYoutube = new System.Windows.Forms.Button();
            this.btnLaunchFacebook = new System.Windows.Forms.Button();
            this.btnLaunchTwitter = new System.Windows.Forms.Button();
            this.btnLaunchTelegram = new System.Windows.Forms.Button();
            this.gbDatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).BeginInit();
            this.gbDonation.SuspendLayout();
            this.gbLogs.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbLaunchers.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatas
            // 
            this.gbDatas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatas.Controls.Add(this.dgvDatas);
            this.gbDatas.Location = new System.Drawing.Point(5, 85);
            this.gbDatas.Name = "gbDatas";
            this.gbDatas.Size = new System.Drawing.Size(423, 117);
            this.gbDatas.TabIndex = 37;
            this.gbDatas.TabStop = false;
            this.gbDatas.Text = "My datas";
            // 
            // dgvDatas
            // 
            this.dgvDatas.AllowUserToAddRows = false;
            this.dgvDatas.AllowUserToDeleteRows = false;
            this.dgvDatas.AllowUserToResizeRows = false;
            this.dgvDatas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionClient,
            this.pathClient});
            this.dgvDatas.Location = new System.Drawing.Point(6, 19);
            this.dgvDatas.MultiSelect = false;
            this.dgvDatas.Name = "dgvDatas";
            this.dgvDatas.RowHeadersVisible = false;
            this.dgvDatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatas.Size = new System.Drawing.Size(413, 92);
            this.dgvDatas.TabIndex = 0;
            this.dgvDatas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatas_CellClick);
            this.dgvDatas.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatas_ColumnHeaderMouseClick);
            // 
            // descriptionClient
            // 
            this.descriptionClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionClient.HeaderText = "Data";
            this.descriptionClient.Name = "descriptionClient";
            this.descriptionClient.ReadOnly = true;
            this.descriptionClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pathClient
            // 
            this.pathClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pathClient.HeaderText = "Description";
            this.pathClient.Name = "pathClient";
            this.pathClient.ReadOnly = true;
            this.pathClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gbDonation
            // 
            this.gbDonation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDonation.Controls.Add(this.lblContact);
            this.gbDonation.Controls.Add(this.btngitHub);
            this.gbDonation.Controls.Add(this.btnTwitter);
            this.gbDonation.Controls.Add(this.btnFacebook);
            this.gbDonation.Controls.Add(this.btnYoutube);
            this.gbDonation.Controls.Add(this.btnWWW);
            this.gbDonation.Controls.Add(this.button1);
            this.gbDonation.Controls.Add(this.btnBTC);
            this.gbDonation.Controls.Add(this.tbETH);
            this.gbDonation.Controls.Add(this.tbBTC);
            this.gbDonation.Controls.Add(this.lblETH);
            this.gbDonation.Controls.Add(this.lblBTC);
            this.gbDonation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbDonation.Location = new System.Drawing.Point(5, 208);
            this.gbDonation.Name = "gbDonation";
            this.gbDonation.Size = new System.Drawing.Size(423, 99);
            this.gbDonation.TabIndex = 38;
            this.gbDonation.TabStop = false;
            this.gbDonation.Text = "MForge contact && Donations";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(11, 23);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(67, 13);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "Contact me :";
            // 
            // btngitHub
            // 
            this.btngitHub.BackgroundImage = global::AirdropClipboarder.Properties.Resources.github22x22;
            this.btngitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btngitHub.Location = new System.Drawing.Point(212, 16);
            this.btngitHub.Name = "btngitHub";
            this.btngitHub.Size = new System.Drawing.Size(26, 26);
            this.btngitHub.TabIndex = 8;
            this.btngitHub.UseVisualStyleBackColor = true;
            this.btngitHub.Click += new System.EventHandler(this.btngitHub_Click);
            // 
            // btnTwitter
            // 
            this.btnTwitter.BackgroundImage = global::AirdropClipboarder.Properties.Resources.twitterlogo;
            this.btnTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTwitter.Location = new System.Drawing.Point(180, 16);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(26, 26);
            this.btnTwitter.TabIndex = 7;
            this.btnTwitter.UseVisualStyleBackColor = true;
            this.btnTwitter.Click += new System.EventHandler(this.btnTwitter_Click);
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackgroundImage = global::AirdropClipboarder.Properties.Resources.Facebook22x22;
            this.btnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacebook.Location = new System.Drawing.Point(148, 16);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(26, 26);
            this.btnFacebook.TabIndex = 6;
            this.btnFacebook.UseVisualStyleBackColor = true;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // btnYoutube
            // 
            this.btnYoutube.BackgroundImage = global::AirdropClipboarder.Properties.Resources.Youtube22x22;
            this.btnYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYoutube.Location = new System.Drawing.Point(116, 16);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(26, 26);
            this.btnYoutube.TabIndex = 5;
            this.btnYoutube.UseVisualStyleBackColor = true;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // btnWWW
            // 
            this.btnWWW.BackgroundImage = global::AirdropClipboarder.Properties.Resources.internet;
            this.btnWWW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWWW.Location = new System.Drawing.Point(84, 16);
            this.btnWWW.Name = "btnWWW";
            this.btnWWW.Size = new System.Drawing.Size(26, 26);
            this.btnWWW.TabIndex = 4;
            this.btnWWW.UseVisualStyleBackColor = true;
            this.btnWWW.Click += new System.EventHandler(this.btnWWW_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(334, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copy ETH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnBTC
            // 
            this.btnBTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBTC.Location = new System.Drawing.Point(334, 46);
            this.btnBTC.Name = "btnBTC";
            this.btnBTC.Size = new System.Drawing.Size(83, 23);
            this.btnBTC.TabIndex = 1;
            this.btnBTC.Text = "Copy BTC";
            this.btnBTC.UseVisualStyleBackColor = true;
            this.btnBTC.Click += new System.EventHandler(this.btnBTC_Click);
            // 
            // tbETH
            // 
            this.tbETH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbETH.Location = new System.Drawing.Point(51, 74);
            this.tbETH.Name = "tbETH";
            this.tbETH.ReadOnly = true;
            this.tbETH.Size = new System.Drawing.Size(277, 20);
            this.tbETH.TabIndex = 2;
            this.tbETH.Text = "0x49fC48aD2a321eeAc512933307daA1e804fB43A3";
            this.tbETH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBTC
            // 
            this.tbBTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBTC.Location = new System.Drawing.Point(51, 48);
            this.tbBTC.Name = "tbBTC";
            this.tbBTC.ReadOnly = true;
            this.tbBTC.Size = new System.Drawing.Size(277, 20);
            this.tbBTC.TabIndex = 0;
            this.tbBTC.Text = "3HJNqLzPuF1fRXzxjZ7zKyBU6otFUKn87q";
            this.tbBTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblETH
            // 
            this.lblETH.AutoSize = true;
            this.lblETH.Location = new System.Drawing.Point(11, 77);
            this.lblETH.Name = "lblETH";
            this.lblETH.Size = new System.Drawing.Size(38, 13);
            this.lblETH.TabIndex = 1;
            this.lblETH.Text = "ETH : ";
            // 
            // lblBTC
            // 
            this.lblBTC.AutoSize = true;
            this.lblBTC.Location = new System.Drawing.Point(11, 52);
            this.lblBTC.Name = "lblBTC";
            this.lblBTC.Size = new System.Drawing.Size(34, 13);
            this.lblBTC.TabIndex = 0;
            this.lblBTC.Text = "BTC :";
            // 
            // gbLogs
            // 
            this.gbLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogs.Controls.Add(this.logsRTB);
            this.gbLogs.Location = new System.Drawing.Point(5, 313);
            this.gbLogs.Name = "gbLogs";
            this.gbLogs.Size = new System.Drawing.Size(423, 75);
            this.gbLogs.TabIndex = 44;
            this.gbLogs.TabStop = false;
            this.gbLogs.Text = "Logs";
            // 
            // logsRTB
            // 
            this.logsRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsRTB.Location = new System.Drawing.Point(3, 16);
            this.logsRTB.Name = "logsRTB";
            this.logsRTB.ReadOnly = true;
            this.logsRTB.Size = new System.Drawing.Size(417, 56);
            this.logsRTB.TabIndex = 3;
            this.logsRTB.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDatasToolStripMenuItem,
            this.addDatasToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addDatasToolStripMenuItem
            // 
            this.addDatasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.addDatasToolStripMenuItem.Name = "addDatasToolStripMenuItem";
            this.addDatasToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.addDatasToolStripMenuItem.Text = "Application";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "Close";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // addDatasToolStripMenuItem1
            // 
            this.addDatasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datasToolStripMenuItem,
            this.launchersToolStripMenuItem});
            this.addDatasToolStripMenuItem1.Name = "addDatasToolStripMenuItem1";
            this.addDatasToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.addDatasToolStripMenuItem1.Text = "Settings";
            // 
            // datasToolStripMenuItem
            // 
            this.datasToolStripMenuItem.Name = "datasToolStripMenuItem";
            this.datasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.datasToolStripMenuItem.Text = "Datas";
            this.datasToolStripMenuItem.Click += new System.EventHandler(this.addDatasToolStripMenuItem1_Click);
            // 
            // launchersToolStripMenuItem
            // 
            this.launchersToolStripMenuItem.Name = "launchersToolStripMenuItem";
            this.launchersToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.launchersToolStripMenuItem.Text = "Launchers";
            this.launchersToolStripMenuItem.Click += new System.EventHandler(this.launchersToolStripMenuItem_Click);
            // 
            // gbLaunchers
            // 
            this.gbLaunchers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLaunchers.Controls.Add(this.btnLaunchDiscord);
            this.gbLaunchers.Controls.Add(this.btnLaunchA);
            this.gbLaunchers.Controls.Add(this.btnLaunchB);
            this.gbLaunchers.Controls.Add(this.btnLaunchC);
            this.gbLaunchers.Controls.Add(this.btnLaunchInstagram);
            this.gbLaunchers.Controls.Add(this.btnLaunchLinkedin);
            this.gbLaunchers.Controls.Add(this.btnLaunchReddit);
            this.gbLaunchers.Controls.Add(this.btnLaunchMedium);
            this.gbLaunchers.Controls.Add(this.btnLaunchBctTlk);
            this.gbLaunchers.Controls.Add(this.btnLaunchYoutube);
            this.gbLaunchers.Controls.Add(this.btnLaunchFacebook);
            this.gbLaunchers.Controls.Add(this.btnLaunchTwitter);
            this.gbLaunchers.Controls.Add(this.btnLaunchTelegram);
            this.gbLaunchers.Location = new System.Drawing.Point(5, 27);
            this.gbLaunchers.Name = "gbLaunchers";
            this.gbLaunchers.Size = new System.Drawing.Size(423, 52);
            this.gbLaunchers.TabIndex = 45;
            this.gbLaunchers.TabStop = false;
            this.gbLaunchers.Text = "Launchers";
            // 
            // btnLaunchDiscord
            // 
            this.btnLaunchDiscord.BackgroundImage = global::AirdropClipboarder.Properties.Resources.discord;
            this.btnLaunchDiscord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchDiscord.Enabled = false;
            this.btnLaunchDiscord.Location = new System.Drawing.Point(295, 19);
            this.btnLaunchDiscord.Name = "btnLaunchDiscord";
            this.btnLaunchDiscord.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchDiscord.TabIndex = 16;
            this.btnLaunchDiscord.UseVisualStyleBackColor = true;
            this.btnLaunchDiscord.Click += new System.EventHandler(this.btnLaunchDiscord_Click);
            // 
            // btnLaunchA
            // 
            this.btnLaunchA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunchA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchA.Enabled = false;
            this.btnLaunchA.Location = new System.Drawing.Point(327, 19);
            this.btnLaunchA.Name = "btnLaunchA";
            this.btnLaunchA.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchA.TabIndex = 15;
            this.btnLaunchA.Text = "A";
            this.btnLaunchA.UseVisualStyleBackColor = true;
            this.btnLaunchA.Click += new System.EventHandler(this.btnLaunchA_Click);
            // 
            // btnLaunchB
            // 
            this.btnLaunchB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunchB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchB.Enabled = false;
            this.btnLaunchB.Location = new System.Drawing.Point(359, 19);
            this.btnLaunchB.Name = "btnLaunchB";
            this.btnLaunchB.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchB.TabIndex = 14;
            this.btnLaunchB.Text = "B";
            this.btnLaunchB.UseVisualStyleBackColor = true;
            this.btnLaunchB.Click += new System.EventHandler(this.btnLaunchB_Click);
            // 
            // btnLaunchC
            // 
            this.btnLaunchC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunchC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchC.Enabled = false;
            this.btnLaunchC.Location = new System.Drawing.Point(391, 19);
            this.btnLaunchC.Name = "btnLaunchC";
            this.btnLaunchC.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchC.TabIndex = 13;
            this.btnLaunchC.Text = "C";
            this.btnLaunchC.UseVisualStyleBackColor = true;
            this.btnLaunchC.Click += new System.EventHandler(this.btnLaunchC_Click);
            // 
            // btnLaunchInstagram
            // 
            this.btnLaunchInstagram.BackgroundImage = global::AirdropClipboarder.Properties.Resources.instagram;
            this.btnLaunchInstagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchInstagram.Enabled = false;
            this.btnLaunchInstagram.Location = new System.Drawing.Point(263, 19);
            this.btnLaunchInstagram.Name = "btnLaunchInstagram";
            this.btnLaunchInstagram.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchInstagram.TabIndex = 12;
            this.btnLaunchInstagram.UseVisualStyleBackColor = true;
            this.btnLaunchInstagram.Click += new System.EventHandler(this.btnLaunchInstagram_Click);
            // 
            // btnLaunchLinkedin
            // 
            this.btnLaunchLinkedin.BackgroundImage = global::AirdropClipboarder.Properties.Resources.linkedin;
            this.btnLaunchLinkedin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchLinkedin.Enabled = false;
            this.btnLaunchLinkedin.Location = new System.Drawing.Point(231, 19);
            this.btnLaunchLinkedin.Name = "btnLaunchLinkedin";
            this.btnLaunchLinkedin.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchLinkedin.TabIndex = 11;
            this.btnLaunchLinkedin.UseVisualStyleBackColor = true;
            this.btnLaunchLinkedin.Click += new System.EventHandler(this.btnLaunchLinkedin_Click);
            // 
            // btnLaunchReddit
            // 
            this.btnLaunchReddit.BackgroundImage = global::AirdropClipboarder.Properties.Resources.reddit;
            this.btnLaunchReddit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchReddit.Enabled = false;
            this.btnLaunchReddit.Location = new System.Drawing.Point(199, 19);
            this.btnLaunchReddit.Name = "btnLaunchReddit";
            this.btnLaunchReddit.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchReddit.TabIndex = 10;
            this.btnLaunchReddit.UseVisualStyleBackColor = true;
            this.btnLaunchReddit.Click += new System.EventHandler(this.btnLaunchReddit_Click);
            // 
            // btnLaunchMedium
            // 
            this.btnLaunchMedium.BackgroundImage = global::AirdropClipboarder.Properties.Resources.Medium;
            this.btnLaunchMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchMedium.Enabled = false;
            this.btnLaunchMedium.Location = new System.Drawing.Point(167, 19);
            this.btnLaunchMedium.Name = "btnLaunchMedium";
            this.btnLaunchMedium.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchMedium.TabIndex = 9;
            this.btnLaunchMedium.UseVisualStyleBackColor = true;
            this.btnLaunchMedium.Click += new System.EventHandler(this.btnLaunchMedium_Click);
            // 
            // btnLaunchBctTlk
            // 
            this.btnLaunchBctTlk.BackgroundImage = global::AirdropClipboarder.Properties.Resources.BtcTlk;
            this.btnLaunchBctTlk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchBctTlk.Enabled = false;
            this.btnLaunchBctTlk.Location = new System.Drawing.Point(135, 19);
            this.btnLaunchBctTlk.Name = "btnLaunchBctTlk";
            this.btnLaunchBctTlk.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchBctTlk.TabIndex = 8;
            this.btnLaunchBctTlk.UseVisualStyleBackColor = true;
            this.btnLaunchBctTlk.Click += new System.EventHandler(this.btnLaunchBctTlk_Click);
            // 
            // btnLaunchYoutube
            // 
            this.btnLaunchYoutube.BackgroundImage = global::AirdropClipboarder.Properties.Resources.Youtube22x22;
            this.btnLaunchYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchYoutube.Enabled = false;
            this.btnLaunchYoutube.Location = new System.Drawing.Point(103, 19);
            this.btnLaunchYoutube.Name = "btnLaunchYoutube";
            this.btnLaunchYoutube.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchYoutube.TabIndex = 7;
            this.btnLaunchYoutube.UseVisualStyleBackColor = true;
            this.btnLaunchYoutube.Click += new System.EventHandler(this.btnLaunchYoutube_Click);
            // 
            // btnLaunchFacebook
            // 
            this.btnLaunchFacebook.BackgroundImage = global::AirdropClipboarder.Properties.Resources.Facebook22x22;
            this.btnLaunchFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchFacebook.Enabled = false;
            this.btnLaunchFacebook.Location = new System.Drawing.Point(71, 19);
            this.btnLaunchFacebook.Name = "btnLaunchFacebook";
            this.btnLaunchFacebook.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchFacebook.TabIndex = 6;
            this.btnLaunchFacebook.UseVisualStyleBackColor = true;
            this.btnLaunchFacebook.Click += new System.EventHandler(this.btnLaunchFacebook_Click);
            // 
            // btnLaunchTwitter
            // 
            this.btnLaunchTwitter.BackgroundImage = global::AirdropClipboarder.Properties.Resources.twitterlogo;
            this.btnLaunchTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchTwitter.Enabled = false;
            this.btnLaunchTwitter.Location = new System.Drawing.Point(39, 19);
            this.btnLaunchTwitter.Name = "btnLaunchTwitter";
            this.btnLaunchTwitter.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchTwitter.TabIndex = 5;
            this.btnLaunchTwitter.UseVisualStyleBackColor = true;
            this.btnLaunchTwitter.Click += new System.EventHandler(this.btnLaunchTwitter_Click);
            // 
            // btnLaunchTelegram
            // 
            this.btnLaunchTelegram.BackgroundImage = global::AirdropClipboarder.Properties.Resources.telegram;
            this.btnLaunchTelegram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunchTelegram.Enabled = false;
            this.btnLaunchTelegram.Location = new System.Drawing.Point(7, 19);
            this.btnLaunchTelegram.Name = "btnLaunchTelegram";
            this.btnLaunchTelegram.Size = new System.Drawing.Size(26, 26);
            this.btnLaunchTelegram.TabIndex = 2;
            this.btnLaunchTelegram.UseVisualStyleBackColor = true;
            this.btnLaunchTelegram.Click += new System.EventHandler(this.btnLaunchTelegram_Click);
            // 
            // AirdropClipboarderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 395);
            this.Controls.Add(this.gbLaunchers);
            this.Controls.Add(this.gbLogs);
            this.Controls.Add(this.gbDonation);
            this.Controls.Add(this.gbDatas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(451, 434);
            this.Name = "AirdropClipboarderMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airdrop Clipboarder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AirdopClipboarderMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AirdopClipboarderMain_FormClosed);
            this.Load += new System.EventHandler(this.AirdropClipboarderMain_Load);
            this.Shown += new System.EventHandler(this.AirdropClipboarderMain_Shown);
            this.gbDatas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).EndInit();
            this.gbDonation.ResumeLayout(false);
            this.gbDonation.PerformLayout();
            this.gbLogs.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbLaunchers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatas;
        private System.Windows.Forms.GroupBox gbDonation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBTC;
        private System.Windows.Forms.TextBox tbETH;
        private System.Windows.Forms.TextBox tbBTC;
        private System.Windows.Forms.Label lblETH;
        private System.Windows.Forms.Label lblBTC;
        private System.Windows.Forms.DataGridView dgvDatas;
        private System.Windows.Forms.GroupBox gbLogs;
        private System.Windows.Forms.RichTextBox logsRTB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addDatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDatasToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathClient;
        private System.Windows.Forms.GroupBox gbLaunchers;
        private System.Windows.Forms.Button btnLaunchTelegram;
        private System.Windows.Forms.Button btnLaunchFacebook;
        private System.Windows.Forms.Button btnLaunchTwitter;
        private System.Windows.Forms.Button btnLaunchYoutube;
        private System.Windows.Forms.Button btnLaunchBctTlk;
        private System.Windows.Forms.Button btnLaunchMedium;
        private System.Windows.Forms.Button btnLaunchReddit;
        private System.Windows.Forms.Button btnLaunchLinkedin;
        private System.Windows.Forms.Button btnLaunchInstagram;
        private System.Windows.Forms.Button btngitHub;
        private System.Windows.Forms.Button btnTwitter;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Button btnYoutube;
        private System.Windows.Forms.Button btnWWW;
        private System.Windows.Forms.Button btnLaunchA;
        private System.Windows.Forms.Button btnLaunchB;
        private System.Windows.Forms.Button btnLaunchC;
        private System.Windows.Forms.ToolStripMenuItem datasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchersToolStripMenuItem;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Button btnLaunchDiscord;
    }
}

