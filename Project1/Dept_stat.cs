using LiveCharts;
using LiveCharts.Wpf;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    public partial class Dept_stat : UserControl
    {
        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public Dept_stat()
        {
            InitializeComponent();
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        public void DataLoad()
        {
            try
            {
                if (dBManager.GetConnection() == true)
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        ds.Clear();
                        cmd.Connection = dBManager.Connection;
                        cmd.CommandText = "select dept_name as 부서명, count(*) as 인원수 from information_ljm group by dept_name";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Info");
                        dt = ds.Tables["Info"];
                        DataTable newTable = new DataTable();

                        newTable.Columns.Add("Field Name");
                        for (int i = 0; i < dt.Rows.Count; i++)
                            newTable.Columns.Add();

                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DataRow newRow = newTable.NewRow();

                            newRow[0] = dt.Columns[i].Caption;
                            for (int j = 0; j < dt.Rows.Count; j++)
                                newRow[j + 1] = dt.Rows[j][i];
                            newTable.Rows.Add(newRow);
                        }
                        dataGridView1.DataSource = newTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SeriesCollection series = new SeriesCollection();
            foreach (DataRow row in dt.Rows)
            {
                string title = row["부서명"].ToString();
                int value = Convert.ToInt32(row["인원수"].ToString());
                series.Add(new PieSeries() { Title = title, Values = new ChartValues<int> { value }, DataLabels = true, LabelPoint = labelPoint });
                pieChart1.Series = series;
            }

        }

        private void Dept_stat_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Left;
            pieChart1.BackColor = Color.White;
            DataLoad();
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.Landscape = true;
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
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Height, factor * bounds.Height);
        }
    }
}
