using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Project1
{
    public partial class Information : UserControl
    {
        private static string orcl_str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=222.237.134.74)(PORT=1522)))(CONNECT_DATA=(SID=ora7)));User ID=edu;Password=edu1234";
        OracleConnection conn = new OracleConnection(orcl_str);

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
            try
            {
                conn.Open();
                string sql1 = "select CD_CODE || ':' || CD_CODNMS, cd_codnms, cd_grpcd from tieas_cd_ljm";
                string sql2 = "select dept_code||':'||dept_name, dept_name from thrm_dept_ljm";
                cmd = new OracleCommand(sql1, conn);
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
                reader.Close();
                cmd = new OracleCommand(sql2, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bas_dept.Items.Add(reader.GetString(0));
                }
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
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

        public static string bas_fix;

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

    }
}
