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

        OracleDataReader reader;
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            //bas_empno.Enabled = false;
            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = dBManager.Connection;

                    cmd.CommandText = "select CD_CODE || ':' || CD_CODNMS, cd_codnms, cd_grpcd from tieas_cd_ljm where cd_use = 'Y'";
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
                    cmd.CommandText = "select dept_code||':'||dept_name, dept_name from thrm_dept_ljm order by cast(dept_code as number)";
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
            bas_fix = "남";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bas_fix = "여";
        }

        private void bas_emp_sdate_ValueChanged(object sender, EventArgs e)
        {

        }
        public int StringCheck()
        {
            foreach (Control e in this.Controls)
            {
                if (e is GroupBox)
                {
                    foreach (Control f in e.Controls)
                    {
                        if (f is TextBox && f.Text == "" && f.Tag == null || f is ComboBox && f.Text == "선택" && f.Tag == null)
                        {
                            MessageBox.Show("빈 값을 확인해 주세요.");
                            f.Focus();
                            return 1;
                        }
                    }
                }
            }
            return 0;
        }

        public void emptyPerform()
        {
            foreach (Control e in this.Controls)
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

        public string button_check;
        public void insert_button()
        {
            button_check = "insert";
        }

        public void update_button()
        {
            button_check = "update";
            bas_empno.Enabled = false;
            ck_button.Enabled = false;

        }
        public void delete_button()
        {
            button_check = "delete";
        }

        public void submit_button()
        {
            if (button_check == "insert")
            {
                if (e_check == 0 || e_check == 1)
                {
                    MessageBox.Show("사원번호 중복확인을 해주세요.");
                    return;
                }
                if (StringCheck() == 0)
                {
                    if (dBManager.GetConnection() == true)
                    {
                        using (OracleCommand cmd = new OracleCommand())
                        {
                            OracleTransaction tran = dBManager.Connection.BeginTransaction();
                            cmd.Transaction = tran;
                            string resno = bas_resno1.Text + "-" + bas_resno2.Text;
                            string user = mainControl.USER.Text;
                            string[] result1 = mil_mil.Split(new string[] { ":" }, StringSplitOptions.None);
                            string mil = result1[0];
                            string[] result2 = mil_rnk.Split(new string[] { ":" }, StringSplitOptions.None);
                            string rnk = result2[0];
                            string[] result3 = bas_pos.Text.Split(new string[] { ":" }, StringSplitOptions.None);
                            string pos = result3[0];
                            string[] result4 = bas_dut.Text.Split(new string[] { ":" }, StringSplitOptions.None);
                            string dut = result4[0];
                            string[] result5 = bas_sts.Text.Split(new string[] { ":" }, StringSplitOptions.None);
                            string sts = result5[0];
                            string[] result6 = bas_dept.Text.Split(new string[] { ":" }, StringSplitOptions.None);
                            string dept = result6[0];
                            string[] result7 = bas_acc_bank1.Text.Split(new string[] { ":" }, StringSplitOptions.None);
                            string bnk1 = result7[0];
                            string[] result8 = acc_bank2.Split(new string[] { ":" }, StringSplitOptions.None);
                            string bnk2 = result8[0];

                            cmd.Connection = dBManager.Connection;
                            try
                            {
                                cmd.CommandText = "insert into thrm_bas_ljm values ('" + bas_empno.Text + "', '" + resno + "'," +
                                "'" + bas_name.Text + "', '" + bas_cname.Text + "', '" + bas_ename.Text + "', '" + bas_fix + "'," +
                                "'" + bas_zip.Text + "', '" + bas_addr.Text + "', '" + bas_residence.Text + "', '" + bas_hdpno.Text + "'," +
                                "'" + bas_telno.Text + "', '" + bas_email.Text + "', '" + bas_mil_sta.Text + "', '" + mil + "'," +
                                "'" + rnk + "', '" + bas_mar.Text + "', '" + bnk1 + "', '" + bas_acc_name1.Text + "'," +
                                "'" + bas_acc_no1.Text + "', '" + bnk2 + "', '" + bas_acc_name2.Text + "', '" + bas_acc_no2.Text + "'," +
                                "'" + bas_cont.Text + "', '" + bas_intern.Text + "', " + bas_intern_no.Text + ", '" + bas_emp_sdate.Text + "'," +
                                "'" + bas_emp_edate.Text + "', '" + bas_entdate.Text + "', '" + bas_resdate.Text + "', '" + bas_levdate.Text + "'," +
                                "'" + bas_reidate.Text + "', '" + bas_wsta.Text + "', '" + sts + "', '" + pos + "'," +
                                "'" + dut + "', '" + dept + "', '" + bas_rmk.Text + "', '" + bas_pos_dt.Text + "'," +
                                "'" + bas_dut_dt.Text + "', '" + bas_dept_dt.Text + "', '" + bas_intern_dt.Text + "', '" + DateTime.Now + "', 'A', '" + user + "')";
                                cmd.ExecuteNonQuery();
                                tran.Commit();
                                MessageBox.Show("입력완료");
                            }
                            catch (Exception ex)
                            {
                                tran.Rollback();
                                MessageBox.Show(ex.Message);
                            }

                        }

                    }
                }
                if (button_check == "update")
                {
                    if (dBManager.GetConnection() == true)
                    {
                        using (OracleCommand cmd = new OracleCommand())
                        {
                            OracleTransaction tran = dBManager.Connection.BeginTransaction();
                            cmd.Transaction = tran;
                            string resno = bas_resno1.Text + "-" + bas_resno2.Text;
                            string user = mainControl.USER.Text;
                            string[] result1 = mil_mil.Split(new string[] { ":" }, StringSplitOptions.None);
                            string mil = result1[0];
                            string[] result2 = mil_rnk.Split(new string[] { ":" }, StringSplitOptions.None);
                            string rnk = result2[0];
                            string[] result3 = bas_pos.Text.Split(new string[] { ":" }, StringSplitOptions.None);
                            string pos = result3[0];
                            string[] result4 = bas_dut.Text.Split(new string[] { ":" }, StringSplitOptions.None);
                            string dut = result4[0];
                            string[] result5 = bas_sts.Text.Split(new string[] { ":" }, StringSplitOptions.None);
                            string sts = result5[0];
                            string[] result6 = bas_dept.Text.Split(new string[] { ":" }, StringSplitOptions.None);
                            string dept = result6[0];
                            string[] result7 = bas_acc_bank1.Text.Split(new string[] { ":" }, StringSplitOptions.None);
                            string bnk1 = result7[0];
                            string[] result8 = acc_bank2.Split(new string[] { ":" }, StringSplitOptions.None);
                            string bnk2 = result8[0];

                            cmd.Connection = dBManager.Connection;
                            try
                            {
                                cmd.CommandText = "select * from thrm_bas_ljm where bas_empno = '" + bas_empno.Text + "'";
                                reader = cmd.ExecuteReader();
                                if (reader.Read())
                                {
                                    cmd.CommandText = "update thrm_bas_ljm set bas_resno = '" + resno + "', bas_name = '" + bas_name.Text + "', bas_cname = '" + bas_cname.Text + "'," +
                                    "bas_ename = '" + bas_ename.Text + "', bas_fix = '" + bas_fix + "', bas_zip = '" + bas_zip.Text + "'," +
                                    "bas_addr = '" + bas_addr.Text + "', bas_residence = '" + bas_residence.Text + "', bas_hdpno = '" + bas_hdpno.Text + "'," +
                                    "bas_telno = '" + bas_telno.Text + "', bas_email = '" + bas_email.Text + "', bas_mil_sta = '" + bas_mil_sta.Text + "'," +
                                    "bas_mil_mil = '" + mil + "', bas_mil_rnk = '" + rnk + "', bas_mar = '" + bas_mar.Text + "', bas_acc_bank1 = '" + bnk1 + "'," +
                                    "bas_acc_name1 = '" + bas_acc_name1.Text + "', bas_acc_no1 = '" + bas_acc_no1.Text + "', bas_acc_bank2 = '" + bnk2 + "'," +
                                    "bas_acc_name2 = '" + bas_acc_name2.Text + "', bas_acc_no2 = '" + bas_acc_no2.Text + "', bas_cont = '" + bas_cont.Text + "'," +
                                    "bas_intern = '" + bas_intern.Text + "', bas_intern_no = '" + bas_intern_no.Text + "', bas_emp_sdate = '" + bas_emp_sdate.Text + "'," +
                                    "bas_emp_edate = '" + bas_emp_edate.Text + "', bas_entdate = '" + bas_entdate + "', bas_resdate = '" + bas_resdate.Text + "'," +
                                    "bas_levdate = '" + bas_levdate.Text + "', bas_reidate = '" + bas_reidate.Text + "', bas_wsta = '" + bas_wsta.Text + "', " +
                                    "bas_sts = '" + sts + "', bas_pos = '" + pos + "', bas_dut = '" + dut + "', bas_dept = '" + dept + "', bas_rmk = '" + bas_rmk.Text + "'," +
                                    "bas_pos_dt = '" + bas_pos_dt.Text + "', bas_dut_dt = '" + bas_dut_dt.Text + "', bas_dept_dt = '" + bas_dept_dt.Text + "'," +
                                    "bas_intern_dt = '" + bas_intern_dt.Text + "', datasys1 = '" + DateTime.Now + "', datasys2 = 'A', datasys3 = '" + user + "' " +
                                    "where bas_empno = '" + bas_empno.Text + "'";
                                    cmd.ExecuteNonQuery();
                                    tran.Commit();
                                    MessageBox.Show("수정완료");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                tran.Rollback();
                            }

                        }
                    }
                }
                if (button_check == "delete")
                {

                    if (dBManager.GetConnection() == true)
                    {
                        using (OracleCommand cmd = new OracleCommand())
                        {
                            OracleTransaction tran = dBManager.Connection.BeginTransaction();
                            cmd.Connection = dBManager.Connection;
                            cmd.Transaction = tran;
                            try
                            {
                                cmd.CommandText = "select * from thrm_bas_ljm where bas_empno = '" + bas_empno.Text + "'";
                                reader = cmd.ExecuteReader();
                                if (reader.Read())
                                {
                                    cmd.CommandText = "delete from thrm_bas_ljm where bas_empno = '" + bas_empno.Text + "'";
                                    cmd.ExecuteNonQuery();
                                    tran.Commit();
                                    MessageBox.Show("삭제완료");
                                }
                            }
                            catch (Exception ex)
                            {
                                tran.Rollback();
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }
            }
        }
        public void cancel_button()
        {
            emptyPerform();
            bas_empno.Enabled = true;
            ck_button.Enabled = true;
        }

        public string mil_mil;
        public string mil_rnk;

        private void bas_mil_sta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bas_mil_sta.Text != "복무")
            {
                bas_mil_mil.Enabled = false;
                bas_mil_rnk.Enabled = false;
                bas_mil_mil.Tag = "NO";
                bas_mil_rnk.Tag = "NO";
                mil_mil = "";
                mil_rnk = "";
            }
            else
            {
                bas_mil_mil.Enabled = true;
                bas_mil_rnk.Enabled = true;
                bas_mil_mil.Tag = null;
                bas_mil_rnk.Tag = null;
                mil_mil = bas_mil_mil.Text;
                mil_rnk = bas_mil_rnk.Text;
            }
        }
        public string acc_bank2;
        private void bas_acc_bank2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bas_acc_bank2.Text == "해당없음")
            {
                bas_acc_name2.Enabled = false;
                bas_acc_no2.Enabled = false;
                bas_acc_name2.Text = "";
                bas_acc_no2.Text = "";
                acc_bank2 = "";
            }
            else
            {
                bas_acc_name2.Enabled = true;
                bas_acc_no2.Enabled = true;
                acc_bank2 = bas_acc_bank2.Text;
            }
        }
        public int e_check;

        private void empno_check()
        {
            try
            {
                if (dBManager.GetConnection() == true)
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = dBManager.Connection;
                        cmd.CommandText = "select BAS_EMPNO from thrm_bas_ljm where BAS_EMPNO = " + bas_empno.Text;
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("이미 존재하는 사원번호 입니다.");
                            bas_empno.Enabled = true;
                            e_check = 1;
                            return;
                        }
                        else
                        {
                            if (MessageBox.Show("이 사원번호를 사용하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                bas_empno.Enabled = false;
                                ck_button.Enabled = false;
                                e_check = 2;
                                return;
                            }
                            else
                            {
                                bas_empno.Enabled = true;
                                ck_button.Enabled = true;
                                e_check = 1;
                                return;
                            }
                        }
                    }
                }
            }
            catch
            {

            }
            e_check = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (bas_empno.Text == "")
            {
                MessageBox.Show("사원번호를 입력 해주세요.");
                return;
            }
            else if (bas_empno.TextLength < 5)
            {
                MessageBox.Show("사원번호는 5자리로 입력 해주세요.");
                return;
            }
            empno_check();
        }
    }
}
