using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class P_information : UserControl
    {
        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        OracleDataReader reader;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();



        public P_information()
        {
            InitializeComponent();
        }



        private void P_information_Load(object sender, EventArgs e)
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
                            comboBox4.Items.Add(reader.GetString(0));
                        }
                        if (reader.GetString(2) == "DUT")
                        {
                            comboBox3.Items.Add(reader.GetString(0));
                        }
                    }
                    cmd.CommandText = "select dept_code||':'||dept_name, dept_name from thrm_dept_ljm";
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString(0));
                    }
                }
                button4.PerformClick();
            }
        }


        public void emptyPerform()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is ComboBox)
                {
                    c.Text = "선택";
                }
                if (c is DataGridView)
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
                                if (f is TextBox)
                                {
                                    f.Text = "";
                                }
                                if (f is ComboBox)
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
            foreach (Control c in this.Controls)
            {
                foreach (Control d in c.Controls)
                {
                    foreach (Control e in d.Controls)
                    {
                        if (e is GroupBox)
                        {
                            foreach (Control f in e.Controls)
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


        public string c1_Text;
        public string c2_Text;
        public string c3_Text;
        public string c4_Text;

        private void button4_Click(object sender, EventArgs e)
        {

            String txt1 = comboBox1.SelectedItem as String;
            if (comboBox1.Text == "선택" || comboBox1.Text == "전체")
            {
                c1_Text = "";
            }
            else
            {
                string[] result = txt1.Split(new string[] { ":" }, StringSplitOptions.None);
                c1_Text = result[0];
            }
            String txt2 = comboBox2.SelectedItem as String;
            if (comboBox2.Text == "선택")
            {
                c2_Text = "bas_empno";
            }
            if (comboBox2.Text == "사원번호")
            {
                c2_Text = "bas_empno";
            }
            if (comboBox2.Text == "성명")
            {
                c2_Text = "bas_name";
            }
            String txt3 = comboBox3.SelectedItem as String;
            if (comboBox3.Text == "선택" || comboBox1.Text == "전체")
            {
                c3_Text = "";
            }
            else
            {
                string[] result = txt3.Split(new string[] { ":" }, StringSplitOptions.None);
                c3_Text = result[0];
            }
            String txt4 = comboBox4.SelectedItem as String;
            if (comboBox4.Text == "선택" || comboBox1.Text == "전체")
            {
                c4_Text = "";
            }
            else
            {
                string[] result = txt4.Split(new string[] { ":" }, StringSplitOptions.None);
                c4_Text = result[0];
            }

            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    dataGridView1.DataSource = null;
                    cmd.Connection = dBManager.Connection;

                    cmd.CommandText = "select bas_empno as 사원번호, bas_name as 성명, bas_hdpno as 핸드폰, pos_codnms as 직급, dut_codnms as 직위, " +
                        "dept_name as 부서, bas_email as 이메일 from INFORMATION_LJM where " + c2_Text + " like '%" + textBox3.Text + "%' and bas_dut like '%" + c3_Text + "%'" +
                    " and dept_code like '%" + c1_Text + "%' and bas_pos like '%" + c4_Text + "%' order by bas_empno";
                    adapter.SelectCommand = cmd;
                    ds.Clear();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    //bas_empno, bas_name, bas_hdpno, pos_codnms, dut_codnms, dept_name, bas_email
                    //string sql = "select * from thrm_bas_ljm, (select cd_code, cd_codnms from TIEAS_CD_LJM where cd_grpcd='STS'), " +
                    //    "(select cd_code as pos_code, cd_codnms as pos_codnms from TIEAS_CD_LJM where cd_grpcd ='POS'), " +
                    //    "(select cd_code as dut_code, cd_codnms as dut_codnms from TIEAS_CD_LJM where cd_grpcd ='DUT'), " +
                    //    "(select cd_code as mil_code, cd_codnms as mil_codnms from TIEAS_CD_LJM where cd_grpcd ='MIL'), " +
                    //    "(select cd_code as rnk_code, cd_codnms as rnk_codnms from TIEAS_CD_LJM where cd_grpcd ='RNK'), " +
                    //    "(select cd_code as bnk1_code, cd_codnms as bnk1_codnms from TIEAS_CD_LJM where cd_grpcd ='BNK'), " +
                    //    "(select cd_code as bnk2_code, cd_codnms as bnk2_codnms from TIEAS_CD_LJM where cd_grpcd ='BNK'), " +
                    //    "(select dept_code, dept_name from THRM_DEPT_LJM) " +
                    //    "where bas_sts = cd_code and bas_pos=pos_code and bas_dut=dut_code(+) and bas_dept=dept_code and " +
                    //    "bas_mil_mil=mil_code and bas_mil_rnk=rnk_code and bas_acc_bank1=bnk1_code and bas_acc_bank2=bnk2_code" +
                    //    " and "+ c2_Text +" like '%"+textBox3.Text+ "%' and bas_dut like '%" + c3_Text + "%'" +
                    //    " and dept_code like '%" + c1_Text + "%' and bas_pos like '%" + c4_Text + "%' order by bas_empno";
                    //
                    //
                    //
                    //dataGridView1.Columns.Clear();
                    //dataGridView1.Refresh();
                    //dataGridView1.Columns.Add("bas_empno", "사원번호");
                    //dataGridView1.Columns.Add("bas_name", "성명");
                    //dataGridView1.Columns.Add("bas_hdpno", "핸드폰");
                    //dataGridView1.Columns.Add("pos_codnms", "직급");
                    //dataGridView1.Columns.Add("dut_codnms", "직위");
                    //dataGridView1.Columns.Add("dept_name", "부서");
                    //dataGridView1.Columns.Add("bas_email", "이메일");
                    //cmd = new OracleCommand(sql, conn);
                    //reader = cmd.ExecuteReader();
                    //int i = 0;
                    //while (reader.Read())
                    //{
                    //    dataGridView1.Rows.Add();
                    //    dataGridView1.Rows[i].Cells[0].Value = (string)reader["bas_empno"];
                    //    dataGridView1.Rows[i].Cells[1].Value = (string)reader["bas_name"];
                    //    dataGridView1.Rows[i].Cells[2].Value = (string)reader["bas_hdpno"];
                    //    dataGridView1.Rows[i].Cells[3].Value = (string)reader["pos_codnms"];
                    //    dataGridView1.Rows[i].Cells[4].Value = (string)reader["dut_codnms"];
                    //    dataGridView1.Rows[i].Cells[5].Value = (string)reader["dept_name"];
                    //    dataGridView1.Rows[i].Cells[6].Value = (string)reader["bas_email"];
                    //    i++;
                    //}
                    //reader.Close();
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataSelect(e.RowIndex);
        }

        public void dataSelect(int RowIndex)
        {
            int a = int.Parse(RowIndex.ToString());
            if (a < 0) return;

            //string sql = "select * from thrm_bas_ljm, (select cd_code, cd_codnms from TIEAS_CD_LJM where cd_grpcd='STS'), " +
            //        "(select cd_code as pos_code, cd_codnms as pos_codnms from TIEAS_CD_LJM where cd_grpcd ='POS'), " +
            //        "(select cd_code as dut_code, cd_codnms as dut_codnms from TIEAS_CD_LJM where cd_grpcd ='DUT'), " +
            //        "(select cd_code as mil_code, cd_codnms as mil_codnms from TIEAS_CD_LJM where cd_grpcd ='MIL'), " +
            //        "(select cd_code as rnk_code, cd_codnms as rnk_codnms from TIEAS_CD_LJM where cd_grpcd ='RNK'), " +
            //        "(select cd_code as bnk1_code, cd_codnms as bnk1_codnms from TIEAS_CD_LJM where cd_grpcd ='BNK'), " +
            //        "(select cd_code as bnk2_code, cd_codnms as bnk2_codnms from TIEAS_CD_LJM where cd_grpcd ='BNK'), " +
            //        "(select dept_code, dept_name from THRM_DEPT_LJM) " +
            //        "where bas_sts = cd_code and bas_pos=pos_code and bas_dut=dut_code(+) and bas_dept=dept_code and " +
            //        "bas_mil_mil=mil_code and bas_mil_rnk=rnk_code and bas_acc_bank1=bnk1_code and bas_acc_bank2=bnk2_code";
            //int a = int.Parse(RowIndex.ToString());
            //if (a < 0) return;
            //cmd = new OracleCommand(sql, conn);
            //reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    bas_empno.Text = reader["bas_empno"].ToString();
            //    bas_resno1.Text = reader["bas_resno"].ToString().Substring(0, 6);
            //    bas_resno2.Text = reader["bas_resno"].ToString().Substring(7, 7);
            //    bas_name.Text = reader["bas_name"].ToString();
            //    bas_cname.Text = reader["bas_cname"].ToString();
            //    bas_ename.Text = reader["bas_ename"].ToString();
            //    bas_fix = reader["bas_fix"].ToString();
            //    bas_zip.Text = reader["bas_zip"].ToString();
            //    bas_addr.Text = reader["bas_addr"].ToString();
            //    bas_residence.Text = reader["bas_residence"].ToString();
            //    bas_hdpno.Text = reader["bas_hdpno"].ToString();
            //    bas_telno.Text = reader["bas_telno"].ToString();
            //    bas_email.Text = reader["bas_email"].ToString();
            //    bas_mil_sta.Text = reader["bas_mil_sta"].ToString();
            //    bas_mil_mil.Text = reader["bas_mil_mil"].ToString() + ':' + reader["mil_codnms"].ToString();
            //    bas_mil_rnk.Text = reader["bas_mil_rnk"].ToString() + ':' + reader["rnk_codnms"].ToString();
            //    bas_mar.Text = reader["bas_mar"].ToString();
            //    bas_acc_bank1.Text = reader["bas_acc_bank1"].ToString() + ':' + reader["bnk1_codnms"].ToString();
            //    bas_acc_name1.Text = reader["bas_acc_name1"].ToString();
            //    bas_acc_no1.Text = reader["bas_acc_no1"].ToString();
            //    bas_acc_bank2.Text = reader["bas_acc_bank2"].ToString() + ':' + reader["bnk2_codnms"].ToString();
            //    bas_acc_name2.Text = reader["bas_acc_name2"].ToString();
            //    bas_acc_no2.Text = reader["bas_acc_no2"].ToString();
            //    bas_cont.Text = reader["bas_cont"].ToString();
            //    bas_intern.Text = reader["bas_intern"].ToString();
            //    bas_intern_no.Text = reader["bas_intern_no"].ToString();
            //    bas_emp_sdate.Text = reader["bas_emp_sdate"].ToString();
            //    bas_emp_edate.Text = reader["bas_emp_edate"].ToString();
            //    bas_entdate.Text = reader["bas_entdate"].ToString();
            //    bas_resdate.Text = reader["bas_resdate"].ToString();
            //    bas_levdate.Text = reader["bas_levdate"].ToString();
            //    bas_reidate.Text = reader["bas_reidate"].ToString();
            //    bas_wsta.Text = reader["bas_wsta"].ToString();
            //    bas_sts.Text = reader["bas_sts"].ToString() + ':' + reader["cd_codnms"].ToString();
            //    bas_pos.Text = reader["bas_pos"].ToString() + ':' + reader["pos_codnms"].ToString();
            //    bas_dut.Text = reader["bas_dut"].ToString() + ':' + reader["dut_codnms"].ToString();
            //    bas_dept.Text = reader["dept_code"].ToString() + ':' + reader["dept_name"].ToString();
            //    bas_rmk.Text = reader["bas_rmk"].ToString();
            //    bas_pos_dt.Text = reader["bas_pos_dt"].ToString();
            //    bas_dut_dt.Text = reader["bas_dut_dt"].ToString();
            //    bas_dept_dt.Text = reader["bas_dept_dt"].ToString();
            //    bas_intern_dt.Text = reader["bas_intern_dt"].ToString();
            //}
        }

    }
}
