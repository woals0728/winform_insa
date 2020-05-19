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
using System.Reflection;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Interop;

namespace Project1
{
    public partial class P_information : UserControl
    {
        private static string orcl_str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=222.237.134.74)(PORT=1522)))(CONNECT_DATA=(SID=ora7)));User ID=edu;Password=edu1234";
        OracleConnection conn = new OracleConnection(orcl_str);

        OracleCommand cmd;
        OracleDataReader reader;
        OracleDataAdapter adapter;

        
        public P_information()
        {
            
            InitializeComponent();

        }


        

        private void P_information_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql1 = "select CD_CODE || ':' || CD_CODNMS, cd_codnms, cd_grpcd from tieas_cd_ljm";
                string sql2 = "select dept_code||':'||dept_name, dept_name from thrm_dept_ljm";
                cmd = new OracleCommand(sql1, conn);
                reader = cmd.ExecuteReader();
                comboBox4.Items.Clear();
                comboBox3.Items.Clear();
                comboBox1.Items.Clear();
                bas_mil_mil.Items.Clear();
                bas_mil_rnk.Items.Clear();
                bas_sts.Items.Clear();
                bas_pos.Items.Clear();
                bas_dut.Items.Clear();
                bas_acc_bank1.Items.Clear();
                bas_acc_bank2.Items.Clear();
                bas_dept.Items.Clear();

                while (reader.Read())
                {
                    if (reader.GetString(2) == "POS")
                    {
                        comboBox4.Items.Add(reader.GetString(0));
                        bas_pos.Items.Add(reader.GetString(0));
                    }
                    if (reader.GetString(2) == "DUT")
                    {
                        comboBox3.Items.Add(reader.GetString(0));
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
                    }
                    if (reader.GetString(2) == "BNK")
                    {
                        bas_acc_bank2.Items.Add(reader.GetString(0));
                    }
                }
                reader.Close();
                cmd = new OracleCommand(sql2, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
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

        public void emptyPerform()
        {
            foreach (Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
                if(c is ComboBox)
                {
                    c.Text = "선택";
                }
                if(c is DataGridView)
                {
                    dataGridView1.Refresh();
                }
                foreach (Control d in c.Controls)
                {
                    foreach (Control e in d.Controls)
                    {
                        if (e is GroupBox)
                        {
                            foreach (Control f in e.Controls)
                            {
                                if(f is TextBox)
                                {
                                    f.Text = "";
                                }
                                if(f is ComboBox)
                                {
                                    f.Text = "선택";
                                }
                            }
                        }
                    }
                }
            }
        }

        public int StringCheck()
        {
            foreach(Control c in this.Controls)
            {
                foreach(Control d in c.Controls)
                {
                    foreach(Control e in d.Controls)
                    {
                        if(e is GroupBox)
                        {
                            foreach(Control f in e.Controls)
                            {
                                if (f is TextBox && f.Text == "" || f is ComboBox && f.Text == "선택")
                                {
                                    MessageBox.Show("빈 값을 확인해 주세요.");
                                    f.Focus();
                                    return 1;
                                }
                            }
                        }                        
                    }
                }
            }
            return 0;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public string check;

        public void insertPerform(object sender, EventArgs e)
        {
            check = "insert";
        }

        public void updatePerform(object sender, EventArgs e)
        {
            check = "update";
        }

        public void deletePerform(object sender, EventArgs e)
        {
            check = "delete";
        }

        public void submitPerform(object sender, EventArgs e)
        {
            if(tabNum == 0)
            {
                if(check == "insert")
                {
                    if(StringCheck() == 0)
                    {
                        MessageBox.Show("완료");
                    }
                }
            }
        }

        public void cancelPerform(object sender, EventArgs e)
        {
            emptyPerform();
        }

        public static int tabNum;

        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    tabNum = 0;
                    break;
                case 1:
                    tabNum = 1;
                    break;
                case 2:
                    tabNum = 2;
                    break;
                case 3:
                    tabNum = 3;
                    break;
                case 4:
                    tabNum = 4;
                    break;
                case 5:
                    tabNum = 5;
                    break;
                case 6:
                    tabNum = 6;
                    break;
            }
        }

        public string c1_Text;
        public string c2_Text;
        public string c3_Text;
        public string c4_Text;

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String txt1 = comboBox1.SelectedItem as String;
                if(comboBox1.Text == "선택")
                {
                    c1_Text = "";
                }
                else
                {
                    c1_Text = txt1.Substring(0,1);
                }
                String txt2 = comboBox2.SelectedItem as String;
                if(comboBox2.Text == "선택")
                {
                    c2_Text = "bas_empno";
                }
                if(comboBox2.Text == "사원번호")
                {
                    c2_Text = "bas_empno";
                }
                if(comboBox2.Text == "성명")
                {
                    c2_Text = "bas_name";
                }
                String txt3 = comboBox3.SelectedItem as String;
                if (comboBox3.Text == "선택")
                {
                    c3_Text = "";
                }
                else
                {
                    c3_Text = txt3.Substring(0, 1);
                }
                String txt4 = comboBox4.SelectedItem as String;
                if (comboBox4.Text == "선택")
                {
                    c4_Text = "";
                }
                else
                {
                    c4_Text = txt4.Substring(0, 1);
                }
                conn.Open();
                string sql = "select bas_empno, bas_name, bas_hdpno, pos_codnms, dut_codnms, (dept_code||+':'||dept_name), bas_email " +
                    "from thrm_bas_ljm, (select cd_code, cd_codnms from TIEAS_CD_LJM where cd_grpcd='STS'), " +
                    "(select cd_code as pos_code, cd_codnms as pos_codnms from TIEAS_CD_LJM where cd_grpcd ='POS'), " +
                    "(select cd_code as dut_code, cd_codnms as dut_codnms from TIEAS_CD_LJM where cd_grpcd ='DUT'), " +
                    "(select cd_code as mil_code, cd_codnms as mil_codnms from TIEAS_CD_LJM where cd_grpcd ='MIL'), " +
                    "(select cd_code as rnk_code, cd_codnms as rnk_codnms from TIEAS_CD_LJM where cd_grpcd ='RNK'), " +
                    "(select cd_code as bnk1_code, cd_codnms as bnk1_codnms from TIEAS_CD_LJM where cd_grpcd ='BNK'), " +
                    "(select cd_code as bnk2_code, cd_codnms as bnk2_codnms from TIEAS_CD_LJM where cd_grpcd ='BNK'), " +
                    "(select dept_code, dept_name from THRM_DEPT_LJM) " +
                    "where bas_sts = cd_code and bas_pos=pos_code and bas_dut=dut_code and bas_dept=dept_code and " +
                    "bas_mil_mil=mil_code and bas_mil_rnk=rnk_code and bas_acc_bank1=bnk1_code and bas_acc_bank2=bnk2_code" +
                    " and "+ c2_Text +" like '%"+textBox3.Text+ "%' and bas_dut like '%" + c3_Text + "%'" +
                    " and dept_code like '%" + c1_Text + "%' and bas_pos like '%" + c4_Text + "%' order by bas_empno(+)";
                
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                dataGridView1.Columns.Add("bas_empno", "사원번호");
                dataGridView1.Columns.Add("bas_name", "성명");
                dataGridView1.Columns.Add("bas_hdpno", "핸드폰");
                dataGridView1.Columns.Add("pos_codnms", "직급");
                dataGridView1.Columns.Add("dut_codnms", "직위");
                dataGridView1.Columns.Add("(dept_code||+':'||dept_name)", "부서");
                dataGridView1.Columns.Add("bas_email", "이메일");
                cmd = new OracleCommand(sql, conn);
                reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = (string)reader["bas_empno"];
                    dataGridView1.Rows[i].Cells[1].Value = (string)reader["bas_name"];
                    dataGridView1.Rows[i].Cells[2].Value = (string)reader["bas_hdpno"];
                    dataGridView1.Rows[i].Cells[3].Value = (string)reader["pos_codnms"];
                    dataGridView1.Rows[i].Cells[4].Value = (string)reader["dut_codnms"];
                    dataGridView1.Rows[i].Cells[5].Value = (string)reader["(dept_code||+':'||dept_name)"];
                    dataGridView1.Rows[i].Cells[6].Value = (string)reader["bas_email"];
                    i++;
                }
                reader.Close();
                

                

            }
            catch(Exception ex)
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataSelect(e.RowIndex);
        }

        public void dataSelect(int RowIndex)
        {
            try
            {
                conn.Open();
                string sql = "select * from thrm_bas_ljm, (select cd_code, cd_codnms from TIEAS_CD_LJM where cd_grpcd='STS'), " +
                    "(select cd_code as pos_code, cd_codnms as pos_codnms from TIEAS_CD_LJM where cd_grpcd ='POS'), " +
                    "(select cd_code as dut_code, cd_codnms as dut_codnms from TIEAS_CD_LJM where cd_grpcd ='DUT'), " +
                    "(select cd_code as mil_code, cd_codnms as mil_codnms from TIEAS_CD_LJM where cd_grpcd ='MIL'), " +
                    "(select cd_code as rnk_code, cd_codnms as rnk_codnms from TIEAS_CD_LJM where cd_grpcd ='RNK'), " +
                    "(select cd_code as bnk1_code, cd_codnms as bnk1_codnms from TIEAS_CD_LJM where cd_grpcd ='BNK'), " +
                    "(select cd_code as bnk2_code, cd_codnms as bnk2_codnms from TIEAS_CD_LJM where cd_grpcd ='BNK'), " +
                    "(select dept_code, dept_name from THRM_DEPT_LJM) " +
                    "where bas_sts = cd_code and bas_pos=pos_code and bas_dut=dut_code and bas_dept=dept_code and " +
                    "bas_mil_mil=mil_code and bas_mil_rnk=rnk_code and bas_acc_bank1=bnk1_code and bas_acc_bank2=bnk2_code(+)";
                int a = int.Parse(RowIndex.ToString());
                if (a < 0) return;
                cmd = new OracleCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bas_empno.Text = reader["bas_empno"].ToString();
                    bas_resno1.Text = reader["bas_resno"].ToString().Substring(0, 6);
                    bas_resno2.Text = reader["bas_resno"].ToString().Substring(7, 7);
                    bas_name.Text = reader["bas_name"].ToString();
                    bas_cname.Text = reader["bas_cname"].ToString();
                    bas_ename.Text = reader["bas_ename"].ToString();
                    bas_fix = reader["bas_fix"].ToString();
                    bas_zip.Text = reader["bas_zip"].ToString();
                    bas_addr.Text = reader["bas_addr"].ToString();
                    bas_residence.Text = reader["bas_residence"].ToString();
                    bas_hdpno.Text = reader["bas_hdpno"].ToString();
                    bas_telno.Text = reader["bas_telno"].ToString();
                    bas_email.Text = reader["bas_email"].ToString();
                    bas_mil_sta.Text = reader["bas_mil_sta"].ToString();
                    bas_mil_mil.Text = reader["bas_mil_mil"].ToString() + ':' + reader["mil_codnms"].ToString();
                    bas_mil_rnk.Text = reader["bas_mil_rnk"].ToString() + ':' + reader["rnk_codnms"].ToString();
                    bas_mar.Text = reader["bas_mar"].ToString();
                    bas_acc_bank1.Text = reader["bas_acc_bank1"].ToString() + ':' + reader["bnk1_codnms"].ToString();
                    bas_acc_name1.Text = reader["bas_acc_name1"].ToString();
                    bas_acc_no1.Text = reader["bas_acc_no1"].ToString();
                    bas_acc_bank2.Text = reader["bas_acc_bank2"].ToString() + ':' + reader["bnk2_codnms"].ToString();
                    bas_acc_name2.Text = reader["bas_acc_name2"].ToString();
                    bas_acc_no2.Text = reader["bas_acc_no2"].ToString();
                    bas_cont.Text = reader["bas_cont"].ToString();
                    bas_intern.Text = reader["bas_intern"].ToString();
                    bas_intern_no.Text = reader["bas_intern_no"].ToString();
                    bas_emp_sdate.Text = reader["bas_emp_sdate"].ToString();
                    bas_emp_edate.Text = reader["bas_emp_edate"].ToString();
                    bas_entdate.Text = reader["bas_entdate"].ToString();
                    bas_resdate.Text = reader["bas_resdate"].ToString();
                    bas_levdate.Text = reader["bas_levdate"].ToString();
                    bas_reidate.Text = reader["bas_reidate"].ToString();
                    bas_wsta.Text = reader["bas_wsta"].ToString();
                    bas_sts.Text = reader["bas_sts"].ToString() + ':' + reader["cd_codnms"].ToString();
                    bas_pos.Text = reader["bas_pos"].ToString() + ':' + reader["pos_codnms"].ToString();
                    bas_dut.Text = reader["bas_dut"].ToString() + ':' + reader["dut_codnms"].ToString();
                    bas_dept.Text = reader["dept_code"].ToString() + ':' + reader["dept_name"].ToString();
                    bas_rmk.Text = reader["bas_rmk"].ToString();
                    bas_pos_dt.Text = reader["bas_pos_dt"].ToString();
                    bas_dut_dt.Text = reader["bas_dut_dt"].ToString();
                    bas_dept_dt.Text = reader["bas_dept_dt"].ToString();
                    bas_intern_dt.Text = reader["bas_intern_dt"].ToString();
                }
                reader.Close();
                
            }
            catch(Exception ex)
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

        private void bas_zip_Click(object sender, EventArgs e)
        {
            Post post = new Post(this);
            post.ShowDialog();
        }

        private void bas_empno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
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


        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            
        }

        


    }
}
