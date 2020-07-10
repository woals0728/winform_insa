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

        public Family()
        {
            InitializeComponent();
        }

        private void fam_save_button_Click(object sender, EventArgs e)
        {
            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    OracleTransaction tran = dBManager.Connection.BeginTransaction();
                    cmd.Transaction = tran;
                    cmd.Connection = dBManager.Connection;
                    

                    //cmd.CommandText = "update FAMILY_LJM set fam_empno = '10001'";
                    //cmd.CommandText = "select * from FAMILY_LJM";
                    //adapter.SelectCommand = cmd;
                    //adapter.Fill(ds);
                    //dataGridView2.DataSource = ds.Tables[0];
                    try
                    {
                        //adapter.UpdateCommand = cmd;
                        adapter.UpdateCommand = new OracleCommand();
                        OracleCommandBuilder cb = new OracleCommandBuilder(adapter);
                        adapter.Update(ds);
                        dataGridView2.DataSource = ds.Tables[0];
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
            DataLoad();
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
                dataGridView2.DataSource = ds.Tables[0];
                ds.Tables[0].Rows.Add("10001", "", "", "4", "5");
            }
            catch
            {
                MessageBox.Show("마지막 행을 작성후 추가해 주십시오.");
            }
        }

        private void DataLoad()
        {
            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = dBManager.Connection;

                    cmd.CommandText = "select * from FAMILY_LJM";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void insert_button()
        {
            MessageBox.Show("가족사항");
        }


        public void cancel_button()
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
