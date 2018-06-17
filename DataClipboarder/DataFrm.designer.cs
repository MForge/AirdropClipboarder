namespace AirdropClipboarder
{
    partial class DataFrm
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
            this.lblMinerPath = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblMinerName = new System.Windows.Forms.Label();
            this.saveAndClosebtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblMinerPath
            // 
            this.lblMinerPath.AutoSize = true;
            this.lblMinerPath.BackColor = System.Drawing.Color.Transparent;
            this.lblMinerPath.ForeColor = System.Drawing.Color.Black;
            this.lblMinerPath.Location = new System.Drawing.Point(12, 9);
            this.lblMinerPath.Name = "lblMinerPath";
            this.lblMinerPath.Size = new System.Drawing.Size(36, 13);
            this.lblMinerPath.TabIndex = 3;
            this.lblMinerPath.Text = "Data :";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(116, 53);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(277, 20);
            this.tbDescription.TabIndex = 1;
            // 
            // lblMinerName
            // 
            this.lblMinerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMinerName.AutoSize = true;
            this.lblMinerName.BackColor = System.Drawing.Color.Transparent;
            this.lblMinerName.ForeColor = System.Drawing.Color.Black;
            this.lblMinerName.Location = new System.Drawing.Point(12, 56);
            this.lblMinerName.Name = "lblMinerName";
            this.lblMinerName.Size = new System.Drawing.Size(66, 13);
            this.lblMinerName.TabIndex = 6;
            this.lblMinerName.Text = "Description :";
            // 
            // saveAndClosebtn
            // 
            this.saveAndClosebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAndClosebtn.BackgroundImage = global::AirdropClipboarder.Properties.Resources.save;
            this.saveAndClosebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveAndClosebtn.Location = new System.Drawing.Point(230, 79);
            this.saveAndClosebtn.Name = "saveAndClosebtn";
            this.saveAndClosebtn.Size = new System.Drawing.Size(94, 23);
            this.saveAndClosebtn.TabIndex = 2;
            this.saveAndClosebtn.Text = "Save && Close";
            this.saveAndClosebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveAndClosebtn.UseVisualStyleBackColor = true;
            this.saveAndClosebtn.Click += new System.EventHandler(this.saveAndclosebtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackgroundImage = global::AirdropClipboarder.Properties.Resources.cancel;
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelBtn.Location = new System.Drawing.Point(330, 79);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(63, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // rtbData
            // 
            this.rtbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbData.Location = new System.Drawing.Point(116, 6);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(277, 41);
            this.rtbData.TabIndex = 0;
            this.rtbData.Text = "";
            // 
            // DataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 108);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.saveAndClosebtn);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblMinerName);
            this.Controls.Add(this.lblMinerPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMinerPath;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblMinerName;
        private System.Windows.Forms.Button saveAndClosebtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.RichTextBox rtbData;
    }
}