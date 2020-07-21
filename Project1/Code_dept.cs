using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class Code_dept : UserControl
    {
        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleDataReader reader;
        public Code_dept()
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

                    cmd.CommandText = "select * from thrm_dept_ljm order by cast(dept_code as number)";
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
        public string user;
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
                ds.Tables["Info"].Rows.Add("", "", "", "", "", "", DateTime.Now.ToString("yyyyMMdd"), "", DateTime.Now, 'A', user);
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
                        cmd.CommandText = "select dept_code, dept_name from thrm_dept_ljm order by cast(dept_code as number)";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Code");
                        cmd.CommandText = "select * from thrm_dept_ljm order by cast(dept_code as number)";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Info");
                        dataGridView2.DataSource = ds.Tables["Info"];
                        this.dataGridView2.Columns["DEPT_CODE"].HeaderText = "부서코드";
                        this.dataGridView2.Columns["DEPT_NAME"].HeaderText = "부서명칭";
                        this.dataGridView2.Columns["DEPT_NAMES"].HeaderText = "직책명";
                        this.dataGridView2.Columns["DEPT_SEQ"].HeaderText = "부서SEQ";
                        this.dataGridView2.Columns["DEPT_DEPT"].HeaderText = "학과코드";
                        this.dataGridView2.Columns["DEPT_SDATE"].HeaderText = "생성일자";
                        this.dataGridView2.Columns["DEPT_EDATE"].HeaderText = "폐기일자";
                        this.dataGridView2.Columns["DATASYS1"].Visible = false;
                        this.dataGridView2.Columns["DATASYS2"].Visible = false;
                        this.dataGridView2.Columns["DATASYS3"].Visible = false;
                        dataGridView2.Columns.Remove("DEPT_UPP");
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
                col.DataPropertyName = "DEPT_UPP";
                col.FlatStyle = FlatStyle.Flat;
            }
            col.DataSource = ds.Tables["Code"];
            col.DisplayMember = "dept_name";
            col.ValueMember = "dept_code";
            col.HeaderText = "상위부서코드";
            dataGridView2.Columns.Insert(4, col);
        }

        private void Code_dept_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
