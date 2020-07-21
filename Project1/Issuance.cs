using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class Issuance : UserControl
    {
        OracleDBManager dBManager = new OracleDBManager();
        OracleDataReader reader;
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();
        public Issuance()
        {
            InitializeComponent();
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
                        cmd.CommandText = "select ceri_empno as 사원번호, ceri_kind as 증명서종류, " +
                            "'BSKS' || '-' || substr(ceri_date, 1, 4) || '-' || lpad(ceri_no, 3, '0') as 증명서일련번호, ceri_date as 발급일자," +
                            "ceri_lang as 발급언어, ceri_cnt as 발급부수 from thrm_ceri_ljm order by ceri_no";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Info");
                        dataGridView2.DataSource = ds.Tables["Info"];
                    }
                }
            }
            catch
            {

            }
        }

        private void Issuance_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
