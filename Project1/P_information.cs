using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class P_information : UserControl
    {
        OracleDBManager dBManager = new OracleDBManager();

        OracleDataReader reader;
        OracleDataAdapter adapter;

        DataSet ds = new DataSet();

       

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
                //Load_Control(new Information());
                //Load_Control(new Family());
                //Load_Control(new E_Background());
                //Load_Control(new Awards());
                //Load_Control(new Career());
                //Load_Control(new License());
                //Load_Control(new Language());
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
            if (tabNum == 0)
            {
                if (check == "insert")
                {
                    if (StringCheck() == 0)
                    {
                        MessageBox.Show("완료");
                    }
                }
            }
        }

        public void cancelPerform(object sender, EventArgs e)
        {
            var main = new MainWindow();
            main.insert_button.Visible = false;
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
                if (comboBox1.Text == "선택" || comboBox1.Text == "전체")
                {
                    c1_Text = "";
                }
                else
                {
                    c1_Text = txt1.Substring(0, 1);
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
                    c3_Text = txt3.Substring(0, 1);
                }
                String txt4 = comboBox4.SelectedItem as String;
                if (comboBox4.Text == "선택" || comboBox1.Text == "전체")
                {
                    c4_Text = "";
                }
                else
                {
                    c4_Text = txt4.Substring(0, 1);
                }
                //conn.Open();
                //string sql = "select * from INFORMATION_LJM where "+ c2_Text +" like '%"+textBox3.Text+ "%' and bas_dut like '%" + c3_Text + "%'" +
                //" and dept_code like '%" + c1_Text + "%' and bas_pos like '%" + c4_Text + "%' order by bas_empno";
                //OracleDataAdapter adapter = new OracleDataAdapter(sql, conn);
                //adapter.Fill(ds);
                //dataGridView1.DataSource = ds.Tables[0];
                this.iNFORMATION_LJMTableAdapter.Fill(this.dataSet8.INFORMATION_LJM);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }

        }



        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataSelect(e.RowIndex);
        }

        public void dataSelect(int RowIndex)
        {
            int a = int.Parse(RowIndex.ToString());
            if (a < 0) return;

            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }




    }
}
