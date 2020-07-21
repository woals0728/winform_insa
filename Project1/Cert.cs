using Newtonsoft.Json.Linq;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class Cert : UserControl
    {
        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        OracleDataReader reader;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        List<INFO> info_data = new List<INFO>();
        private BindingSource infoBindingSource = new BindingSource();
        private INFO.SortableBindingList<INFO> infoBindingList;
        public Cert()
        {
            InitializeComponent();
        }

        private void Emp_cert_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        public void DataLoad()
        {
            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = dBManager.Connection;

                    cmd.CommandText = "select * from INFORMATION_LJM order by bas_empno";
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
                    this.dataGridView1.Columns["bas_resno1"].HeaderText = "생년월일";
                    this.dataGridView1.Columns["bas_resno2"].Visible = false;
                    this.dataGridView1.Columns["bas_name"].HeaderText = "성명";
                    this.dataGridView1.Columns["bas_cname"].Visible = false;
                    this.dataGridView1.Columns["bas_ename"].Visible = false;
                    this.dataGridView1.Columns["bas_fix"].Visible = false;
                    this.dataGridView1.Columns["bas_zip"].Visible = false;
                    this.dataGridView1.Columns["bas_addr"].HeaderText = "주소";
                    this.dataGridView1.Columns["bas_residence"].Visible = false;
                    this.dataGridView1.Columns["bas_hdpno"].HeaderText = "연락처";
                    this.dataGridView1.Columns["bas_telno"].Visible = false;
                    this.dataGridView1.Columns["bas_email"].Visible = false;
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
                    this.dataGridView1.Columns["bas_entdate"].HeaderText = "입사일자";
                    this.dataGridView1.Columns["bas_resdate"].Visible = false;
                    this.dataGridView1.Columns["bas_levdate"].Visible = false;
                    this.dataGridView1.Columns["bas_reidate"].Visible = false;
                    this.dataGridView1.Columns["bas_wsta"].Visible = false;
                    this.dataGridView1.Columns["bas_sts"].Visible = false;
                    this.dataGridView1.Columns["bas_pos"].Visible = false;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (comboBox1.Text == "선택")
            {
                MessageBox.Show("증명서 구분을 선택해 주세요.");
                return;
            }
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("사용 용도를 입력해 주세요.");
                return;
            }
            try
            {
                int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = this.dataGridView1.Rows[rowIndex];
                INFO currentInfo = row.DataBoundItem as INFO;
                if (currentInfo != null)
                {
                    if (comboBox1.Text == "재직증명서")
                    {
                        Emp_cert ec = new Emp_cert();
                        string[] result = currentInfo.bas_dut.Split(new string[] { ":" }, StringSplitOptions.None);
                        string dut = result[1];
                        string[] result2 = currentInfo.bas_dept.Split(new string[] { ":" }, StringSplitOptions.None);
                        string dept = result2[1];
                        ec.name.Text = currentInfo.bas_name;
                        ec.birth.Text = currentInfo.bas_resno1;
                        ec.address.Text = currentInfo.bas_addr;
                        ec.phone.Text = currentInfo.bas_hdpno;
                        ec.dept.Text = dept;
                        ec.entdate.Text = currentInfo.bas_entdate;
                        ec.dut.Text = dut;
                        ec.use.Text = textBox1.Text;
                        ec.year.Text = DateTime.Now.ToString("yyyy");
                        ec.month.Text = DateTime.Now.ToString("MM");
                        ec.day.Text = DateTime.Now.ToString("dd");
                        ec.empno = currentInfo.bas_empno;
                        ec.user = User;
                        ec.ShowDialog();
                    }
                    if (comboBox1.Text == "경력증명서")
                    {
                        if (dBManager.GetConnection() == true)
                        {
                            using (OracleCommand cmd = new OracleCommand())
                            {
                                cmd.Connection = dBManager.Connection;
                                cmd.CommandText = "select * from thrm_car_ljm where car_empno = '" + currentInfo.bas_empno + "'";
                                reader = cmd.ExecuteReader();

                                Career_cert cc = new Career_cert();
                                string[] result = currentInfo.bas_dut.Split(new string[] { ":" }, StringSplitOptions.None);
                                string dut = result[1];
                                string[] result2 = currentInfo.bas_dept.Split(new string[] { ":" }, StringSplitOptions.None);
                                string dept = result2[1];
                                cc.name.Text = currentInfo.bas_name;
                                cc.birth.Text = currentInfo.bas_resno1;
                                cc.address.Text = currentInfo.bas_addr;
                                cc.dept.Text = dept;
                                cc.dut.Text = dut;
                                cc.use.Text = textBox1.Text;
                                cc.year.Text = DateTime.Now.ToString("yyyy");
                                cc.month.Text = DateTime.Now.ToString("MM");
                                cc.day.Text = DateTime.Now.ToString("dd");
                                cc.empno = currentInfo.bas_empno;
                                cc.user = User;
                                if (reader.Read())
                                {
                                    cc.car_dept.Text = reader["car_dept"].ToString();
                                    cc.car_job.Text = reader["car_job"].ToString();
                                    cc.f_date.Text = reader["car_yyyymm_f"].ToString();
                                    cc.t_date.Text = reader["car_yyyymm_t"].ToString();
                                }
                                else
                                {
                                    cc.car_dept.Text = "";
                                    cc.car_job.Text = "";
                                    cc.f_date.Text = "";
                                    cc.t_date.Text = "";
                                }
                                cc.ShowDialog();
                            }
                        }

                    }
                    if (comboBox1.Text == "영문증명서")
                    {

                        Eng_cert enc = new Eng_cert();
                        string[] result = currentInfo.bas_dut.Split(new string[] { ":" }, StringSplitOptions.None);
                        string dut = result[1];
                        string[] result2 = currentInfo.bas_dept.Split(new string[] { ":" }, StringSplitOptions.None);
                        string dept = result2[1];


                        enc.name.Text = Papago(currentInfo.bas_name);
                        enc.birth.Text = currentInfo.bas_resno1;
                        enc.address.Text = Papago(currentInfo.bas_addr);
                        enc.phone.Text = currentInfo.bas_hdpno;
                        enc.dept.Text = Papago(dept);
                        enc.entdate.Text = currentInfo.bas_entdate;
                        enc.dut.Text = Papago(dut);
                        enc.use.Text = Papago(textBox1.Text);
                        CultureInfo culture = new CultureInfo("en-US");
                        enc.year.Text = DateTime.Now.ToString("MMMM/dd/yyyy", culture);
                        enc.empno = currentInfo.bas_empno;
                        enc.user = User;
                        enc.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string Papago(string str)
        {
            // 요청 URL
            string sUrl = "https://openapi.naver.com/v1/papago/n2mt";

            // 파라미터에 값넣기 (파파고 NMT API 가이드에서 -d 부분이 파라미터이다)
            string sParam = string.Format("source=ko&target=en&text=" + str);

            // 파라미터를 Character Set에 맞게 변경
            byte[] bytearry = Encoding.UTF8.GetBytes(sParam);

            // 서버에 요청
            WebRequest webRequest = WebRequest.Create(sUrl);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";

            // 헤더 추가하기 (파파고 NMT API 가이드에서 -h 부분이 헤더이다)
            webRequest.Headers.Add("X-Naver-Client-Id", "jvdOeQWd9ADDKNUXFmfu");
            webRequest.Headers.Add("X-Naver-Client-Secret", "kiWb4IuOmZ");

            // 요청 데이터 길이
            webRequest.ContentLength = bytearry.Length;

            Stream stream = webRequest.GetRequestStream();
            stream.Write(bytearry, 0, bytearry.Length);
            stream.Close();

            // 응답 데이터 가져오기(출력포맷)
            WebResponse webResponse = webRequest.GetResponse();
            stream = webResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string sReturn = streamReader.ReadToEnd();

            streamReader.Close();
            stream.Close();
            webResponse.Close();


            JObject jObject = JObject.Parse(sReturn);

            // JSON 출력포맷에서 필요한 부분(번역된 문장)만 가져오기
            return str = jObject["message"]["result"]["translatedText"].ToString();
        }

        public string User;
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
