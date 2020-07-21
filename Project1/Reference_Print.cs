using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    public partial class Reference_Print : MetroForm
    {
        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleDataReader reader;
        public Reference_Print()
        {
            InitializeComponent();
        }

        public string empno;

        private void Reference_Print_Load(object sender, EventArgs e)
        {
            DataLoad(empno);
        }

        public void DataLoad(string str)
        {
            try
            {
                if (dBManager.GetConnection() == true)
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        ds.Clear();
                        cmd.Connection = dBManager.Connection;
                        cmd.CommandText = "select cd_codnms as 관계, fam_name as 성명, fam_bth as 생년월일, fam_ltg as 동거여부 from family_ljm where fam_empno = " + str;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "fam");
                        cmd.CommandText = "select edu_loe as 학력구분, edu_entdate as 입학일자, edu_gradate as 졸업일자, edu_schnm as 학교명, edu_dept as 학과," +
                            "edu_degree as 학위, edu_grade as 성적, edu_gra as 졸업구분, edu_last as 최종여부 from thrm_edu_ljm where edu_empno = " + str;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "edu");
                        cmd.CommandText = "select award_date as 상벌일자, award_type as 상벌구분, award_no as 상벌번호, award_kind as 상벌종별, award_organ as 시행처," +
                            "award_content as 상벌내용, award_inout as 내외구분, cd_codnms as 직급, dept_name as 소속 from award_ljm where award_empno = " + str;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "awa");
                        cmd.CommandText = "select car_com as 근무처명, car_region as 소재지, car_yyyymm_f as 근무시작월, car_yyyymm_t as 근무종료월, " +
                            "car_pos as 최종직급, car_dept as 담당부서, car_job as 담당업무, car_reason as 사유 from thrm_car_ljm where car_empno = " + str;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "car");
                        cmd.CommandText = "select cd_codnms as 자격면허, lic_grade as 급수, lic_acqdate as 취득일, lic_organ as 발급기관 from lic_ljm where lic_empno = " + str;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "lic");
                        cmd.CommandText = "select cd_codnms as 외국어, forl_score as 점수, forl_acqdate as 취득일, forl_organ as 발급기관 from forl_ljm where forl_empno = " + str;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "for");
                        dataGridView1.DataSource = ds.Tables["fam"];
                        dataGridView2.DataSource = ds.Tables["edu"];
                        dataGridView3.DataSource = ds.Tables["awa"];
                        dataGridView4.DataSource = ds.Tables["car"];
                        dataGridView5.DataSource = ds.Tables["lic"];
                        dataGridView6.DataSource = ds.Tables["for"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        Bitmap MemoryImage;
        Panel pannel = null;

        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        public void Print(Panel pnl)
        {
            pannel = pnl;
            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
