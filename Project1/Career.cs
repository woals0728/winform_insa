using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class Career : UserControl
    {
        public MainWindow mainControl { get; set; }

        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();

        public P_information P_info { get; set; }

        public Career()
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
                    cmd.CommandText = "select * from thrm_car_ljm where car_empno = " + empno;
                    adapter.SelectCommand = cmd;
                    try
                    {
                        OracleCommandBuilder cb = new OracleCommandBuilder(adapter);
                        adapter.Update(ds, "Info");
                        dataGridView5.DataSource = ds.Tables["Info"];
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
                foreach (DataGridViewRow item in this.dataGridView5.SelectedRows)
                {
                    dataGridView5.Rows.RemoveAt(item.Index);
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
                dataGridView5.DataSource = ds.Tables["Info"];
                ds.Tables["Info"].Rows.Add(empno, "", "", "", "", "", "", "", "", DateTime.Now, "A", user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        cmd.CommandText = "select * from thrm_car_ljm where car_empno = " + empno;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Info");
                        dataGridView5.DataSource = ds.Tables["Info"];
                        this.dataGridView5.Columns["CAR_EMPNO"].Visible = false;
                        this.dataGridView5.Columns["CAR_COM"].HeaderText = "근무처명";
                        this.dataGridView5.Columns["CAR_REGION"].HeaderText = "소재지";
                        this.dataGridView5.Columns["CAR_YYYYMM_F"].HeaderText = "근무시작월";
                        this.dataGridView5.Columns["CAR_YYYYMM_T"].HeaderText = "근무종료월";
                        this.dataGridView5.Columns["CAR_POS"].HeaderText = "최종직급";
                        this.dataGridView5.Columns["CAR_DEPT"].HeaderText = "담당부서";
                        this.dataGridView5.Columns["CAR_JOB"].HeaderText = "담당업무";
                        this.dataGridView5.Columns["CAR_REASON"].HeaderText = "퇴직/이직사유";
                        ((DataGridViewTextBoxColumn)dataGridView5.Columns["CAR_YYYYMM_F"]).MaxInputLength = 6;
                        ((DataGridViewTextBoxColumn)dataGridView5.Columns["CAR_YYYYMM_T"]).MaxInputLength = 6;
                        this.dataGridView5.Columns["DATASYS1"].Visible = false;
                        this.dataGridView5.Columns["DATASYS2"].Visible = false;
                        this.dataGridView5.Columns["DATASYS3"].Visible = false;
                    }
                }
            }
            catch
            {
            }
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
