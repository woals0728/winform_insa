using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class Family : UserControl
    {
        public MainWindow mainControl { get; set; }

        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleDataReader reader;

        public P_information P_info { get; set; }

        public Family()
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
                    cmd.CommandText = "select * from thrm_fam_ljm where fam_empno = " + empno;
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

        private void Family_Load(object sender, EventArgs e)
        {

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

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                empno = P_info.Empno;
                string user = P_info.User;
                dataGridView2.DataSource = ds.Tables["Info"];
                ds.Tables["Info"].Rows.Add(empno, "", "", "", "Y", DateTime.Now, "A", user);

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
                        cmd.CommandText = "select cd_code, cd_codnms from tieas_cd_ljm where cd_grpcd='REL' and cd_use = 'Y'";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Code");
                        empno = P_info.Empno;
                        cmd.CommandText = "select * from thrm_fam_ljm where fam_empno = " + empno;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Info");
                        dataGridView2.DataSource = ds.Tables["Info"];
                        this.dataGridView2.Columns["FAM_EMPNO"].Visible = false;
                        this.dataGridView2.Columns["FAM_NAME"].HeaderText = "성명";
                        this.dataGridView2.Columns["FAM_BTH"].HeaderText = "생년월일";
                        this.dataGridView2.Columns["DATASYS1"].Visible = false;
                        this.dataGridView2.Columns["DATASYS2"].Visible = false;
                        this.dataGridView2.Columns["DATASYS3"].Visible = false;
                        dataGridView2.Columns.Remove("FAM_REL");
                        dataGridView2.Columns.Remove("FAM_LTG");
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
                col.DataPropertyName = "FAM_REL";
                col.FlatStyle = FlatStyle.Flat;
            }
            DataGridViewComboBoxColumn col2 = new DataGridViewComboBoxColumn();
            {
                col2.DataPropertyName = "FAM_LTG";
                col2.FlatStyle = FlatStyle.Flat;
            }
            col.DataSource = ds.Tables["Code"];
            col.DisplayMember = "CD_CODNMS";
            col.ValueMember = "CD_CODE";
            col.HeaderText = "관계";
            col2.Items.Add("Y");
            col2.Items.Add("N");
            col2.HeaderText = "동거여부";
            dataGridView2.Columns.Insert(1, col);
            dataGridView2.Columns.Insert(4, col2);
        }


        public void insert_button()
        {
            MessageBox.Show("가족사항");
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
