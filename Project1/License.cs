using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class License : UserControl
    {
        public MainWindow mainControl { get; set; }

        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleDataReader reader;

        public P_information P_info { get; set; }

        public License()
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
                    cmd.CommandText = "select * from thrm_lic_ljm where lic_empno = " + empno;
                    adapter.SelectCommand = cmd;
                    try
                    {
                        OracleCommandBuilder cb = new OracleCommandBuilder(adapter);
                        adapter.Update(ds, "Info");
                        dataGridView6.DataSource = ds.Tables["Info"];
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
                foreach (DataGridViewRow item in this.dataGridView6.SelectedRows)
                {
                    dataGridView6.Rows.RemoveAt(item.Index);
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
                empno = P_info.Empno;
                string user = P_info.User;
                dataGridView6.DataSource = ds.Tables["Info"];
                ds.Tables["Info"].Rows.Add(empno, "", "", "", "", DateTime.Now, "A", user);

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
                        cmd.CommandText = "select cd_code, cd_codnms from tieas_cd_ljm where cd_grpcd='LIC' and cd_use = 'Y'";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Code");
                        empno = P_info.Empno;
                        cmd.CommandText = "select * from thrm_lic_ljm where lic_empno = " + empno;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Info");
                        dataGridView6.DataSource = ds.Tables["Info"];
                        this.dataGridView6.Columns["LIC_EMPNO"].Visible = false;
                        this.dataGridView6.Columns["LIC_GRADE"].HeaderText = "급수";
                        this.dataGridView6.Columns["LIC_ACQDATE"].HeaderText = "취득일";
                        this.dataGridView6.Columns["LIC_ORGAN"].HeaderText = "발급기관";
                        ((DataGridViewTextBoxColumn)dataGridView6.Columns["LIC_ACQDATE"]).MaxInputLength = 8;
                        this.dataGridView6.Columns["DATASYS1"].Visible = false;
                        this.dataGridView6.Columns["DATASYS2"].Visible = false;
                        this.dataGridView6.Columns["DATASYS3"].Visible = false;
                        dataGridView6.Columns.Remove("LIC_CODE");
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
                col.DataPropertyName = "LIC_CODE";
                col.FlatStyle = FlatStyle.Flat;
            }
            col.DataSource = ds.Tables["Code"];
            col.DisplayMember = "CD_CODNMS";
            col.ValueMember = "CD_CODE";
            col.HeaderText = "자격면허코드";
            dataGridView6.Columns.Insert(1, col);
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
