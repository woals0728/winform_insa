using LiveCharts;
using LiveCharts.Wpf;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project1
{
    public partial class Out_progress : UserControl
    {
        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleDataReader reader;
        public Out_progress()
        {
            InitializeComponent();
        }

        public class Date
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public double Value { get; set; }

            public Date(int year, int month, double value)
            {
                this.Year = year;
                this.Month = month;
                this.Value = value;
            }

            public class DateBindingList<T> : BindingList<T> where T : class
            {

                public DateBindingList(IList<T> list) : base(list)
                {

                }
            }
        }

        List<Date> date = new List<Date>();
        private BindingSource source = new BindingSource();
        private Date.DateBindingList<Date> bindingList;

        private void Out_progress_Load(object sender, EventArgs e)
        {
            DataLoad();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "월",
                Labels = new[] { "1월", "2월", "3월", "4월", "5월", "6월", "7월", "8월", "9월", "10월", "11월", "12월" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "명",
                LabelFormatter = value => value.ToString()
            });
            cartesianChart1.LegendLocation = LegendLocation.Left;
            cartesianChart1.BackColorTransparent = true;

            chartLoad();
        }

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
                        cmd.CommandText = "select substr(lpad(bas_resdate, 10, '20'),1,4) " +
                            "as Year, substr(lpad(bas_resdate, 10, '20'),6,2) as Month, count(*) as Value from thrm_bas_ljm where bas_wsta = '퇴직' " +
                            "group by substr(lpad(bas_resdate, 10, '20'),1,4), substr(lpad(bas_resdate, 10, '20'),6,2)";
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            date.Add(new Date(
                                Convert.ToInt32(reader["Year"].ToString()),
                                Convert.ToInt32(reader["Month"].ToString()),
                                Convert.ToInt32(reader["Value"].ToString())
                                ));
                        }
                        bindingList = new Date.DateBindingList<Date>(date);
                        source.DataSource = bindingList;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void chartLoad()
        {
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in source.DataSource as Date.DateBindingList<Date> select new { Year = o.Year }).Distinct();
            foreach (var year in years)
            {
                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in source.DataSource as Date.DateBindingList<Date>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Value, o.Month };
                    if (data.SingleOrDefault() != null)
                    {
                        value = data.SingleOrDefault().Value;
                    }
                    values.Add(value);
                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChart1.Series = series;
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
