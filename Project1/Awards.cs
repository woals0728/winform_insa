using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class Awards : UserControl
    {
        public MainWindow mainControl { get; set; }

        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();

        public P_information P_info { get; set; }
        public Awards()
        {
            InitializeComponent();
        }

        public string empno;

        private void save_button_Click(object sender, EventArgs e)
        {
            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    OracleTransaction tran = dBManager.Connection.BeginTransaction();
                    cmd.Transaction = tran;
                    cmd.Connection = dBManager.Connection;

                    empno = P_info.Empno;
                    cmd.CommandText = "select * from thrm_award_ljm where award_empno = " + empno;
                    adapter.SelectCommand = cmd;
                    try
                    {
                        OracleCommandBuilder cb = new OracleCommandBuilder(adapter);
                        adapter.Update(ds, "Info");
                        dataGridView4.DataSource = ds.Tables["Info"];
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

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 정보를 삭제 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView4.SelectedRows)
                {
                    dataGridView4.Rows.RemoveAt(item.Index);
                }
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
                string user = P_info.User;
                empno = P_info.Empno;
                dataGridView4.DataSource = ds.Tables["Info"];
                ds.Tables["Info"].Rows.Add(empno, "", "", "", "", "", "", "", "", "", DateTime.Now, "A", user);
            }
            catch
            {
            }
        }

        public void DataLoad()
        {
            try
            {
                if (empno == P_info.Empno)
                {
                    return;
                }
                if (dBManager.GetConnection() == true)
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        ds.Clear();
                        cmd.Connection = dBManager.Connection;
                        empno = P_info.Empno;
                        cmd.CommandText = "select dept_code, dept_name from thrm_dept_ljm";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Dept");
                        cmd.CommandText = "select cd_code, cd_codnms from tieas_cd_ljm where cd_grpcd='POS' and cd_use = 'Y'";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Code");
                        cmd.CommandText = "select * from thrm_award_ljm where award_empno = " + empno;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Info");
                        dataGridView4.DataSource = ds.Tables["Info"];
                        this.dataGridView4.Columns["AWARD_EMPNO"].Visible = false;
                        this.dataGridView4.Columns["AWARD_DATE"].HeaderText = "상벌일자";
                        this.dataGridView4.Columns["AWARD_NO"].HeaderText = "상벌번호";
                        this.dataGridView4.Columns["AWARD_KIND"].HeaderText = "상벌종별";
                        this.dataGridView4.Columns["AWARD_ORGAN"].HeaderText = "시행처";
                        this.dataGridView4.Columns["AWARD_CONTENT"].HeaderText = "상벌내용";
                        ((DataGridViewTextBoxColumn)dataGridView4.Columns["AWARD_DATE"]).MaxInputLength = 8;
                        this.dataGridView4.Columns["DATASYS1"].Visible = false;
                        this.dataGridView4.Columns["DATASYS2"].Visible = false;
                        this.dataGridView4.Columns["DATASYS3"].Visible = false;
                        dataGridView4.Columns.Remove("AWARD_TYPE");
                        dataGridView4.Columns.Remove("AWARD_INOUT");
                        dataGridView4.Columns.Remove("AWARD_POS");
                        dataGridView4.Columns.Remove("AWARD_DEPT");
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
                col.DataPropertyName = "AWARD_TYPE";
                col.FlatStyle = FlatStyle.Flat;
            }
            DataGridViewComboBoxColumn col2 = new DataGridViewComboBoxColumn();
            {
                col2.DataPropertyName = "AWARD_INOUT";
                col2.FlatStyle = FlatStyle.Flat;
            }
            DataGridViewComboBoxColumn col3 = new DataGridViewComboBoxColumn();
            {
                col3.DataPropertyName = "AWARD_POS";
                col3.FlatStyle = FlatStyle.Flat;
            }
            DataGridViewComboBoxColumn col4 = new DataGridViewComboBoxColumn();
            {
                col4.DataPropertyName = "AWARD_DEPT";
                col4.FlatStyle = FlatStyle.Flat;
            }
            col.Items.Add("상");
            col.Items.Add("벌");
            col.HeaderText = "상벌구분";
            col2.Items.Add("내부");
            col2.Items.Add("외부");
            col2.HeaderText = "내외구분";
            col3.DataSource = ds.Tables["Code"];
            col3.DisplayMember = "CD_CODNMS";
            col3.ValueMember = "CD_CODE";
            col3.HeaderText = "직급(당시)";
            col4.DataSource = ds.Tables["Dept"];
            col4.DisplayMember = "DEPT_NAME";
            col4.ValueMember = "DEPT_CODE";
            col4.HeaderText = "소속(당시)";
            dataGridView4.Columns.Insert(2, col);
            dataGridView4.Columns.Insert(7, col2);
            dataGridView4.Columns.Insert(8, col3);
            dataGridView4.Columns.Insert(9, col4);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("작성중인 사항을 저장하지 않고 취소하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                empno = "";
                DataLoad();
            }
            else
            {
                return;
            }
        }
    }
}
