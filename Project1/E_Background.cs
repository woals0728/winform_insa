using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class E_Background : UserControl
    {
        public MainWindow mainControl { get; set; }

        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();

        public P_information P_info { get; set; }

        public E_Background()
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
                    cmd.CommandText = "select * from thrm_edu_ljm where edu_empno = " + empno;
                    adapter.SelectCommand = cmd;
                    try
                    {
                        OracleCommandBuilder cb = new OracleCommandBuilder(adapter);
                        adapter.Update(ds, "Info");
                        dataGridView3.DataSource = ds.Tables["Info"];
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
                foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
                {
                    dataGridView3.Rows.RemoveAt(item.Index);
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
                dataGridView3.DataSource = ds.Tables["Info"];
                ds.Tables["Info"].Rows.Add(empno, "", "", "", "", "", "", 0, "", "Y", DateTime.Now, "A", user);
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
                        cmd.CommandText = "select * from thrm_edu_ljm where edu_empno = " + empno;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Info");
                        dataGridView3.DataSource = ds.Tables["Info"];
                        this.dataGridView3.Columns["EDU_EMPNO"].Visible = false;
                        this.dataGridView3.Columns["EDU_SCHNM"].HeaderText = "학교명";
                        this.dataGridView3.Columns["EDU_DEPT"].HeaderText = "학과(전공)";
                        this.dataGridView3.Columns["EDU_GRADE"].HeaderText = "성적";
                        this.dataGridView3.Columns["EDU_ENTDATE"].HeaderText = "입학일자";
                        this.dataGridView3.Columns["EDU_GRADATE"].HeaderText = "졸업일자";
                        ((DataGridViewTextBoxColumn)dataGridView3.Columns["EDU_ENTDATE"]).MaxInputLength = 8;
                        ((DataGridViewTextBoxColumn)dataGridView3.Columns["EDU_GRADATE"]).MaxInputLength = 8;
                        this.dataGridView3.Columns["DATASYS1"].Visible = false;
                        this.dataGridView3.Columns["DATASYS2"].Visible = false;
                        this.dataGridView3.Columns["DATASYS3"].Visible = false;
                        dataGridView3.Columns.Remove("EDU_LOE");
                        dataGridView3.Columns.Remove("EDU_DEGREE");
                        dataGridView3.Columns.Remove("EDU_GRA");
                        dataGridView3.Columns.Remove("EDU_LAST");
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
                col.DataPropertyName = "EDU_LOE";
                col.FlatStyle = FlatStyle.Flat;
            }
            DataGridViewComboBoxColumn col2 = new DataGridViewComboBoxColumn();
            {
                col2.DataPropertyName = "EDU_DEGREE";
                col2.FlatStyle = FlatStyle.Flat;
            }
            DataGridViewComboBoxColumn col3 = new DataGridViewComboBoxColumn();
            {
                col3.DataPropertyName = "EDU_GRA";
                col3.FlatStyle = FlatStyle.Flat;
            }
            DataGridViewComboBoxColumn col4 = new DataGridViewComboBoxColumn();
            {
                col4.DataPropertyName = "EDU_LAST";
                col4.FlatStyle = FlatStyle.Flat;
            }
            col.Items.Add("고등학교");
            col.Items.Add("전문대");
            col.Items.Add("대학교");
            col.Items.Add("대학원");
            col.HeaderText = "학력구분";
            col2.Items.Add("전문학사");
            col2.Items.Add("학사");
            col2.Items.Add("석사");
            col2.Items.Add("박사");
            col2.HeaderText = "학위";
            col3.Items.Add("졸업");
            col3.Items.Add("수료");
            col3.Items.Add("재학");
            col3.HeaderText = "졸업구분";
            col4.Items.Add("Y");
            col4.Items.Add("N");
            col4.HeaderText = "최종여부";
            dataGridView3.Columns.Insert(1, col);
            dataGridView3.Columns.Insert(6, col2);
            dataGridView3.Columns.Insert(8, col3);
            dataGridView3.Columns.Insert(9, col4);
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
