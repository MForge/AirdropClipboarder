using System;
using System.Drawing;
using System.Windows.Forms;

namespace AirdropClipboarder
{
    public partial class DataListFrm : Form
    {
        private Settings m_settings;
        private Boolean isOrderchanged = false;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public DataListFrm(Settings aSettings, bool forceAdd = false)
        {
            InitializeComponent();

            m_settings = aSettings;

            if (forceAdd)
            {
                addNewData();
            }

            showDatas();
        }

        private void showDatas()
        {
            dgvDatas2.Rows.Clear();
            dgvDatas2.Refresh();

            int datasCount = m_settings.MyDataList.count();

            foreach (Data m in m_settings.MyDataList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDatas2, m.MyData, m.Description);
                dgvDatas2.Rows.Add(row);
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewData(string aMyData = "", string aDescription = "")
        {
            DataFrm newDataFrm = new DataFrm(aMyData, aDescription, m_settings.MyDataList);
            newDataFrm.ShowDialog();
            if (newDataFrm.MinerAdded)
            {
                m_settings.MyDataList.add(newDataFrm.MyData);
                showDatas();
            }
            else if (newDataFrm.MinerEdited)
            {
                showDatas();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add
            addNewData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Edit
            addNewData(dgvDatas2.Rows[dgvDatas2.CurrentCell.RowIndex].Cells[0].Value.ToString(), dgvDatas2.Rows[dgvDatas2.CurrentCell.RowIndex].Cells[1].Value.ToString());
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Dell
            DialogResult frwInstall = MessageBox.Show("Do you realy want to delete this data (" + dgvDatas2.Rows[dgvDatas2.CurrentCell.RowIndex].Cells[0].Value.ToString() + ") ?", "Airdrop Clipboarder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (frwInstall == DialogResult.Yes)
            {
                m_settings.MyDataList.delete(dgvDatas2.Rows[dgvDatas2.CurrentCell.RowIndex].Cells[0].Value.ToString(), dgvDatas2.Rows[dgvDatas2.CurrentCell.RowIndex].Cells[1].Value.ToString());
                showDatas();
            }
        }

        private void dgvDatas2_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dgvDatas2.PointToClient(new Point(e.X, e.Y));
            rowIndexOfItemUnderMouseToDrop = dgvDatas2.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                if ((rowIndexFromMouseDown != -1) && (rowIndexOfItemUnderMouseToDrop != -1) )
                {
                    dgvDatas2.Rows.RemoveAt(rowIndexFromMouseDown);
                    dgvDatas2.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                    isOrderchanged = true;
                }
            }
        }

        private void dgvDatas2_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {              
                    DragDropEffects dropEffect = dgvDatas2.DoDragDrop(dgvDatas2.Rows[rowIndexFromMouseDown],DragDropEffects.Move);
                }
            }
        }

        private void dgvDatas2_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dgvDatas2.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {              
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(
                          new Point(
                            e.X - (dragSize.Width / 2),
                            e.Y - (dragSize.Height / 2)),
                      dragSize);
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dgvDatas2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void reloadDatas()
        {
            m_settings.MyDataList.clear();

            foreach (DataGridViewRow rw in dgvDatas2.Rows)
            {
                Data aData = new Data(rw.Cells[0].Value.ToString(), rw.Cells[1].Value.ToString());
                m_settings.MyDataList.add(aData);
            }
        }

        private void DataListFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isOrderchanged)
            {
                DialogResult frwInstall = MessageBox.Show(@"The datas order has changed, do you want to save it ?", "Airdrop Clipboarder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (frwInstall == DialogResult.Yes)
                {
                    reloadDatas();
                }
            }
        }
    }
}