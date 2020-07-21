using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    public partial class Career_cert : MetroForm
    {
        OracleDBManager dBManager = new OracleDBManager();

        OracleDataReader reader;
        public Career_cert()
        {
            InitializeComponent();
        }

        private void Career_cert_Load(object sender, EventArgs e)
        {

        }

        public string user;
        public string empno;

        private void print_button_Click(object sender, EventArgs e)
        {
            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    OracleTransaction tran = dBManager.Connection.BeginTransaction();
                    cmd.Transaction = tran;
                    cmd.Connection = dBManager.Connection;
                    try
                    {
                        cmd.CommandText = "select * from thrm_ceri_ljm where CERI_EMPNO = '" + empno + "' and CERI_KIND = '경력' and CERI_DATE = '" + DateTime.Now.ToString("yyyyMMdd") + "'";
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            if (MessageBox.Show("이미 인쇄하신 내역이 있습니다." + Environment.NewLine + "재발급 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                cmd.CommandText = "update thrm_ceri_ljm set DATASYS1 = '" + DateTime.Now.ToString("yy/MM/dd") + "' where CERI_EMPNO = '" + empno + "' " +
                                    "and CERI_KIND = '경력' and CERI_DATE = '" + DateTime.Now.ToString("yyyyMMdd") + "'";
                                cmd.ExecuteNonQuery();
                                tran.Commit();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            cmd.CommandText = "insert into thrm_ceri_ljm values('" + empno + "', '경력', (select max(ceri_no)+1 from thrm_ceri_ljm), '" + DateTime.Now.ToString("yyyyMMdd") + "'," +
                                "'국문', 1, '" + DateTime.Now.ToString("yy/MM/dd") + "', 'A', '" + user + "')";
                            cmd.ExecuteNonQuery();
                            tran.Commit();
                        }
                    }
                    catch(Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Panel grd = new Panel();
            grd = panel1;
            Bitmap bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
            grd.DrawToBitmap(bmp, new Rectangle(0, 0, grd.Width, grd.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }
    }
}
