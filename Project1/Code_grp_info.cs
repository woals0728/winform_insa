using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class Code_grp_info : UserControl
    {
        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleDataReader reader;
        public Code_grp_info()
        {
            InitializeComponent();
        }


        public void submit_button()
        {
            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    OracleTransaction tran = dBManager.Connection.BeginTransaction();
                    cmd.Transaction = tran;
                    cmd.Connection = dBManager.Connection;

                    cmd.CommandText = "select * from tieas_cdg_ljm where cdg_kind like '%" + comboboxValue + "%'";
                    adapter.SelectCommand = cmd;
                    try
                    {
                        OracleCommandBuilder cb = new OracleCommandBuilder(adapter);
                        adapter.Update(ds, "Info");
                        dataGridView2.DataSource = ds.Tables["Info"];
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        tran.Rollback();
                    }

                }
            }
        }

        public void cancel_button()
        {
            if (MessageBox.Show("작성중인 사항을 저장하지 않고 취소하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataLoad();
            }
            else
            {
                return;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = ds.Tables["Info"];
                ds.Tables["Info"].Rows.Add("", "", 0, 0, "Y", comboboxValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 정보를 삭제 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                {
                    dataGridView2.Rows.RemoveAt(item.Index);
                }
            }
            else
            {
                return;
            }
        }

        public void DataLoad()
        {
            try
            {
                if (dBManager.GetConnection() == true)
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        ds.Clear();
                        cmd.Connection = dBManager.Connection;
                        cmd.CommandText = "select * from tieas_cdg_ljm where cdg_kind like '%" + comboboxValue + "%'";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Info");
                        dataGridView2.DataSource = ds.Tables["Info"];
                        this.dataGridView2.Columns["CDG_GRPCD"].HeaderText = "그룹코드";
                        this.dataGridView2.Columns["CDG_GRPNM"].HeaderText = "그룹코드명";
                        this.dataGridView2.Columns["CDG_DIGIT"].HeaderText = "단위코드 자리수";
                        this.dataGridView2.Columns["CDG_LENGTH"].HeaderText = "단위코드명(원형) 길이";
                        dataGridView2.Columns.Remove("CDG_USE");
                        dataGridView2.Columns.Remove("CDG_KIND");
                        AddComboBoxColumns();
                    }
                }
            }
            catch
            {
            }
        }

        private void AddComboBoxColumns()
        {
            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            {
                col.DataPropertyName = "CDG_USE";
                col.FlatStyle = FlatStyle.Flat;
            }
            DataGridViewComboBoxColumn col2 = new DataGridViewComboBoxColumn();
            {
                col2.DataPropertyName = "CDG_KIND";
                col2.FlatStyle = FlatStyle.Flat;
            }
            col.Items.Add("Y");
            col.Items.Add("N");
            col.HeaderText = "사용여부";
            col2.Items.Add("학사행정");
            col2.Items.Add("일반행정");
            col2.HeaderText = "분류";
            dataGridView2.Columns.Insert(4, col);
            dataGridView2.Columns.Insert(5, col2);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public string comboboxValue;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "선택" || comboBox1.Text == "전체")
            {
                comboboxValue = "";
            }
            else
            {
                comboboxValue = comboBox1.Text;
            }
            DataLoad();
        }

        private void Code_grp_info_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
