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
        OracleDataAdapter adapter = new OracleDataAdapter();
        OracleDataReader reader;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public MainWindow mainControl { get; set; }
        public MainWindow main_P { get; set; }

        List<INFO> info_data = new List<INFO>();
        private BindingSource infoBindingSource = new BindingSource();
        private INFO.SortableBindingList<INFO> infoBindingList;

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
                    cmd.CommandText = "select CD_CODE || ':' || CD_CODNMS, cd_codnms, cd_grpcd from tieas_cd_ljm where cd_use = 'Y'";
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
                    cmd.CommandText = "select dept_code||':'||dept_name, dept_name from thrm_dept_ljm order by cast(dept_code as number)";
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString(0));
                    }
                }
                button4.PerformClick();
            }
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
            if (comboBox3.Text == "선택" || comboBox3.Text == "전체")
            {
                c3_Text = "";
            }
            else
            {
                string[] result = txt3.Split(new string[] { ":" }, StringSplitOptions.None);
                c3_Text = result[0];
            }
            String txt4 = comboBox4.SelectedItem as String;
            if (comboBox4.Text == "선택" || comboBox4.Text == "전체")
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
                    cmd.Connection = dBManager.Connection;

                    cmd.CommandText = "select * from INFORMATION_LJM where " + c2_Text + " like '%" + textBox3.Text + "%' and bas_dut like '%" + c3_Text + "%'" +
                    " and dept_code like '%" + c1_Text + "%' and bas_pos like '%" + c4_Text + "%' order by bas_empno";
                    reader = cmd.ExecuteReader();
                    info_data.Clear();
                    while (reader.Read())
                    {
                        info_data.Add(new INFO(
                            reader["bas_empno"].ToString(),
                            reader["bas_resno"].ToString().Substring(0, 6),
                            reader["bas_resno"].ToString().Substring(7, 7),
                            reader["bas_name"].ToString(),
                            reader["bas_cname"].ToString(),
                            reader["bas_ename"].ToString(),
                            reader["bas_fix"].ToString(),
                            reader["bas_zip"].ToString(),
                            reader["bas_addr"].ToString(),
                            reader["bas_residence"].ToString(),
                            reader["bas_hdpno"].ToString(),
                            reader["bas_telno"].ToString(),
                            reader["bas_email"].ToString(),
                            reader["bas_mil_sta"].ToString(),
                            reader["bas_mil_mil"].ToString() + ':' + reader["mil_codnms"].ToString(),
                            reader["bas_mil_rnk"].ToString() + ':' + reader["rnk_codnms"].ToString(),
                            reader["bas_mar"].ToString(),
                            reader["bas_acc_bank1"].ToString() + ':' + reader["bnk1_codnms"].ToString(),
                            reader["bas_acc_name1"].ToString(),
                            reader["bas_acc_no1"].ToString(),
                            reader["bas_acc_bank2"].ToString() + ':' + reader["bnk2_codnms"].ToString(),
                            reader["bas_acc_name2"].ToString(),
                            reader["bas_acc_no2"].ToString(),
                            reader["bas_cont"].ToString(),
                            reader["bas_intern"].ToString(),
                            reader["bas_intern_no"].ToString(),
                            reader["bas_emp_sdate"].ToString(),
                            reader["bas_emp_edate"].ToString(),
                            reader["bas_entdate"].ToString(),
                            reader["bas_resdate"].ToString(),
                            reader["bas_levdate"].ToString(),
                            reader["bas_reidate"].ToString(),
                            reader["bas_wsta"].ToString(),
                            reader["bas_sts"].ToString() + ':' + reader["cd_codnms"].ToString(),
                            reader["bas_pos"].ToString() + ':' + reader["pos_codnms"].ToString(),
                            reader["bas_dut"].ToString() + ':' + reader["dut_codnms"].ToString(),
                            reader["dept_code"].ToString() + ':' + reader["dept_name"].ToString(),
                            reader["bas_rmk"].ToString(),
                            reader["bas_pos_dt"].ToString(),
                            reader["bas_dut_dt"].ToString(),
                            reader["bas_dept_dt"].ToString(),
                            reader["bas_intern_dt"].ToString()));
                    }
                    infoBindingList = new INFO.SortableBindingList<INFO>(info_data);
                    infoBindingSource.DataSource = infoBindingList;
                    dataGridView1.DataSource = infoBindingSource;
                    #region //datagridview_columns_visible
                    this.dataGridView1.Columns["bas_empno"].HeaderText = "사원번호";
                    this.dataGridView1.Columns["bas_resno1"].Visible = false;
                    this.dataGridView1.Columns["bas_resno2"].Visible = false;
                    this.dataGridView1.Columns["bas_name"].HeaderText = "성명";
                    this.dataGridView1.Columns["bas_cname"].Visible = false;
                    this.dataGridView1.Columns["bas_ename"].Visible = false;
                    this.dataGridView1.Columns["bas_fix"].Visible = false;
                    this.dataGridView1.Columns["bas_zip"].Visible = false;
                    this.dataGridView1.Columns["bas_addr"].Visible = false;
                    this.dataGridView1.Columns["bas_residence"].Visible = false;
                    this.dataGridView1.Columns["bas_hdpno"].HeaderText = "핸드폰";
                    this.dataGridView1.Columns["bas_telno"].Visible = false;
                    this.dataGridView1.Columns["bas_email"].HeaderText = "이메일";
                    this.dataGridView1.Columns["bas_mil_sta"].Visible = false;
                    this.dataGridView1.Columns["bas_mil_mil"].Visible = false;
                    this.dataGridView1.Columns["bas_mil_rnk"].Visible = false;
                    this.dataGridView1.Columns["bas_mar"].Visible = false;
                    this.dataGridView1.Columns["bas_acc_bank1"].Visible = false;
                    this.dataGridView1.Columns["bas_acc_name1"].Visible = false;
                    this.dataGridView1.Columns["bas_acc_no1"].Visible = false;
                    this.dataGridView1.Columns["bas_acc_bank2"].Visible = false;
                    this.dataGridView1.Columns["bas_acc_name2"].Visible = false;
                    this.dataGridView1.Columns["bas_acc_no2"].Visible = false;
                    this.dataGridView1.Columns["bas_cont"].Visible = false;
                    this.dataGridView1.Columns["bas_intern"].Visible = false;
                    this.dataGridView1.Columns["bas_intern_no"].Visible = false;
                    this.dataGridView1.Columns["bas_emp_sdate"].Visible = false;
                    this.dataGridView1.Columns["bas_emp_edate"].Visible = false;
                    this.dataGridView1.Columns["bas_entdate"].Visible = false;
                    this.dataGridView1.Columns["bas_resdate"].Visible = false;
                    this.dataGridView1.Columns["bas_levdate"].Visible = false;
                    this.dataGridView1.Columns["bas_reidate"].Visible = false;
                    this.dataGridView1.Columns["bas_wsta"].Visible = false;
                    this.dataGridView1.Columns["bas_sts"].Visible = false;
                    this.dataGridView1.Columns["bas_pos"].HeaderText = "직급";
                    this.dataGridView1.Columns["bas_dut"].HeaderText = "직위";
                    this.dataGridView1.Columns["bas_dept"].HeaderText = "부서";
                    this.dataGridView1.Columns["bas_rmk"].Visible = false;
                    this.dataGridView1.Columns["bas_pos_dt"].Visible = false;
                    this.dataGridView1.Columns["bas_dut_dt"].Visible = false;
                    this.dataGridView1.Columns["bas_dept_dt"].Visible = false;
                    this.dataGridView1.Columns["bas_intern_dt"].Visible = false;
                    #endregion
                }
            }
        }

        public string Empno;
        public string User;

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            main_P.setInsertButton(false, Properties.Resources.insert_);
            main_P.setUpdateButton(true, Properties.Resources.update);
            main_P.setDeleteButton(true, Properties.Resources.delete);
            main_P.setCancelButton(true, Properties.Resources.cancel);
            if (e.RowIndex < 0)
            {
                return;
            }
            try
            {
                int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = this.dataGridView1.Rows[rowIndex];
                INFO currentInfo = row.DataBoundItem as INFO;
                if (currentInfo != null)
                {
                    Information inf = (Information)tabControl1.TabPages[0].Controls[0];
                    inf.bas_empno.Text = currentInfo.bas_empno;
                    Empno = currentInfo.bas_empno;
                    inf.bas_resno1.Text = currentInfo.bas_resno1;
                    inf.bas_resno2.Text = currentInfo.bas_resno2;
                    inf.bas_name.Text = currentInfo.bas_name;
                    inf.bas_cname.Text = currentInfo.bas_cname;
                    inf.bas_ename.Text = currentInfo.bas_ename;
                    if (currentInfo.bas_fix == "남")
                    {
                        inf.radioButton1.Checked = true;
                    }
                    else if (currentInfo.bas_fix == "여")
                    {
                        inf.radioButton2.Checked = true;
                    }
                    inf.bas_zip.Text = currentInfo.bas_zip;
                    inf.bas_addr.Text = currentInfo.bas_addr;
                    inf.bas_residence.Text = currentInfo.bas_residence;
                    inf.bas_hdpno.Text = currentInfo.bas_hdpno;
                    inf.bas_telno.Text = currentInfo.bas_telno;
                    inf.bas_email.Text = currentInfo.bas_email;
                    inf.bas_mil_sta.Text = currentInfo.bas_mil_sta;
                    inf.bas_mil_mil.Text = currentInfo.bas_mil_mil;
                    inf.bas_mil_rnk.Text = currentInfo.bas_mil_rnk;
                    inf.bas_mar.Text = currentInfo.bas_mar;
                    inf.bas_acc_bank1.Text = currentInfo.bas_acc_bank1;
                    inf.bas_acc_name1.Text = currentInfo.bas_acc_name1;
                    inf.bas_acc_no1.Text = currentInfo.bas_acc_no1;
                    inf.bas_acc_bank2.Text = currentInfo.bas_acc_bank2;
                    inf.bas_acc_name2.Text = currentInfo.bas_acc_name2;
                    inf.bas_acc_no2.Text = currentInfo.bas_acc_no2;
                    inf.bas_cont.Text = currentInfo.bas_cont;
                    inf.bas_intern.Text = currentInfo.bas_intern;
                    inf.bas_intern_no.Text = currentInfo.bas_intern_no;
                    inf.bas_emp_sdate.Text = currentInfo.bas_emp_sdate;
                    inf.bas_emp_edate.Text = currentInfo.bas_emp_edate;
                    inf.bas_entdate.Text = currentInfo.bas_entdate;
                    inf.bas_resdate.Text = currentInfo.bas_resdate;
                    inf.bas_levdate.Text = currentInfo.bas_levdate;
                    inf.bas_reidate.Text = currentInfo.bas_reidate;
                    inf.bas_wsta.Text = currentInfo.bas_wsta;
                    inf.bas_sts.Text = currentInfo.bas_sts;
                    inf.bas_pos.Text = currentInfo.bas_pos;
                    inf.bas_dut.Text = currentInfo.bas_dut;
                    inf.bas_dept.Text = currentInfo.bas_dept;
                    inf.bas_rmk.Text = currentInfo.bas_rmk;
                    inf.bas_pos_dt.Text = currentInfo.bas_pos_dt;
                    inf.bas_dut_dt.Text = currentInfo.bas_dut_dt;
                    inf.bas_dept_dt.Text = currentInfo.bas_dept_dt;
                    inf.bas_intern_dt.Text = currentInfo.bas_intern_dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataSelect("DataLoad");
        }


        public void dataSelect(String _mtd)
        {
            UserControl control = (UserControl)tabControl1.SelectedTab.Controls[0];
            Type type = control.GetType();

            System.Reflection.PropertyInfo pi = type.GetProperty("P_info");
            if (pi != null)
            {
                pi.SetValue(control, this);
            }
            System.Reflection.MethodInfo mtd = type.GetMethod(_mtd);
            if (_mtd == null || mtd == null)
            {
                return;
            }
            mtd.Invoke(control, null);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Empno == null)
            {
                if (tabControl1.SelectedIndex != 0)
                {
                    tabControl1.SelectedIndex = 0;
                    MessageBox.Show("사원 정보를 먼저 선택 해주세요.");
                    return;
                }
            }
            dataSelect("DataLoad");
        }

    }
}
