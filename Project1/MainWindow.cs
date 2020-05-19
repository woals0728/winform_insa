using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using Renci.SshNet;
using System.Security;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Media.Animation;
using System.CodeDom;

namespace Project1
{
    public partial class MainWindow : MetroForm
    {
        private static string orcl_str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=222.237.134.74)(PORT=1522)))(CONNECT_DATA=(SID=ora7)));User ID=edu;Password=edu1234";
        OracleConnection conn = new OracleConnection(orcl_str);
        OracleCommand cmd;
        OracleDataReader reader;

        public MainWindow()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
            this.인사기본사항ToolStripMenuItem.Click += 인사기본사항ToolStripMenuItem_Click;
        }


        public class MyColorTable : ProfessionalColorTable
        {
            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.Gray;
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.Gray;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            setSubmit_ButtonVisible(false, Color.Gray);
            Timer t = new Timer();
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string datePart = dt.ToString("yyyy-MM-dd HH:mm:ss");
            NOW_TIME.Text = datePart;
        }


        private void 인사기본사항ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name == "P_information")
                {
                    return;
                }
                ctrl.Dispose();
            }
            var inf = new P_information();
            this.InsertClick = new ButtonClick(inf.insertPerform);
            this.UpdateClick = new ButtonClick(inf.updatePerform);
            this.DeleteClick = new ButtonClick(inf.deletePerform);
            this.SubmitClick = new ButtonClick(inf.submitPerform);
            this.CancelClick = new ButtonClick(inf.cancelPerform);
            
            panel1.Controls.Add(inf);
        }

        

        private void 인사기록조회통합ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name == "Reference")
                {
                    return;
                }
                ctrl.Dispose();
            }
            var re = new Reference();
            panel1.Controls.Add(re);
        }



        public delegate void ButtonClick(object sender, EventArgs e);
        public event ButtonClick InsertClick;
        public event ButtonClick DeleteClick;
        public event ButtonClick UpdateClick;
        public event ButtonClick SubmitClick;
        public event ButtonClick CancelClick;

        public void setSubmit_ButtonVisible(Boolean flag, Color txt)
        {
            this.submit_button.Enabled = flag;
            this.cancel_button.Enabled = flag;
            this.submit_button.BackColor = txt;
            this.cancel_button.BackColor = txt;
        }

        public void setButton_Visible(Boolean flag, Color txt)
        {
            this.insert_button.Enabled = flag;
            this.delete_button.Enabled = flag;
            this.update_button.Enabled = flag;
            this.insert_button.BackColor = txt;
            this.delete_button.BackColor = txt;
            this.update_button.BackColor = txt;
        }

        

        private void insert_button_Click(object sender, EventArgs e)
        {
            this.InsertClick?.Invoke(sender, e);
            //var inf = new P_information();
            //inf.insertPerform(sender, e);
            setSubmit_ButtonVisible(true, Color.FromArgb(64, 64, 64));
            setButton_Visible(false, Color.Gray);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.DeleteClick?.Invoke(sender, e);
            setSubmit_ButtonVisible(true, Color.FromArgb(64,64,64));
            setButton_Visible(false, Color.Gray);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.UpdateClick?.Invoke(sender, e);
            setSubmit_ButtonVisible(true, Color.FromArgb(64,64,64));
            setButton_Visible(false, Color.Gray);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.CancelClick?.Invoke(sender, e);
            setSubmit_ButtonVisible(false, Color.Gray);
            setButton_Visible(true, Color.FromArgb(64,64,64));
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.SubmitClick?.Invoke(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                setSubmit_ButtonVisible(false, Color.Gray);
                setButton_Visible(true, Color.FromArgb(64, 64, 64));
            }
        }

        ToolTip toolTip = new ToolTip();

        private void insert_button_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.insert_button, "입력 버튼");
        }

        private void update_button_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(this.update_button, "수정 버튼");
        }

        private void delete_button_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.delete_button, "삭제 버튼");
        }

        private void submit_button_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.submit_button, "확인 버튼");
        }

        private void cancel_button_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.cancel_button, "취소 버튼");
        }
    }
}
