using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class Information : UserControl
    {
        OracleDBManager dBManager = new OracleDBManager();
        public MainWindow mainControl { get; set; }

        OracleCommand cmd;
        OracleDataReader reader;
        OracleDataAdapter adapter;
        DataSet ds = new DataSet();
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = dBManager.Connection;

                    cmd.CommandText = "select CD_CODE || ':' || CD_CODNMS, cd_codnms, cd_grpcd from tieas_cd_ljm";
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetString(2) == "POS")
                        {
                            bas_pos.Items.Add(reader.GetString(0));
                        }
                        if (reader.GetString(2) == "DUT")
                        {
                            bas_dut.Items.Add(reader.GetString(0));
                        }
                        if (reader.GetString(2) == "STS")
                        {
                            bas_sts.Items.Add(reader.GetString(0));
                        }
                        if (reader.GetString(2) == "MIL")
                        {
                            bas_mil_mil.Items.Add(reader.GetString(0));
                        }
                        if (reader.GetString(2) == "RNK")
                        {
                            bas_mil_rnk.Items.Add(reader.GetString(0));
                        }
                        if (reader.GetString(2) == "BNK")
                        {
                            bas_acc_bank1.Items.Add(reader.GetString(0));
                            bas_acc_bank2.Items.Add(reader.GetString(0));
                        }
                    }
                    cmd.CommandText = "select dept_code||':'||dept_name, dept_name from thrm_dept_ljm";
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        bas_dept.Items.Add(reader.GetString(0));
                    }
                }
                    
            }
        }

        private void bas_hdpno_KeyDown(object sender, KeyEventArgs e)
        {
            string val = bas_hdpno.Text;

            if (!string.IsNullOrEmpty(val) && e.KeyCode != Keys.Back)
            {
                if (val.Length == 3)
                {
                    val += "-";
                    bas_hdpno.Text = val;
                    bas_hdpno.SelectionStart = bas_hdpno.Text.Length;
                }
                else if (val.Length == 8)
                {
                    val += "-";
                    bas_hdpno.Text = val;
                    bas_hdpno.SelectionStart = bas_hdpno.Text.Length;
                }
            }
        }

        private void bas_telno_KeyDown(object sender, KeyEventArgs e)
        {
            string val = bas_telno.Text;

            if (!string.IsNullOrEmpty(val) && e.KeyCode != Keys.Back)
            {
                if (val.Length == 3)
                {
                    val += "-";
                    bas_telno.Text = val;
                    bas_telno.SelectionStart = bas_hdpno.Text.Length;
                }
                else if (val.Length == 7)
                {
                    val += "-";
                    bas_telno.Text = val;
                    bas_telno.SelectionStart = bas_hdpno.Text.Length;
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bas_zip_Click(object sender, EventArgs e)
        {
            Post post = new Post(this);
            post.ShowDialog();
        }

        private void bas_empno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public string bas_fix;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                bas_fix = ((RadioButton)sender).Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                bas_fix = ((RadioButton)sender).Text;
            }
        }

        private void bas_emp_sdate_ValueChanged(object sender, EventArgs e)
        {

        }

        public void insert_button()
        {
            MessageBox.Show("인사기본사항");
        }

        public void delete_button()
        {

        }

        public void cancel_button()
        {

        }

    }
}
