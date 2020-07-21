using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class Code_info : UserControl
    {

        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        OracleDataReader reader;

        public Code_info()
        {
            InitializeComponent();
        }

        private void Code_info_Load(object sender, EventArgs e)
        {
            codeCombobox();
            DataLoad();
        }

        public string user;

        public void submit_button()
        {
            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    OracleTransaction tran = dBManager.Connection.BeginTransaction();
                    cmd.Transaction = tran;
                    cmd.Connection = dBManager.Connection;

                    cmd.CommandText = "select * from tieas_cd_ljm where cd_grpcd = " + comboBox1.Text;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataLoad();
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = ds.Tables["Info"];
                ds.Tables["Info"].Rows.Add(comboBox1.Text, "", 1, "", "", "", "", "Y", DateTime.Now.ToString("yyyyMMdd"), "", DateTime.Now, "A", user);
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
                        cmd.CommandText = "select * from tieas_cd_ljm where cd_grpcd = '" + comboBox1.SelectedValue.ToString() + "' order by cast(cd_code as number)";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Info");
                        dataGridView2.DataSource = ds.Tables["Info"];
                        this.dataGridView2.Columns["CD_GRPCD"].Visible = false;
                        this.dataGridView2.Columns["CD_CODE"].HeaderText = "코드";
                        this.dataGridView2.Columns["CD_SEQ"].HeaderText = "코드 Seq";
                        this.dataGridView2.Columns["CD_CODNMS"].HeaderText = "코드명(축약)";
                        this.dataGridView2.Columns["CD_CODNM"].HeaderText = "코드명(원형)";
                        this.dataGridView2.Columns["CD_ADDINFO"].HeaderText = "추가정보";
                        this.dataGridView2.Columns["CD_UPPER"].HeaderText = "상위분류";
                        this.dataGridView2.Columns["CD_SDATE"].HeaderText = "생성일자";
                        this.dataGridView2.Columns["CD_EDATE"].HeaderText = "폐기일자";
                        this.dataGridView2.Columns["DATASYS1"].Visible = false;
                        this.dataGridView2.Columns["DATASYS2"].Visible = false;
                        this.dataGridView2.Columns["DATASYS3"].Visible = false;
                        dataGridView2.Columns.Remove("CD_USE");
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
            DataGridViewComboBoxColumn col2 = new DataGridViewComboBoxColumn();
            {
                col2.DataPropertyName = "CD_USE";
                col2.FlatStyle = FlatStyle.Flat;
            }
            col2.Items.Add("Y");
            col2.Items.Add("N");
            col2.HeaderText = "사용여부";
            dataGridView2.Columns.Insert(7, col2);
        }

        private void codeCombobox()
        {
            try
            {
                if (dBManager.GetConnection() == true)
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        ds2.Clear();
                        cmd.Connection = dBManager.Connection;
                        cmd.CommandText = "select * from tieas_cdg_ljm";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds2, "Code");
                        comboBox1.DataSource = ds2.Tables["Code"];
                        comboBox1.DisplayMember = "CDG_GRPNM";
                        comboBox1.ValueMember = "CDG_GRPCD";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
