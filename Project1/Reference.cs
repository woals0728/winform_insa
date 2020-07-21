using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    public partial class Reference : UserControl
    {
        OracleDBManager dBManager = new OracleDBManager();
        OracleDataReader reader;
        public MainWindow mainControl { get; set; }
        public MainWindow main_P { get; set; }

        List<INFO> info_data = new List<INFO>();
        private BindingSource infoBindingSource = new BindingSource();
        private INFO.SortableBindingList<INFO> infoBindingList;
        public Reference()
        {
            InitializeComponent();
        }



        private void Reference_Load(object sender, EventArgs e)
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
                    this.dataGridView1.Columns["bas_resno1"].HeaderText = "주민번호 앞자리";
                    this.dataGridView1.Columns["bas_resno2"].Visible = false;
                    this.dataGridView1.Columns["bas_name"].HeaderText = "성명(한글)";
                    this.dataGridView1.Columns["bas_cname"].HeaderText = "성명(한자)";
                    this.dataGridView1.Columns["bas_ename"].HeaderText = "성명(영문)";
                    this.dataGridView1.Columns["bas_fix"].HeaderText = "성별";
                    this.dataGridView1.Columns["bas_zip"].HeaderText = "우편번호";
                    this.dataGridView1.Columns["bas_addr"].HeaderText = "주소";
                    this.dataGridView1.Columns["bas_residence"].HeaderText = "거주지";
                    this.dataGridView1.Columns["bas_hdpno"].HeaderText = "핸드폰";
                    this.dataGridView1.Columns["bas_telno"].HeaderText = "집전화";
                    this.dataGridView1.Columns["bas_email"].HeaderText = "이메일";
                    this.dataGridView1.Columns["bas_mil_sta"].HeaderText = "군별";
                    this.dataGridView1.Columns["bas_mil_mil"].HeaderText = "복무구분";
                    this.dataGridView1.Columns["bas_mil_rnk"].HeaderText = "계급";
                    this.dataGridView1.Columns["bas_mar"].HeaderText = "결혼여부";
                    this.dataGridView1.Columns["bas_acc_bank1"].HeaderText = "은행명1";
                    this.dataGridView1.Columns["bas_acc_name1"].HeaderText = "예금주1";
                    this.dataGridView1.Columns["bas_acc_no1"].HeaderText = "계좌번호1";
                    this.dataGridView1.Columns["bas_acc_bank2"].HeaderText = "은행명2";
                    this.dataGridView1.Columns["bas_acc_name2"].HeaderText = "예금주2";
                    this.dataGridView1.Columns["bas_acc_no2"].HeaderText = "계좌번호2";
                    this.dataGridView1.Columns["bas_cont"].HeaderText = "계약구분";
                    this.dataGridView1.Columns["bas_intern"].HeaderText = "수습/인턴구분";
                    this.dataGridView1.Columns["bas_intern_no"].HeaderText = "수습/인턴 개월수";
                    this.dataGridView1.Columns["bas_emp_sdate"].HeaderText = "계약시작일";
                    this.dataGridView1.Columns["bas_emp_edate"].HeaderText = "계약종료일";
                    this.dataGridView1.Columns["bas_entdate"].HeaderText = "입사일자";
                    this.dataGridView1.Columns["bas_resdate"].HeaderText = "퇴사일자";
                    this.dataGridView1.Columns["bas_levdate"].HeaderText = "휴직일자";
                    this.dataGridView1.Columns["bas_reidate"].HeaderText = "복직일자";
                    this.dataGridView1.Columns["bas_wsta"].HeaderText = "재직상태";
                    this.dataGridView1.Columns["bas_sts"].HeaderText = "신분구분";
                    this.dataGridView1.Columns["bas_pos"].HeaderText = "직급";
                    this.dataGridView1.Columns["bas_dut"].HeaderText = "직위";
                    this.dataGridView1.Columns["bas_dept"].HeaderText = "부서";
                    this.dataGridView1.Columns["bas_rmk"].HeaderText = "참고사항";
                    this.dataGridView1.Columns["bas_pos_dt"].HeaderText = "현직급일자";
                    this.dataGridView1.Columns["bas_dut_dt"].HeaderText = "현직위일자";
                    this.dataGridView1.Columns["bas_dept_dt"].HeaderText = "현부서일자";
                    this.dataGridView1.Columns["bas_intern_dt"].HeaderText = "수습/인턴일자";
                    #endregion
                }
            }
        }
        public string Empno;
        public string User;

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
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
                    Reference_Print rf = new Reference_Print();
                    rf.empno = currentInfo.bas_empno;
                    rf.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
