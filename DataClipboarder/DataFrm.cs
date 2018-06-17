using System;
using System.Windows.Forms;

namespace AirdropClipboarder
{
    public partial class DataFrm : Form
    {
        private Data m_data;
        private bool m_dataAdded;
        private bool m_dataEdited;
        private bool editMode;
        private DataList m_DataList;
        private string oldName;
        private string oldDescription;

        public DataFrm(DataList aMinerList)
        {
            InitializeComponent();
            m_dataAdded = false;
            m_dataEdited = false;
            m_DataList = aMinerList;
            editMode = false;
        }

        public DataFrm(string aMyData, string aDescription, DataList aDataList)
        {
            InitializeComponent();
            m_dataAdded = false;
            m_dataEdited = false;
            m_DataList = aDataList;
            oldName = rtbData.Text = aMyData;
            oldDescription = tbDescription.Text = aDescription;

            if (aMyData != "" && aDescription != "")
            {
                editMode = true;
            }
            else
            {
                editMode = false;
            }
        }

        internal Data MyData
        {
            get
            {
                return m_data;
            }

            set
            {
                m_data = value;
            }
        }

        public bool MinerAdded
        {
            get
            {
                return m_dataAdded;
            }

            set
            {
                m_dataAdded = value;
            }
        }

        public bool MinerEdited
        {
            get
            {
                return m_dataEdited;
            }

            set
            {
                m_dataEdited = value;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAndclosebtn_Click(object sender, EventArgs e)
        {
            if (rtbData.Text == "")
            {
                MessageBox.Show("Please initialize data field.", "Airdrop Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tbDescription.Text == "")
            {
                MessageBox.Show("Please give a description to your data", "Airdrop Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (editMode)
            {
                foreach (Data cd in m_DataList)
                {
                    if (cd.MyData == oldName && cd.Description == oldDescription)
                    {
                        cd.MyData = rtbData.Text;
                        cd.Description = tbDescription.Text;
                        m_dataEdited = true;
                        break;
                    }
                }
                this.Close();
            }
            else
            {
                m_data = new Data(rtbData.Text, tbDescription.Text);
                m_dataAdded = true;
                this.Close();
            }
        }
    }
}