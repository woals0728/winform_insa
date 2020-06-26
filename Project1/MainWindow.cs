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
using System;

namespace Project1
{
    public partial class MainWindow : MetroForm
    {
        OracleDataReader reader;
        P_information inf;
        Reference refer;
        private List<UserControl> userList;

        public MainWindow()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
            userList = new List<UserControl>();
        }

        #region 메뉴 색상 설정
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
        #endregion
        private void Form2_Load(object sender, EventArgs e)
        {
            setSubmitButton(false, Properties.Resources.submit_);
            setCancelButton(false, Properties.Resources.cancel_);
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

        private void Load_Control(UserControl ctrl)
        {
            userList.Add(ctrl);
            inf.tabControl1.TabPages.Add(ctrl.Tag.ToString());
            inf.tabControl1.TabPages[inf.tabControl1.TabPages.Count - 1].Controls.Add(ctrl);
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

            this.inf = new P_information();
            //this.InsertClick = new ButtonClick(inf.insertPerform);
            //this.UpdateClick = new ButtonClick(inf.updatePerform);
            //this.DeleteClick = new ButtonClick(inf.deletePerform);
            //this.SubmitClick = new ButtonClick(inf.submitPerform);
            //this.CancelClick = new ButtonClick(inf.cancelPerform);
            panel1.Controls.Add(inf);

            Load_Control(new Information());
            Load_Control(new Family());
            Load_Control(new E_Background());
            Load_Control(new Awards());
            Load_Control(new Career());
            Load_Control(new License());
            Load_Control(new Language());
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
            this.refer = new Reference();
            panel1.Controls.Add(refer);
        }



        public delegate void ButtonClick(object sender, EventArgs e);
        public event ButtonClick InsertClick;
        public event ButtonClick DeleteClick;
        public event ButtonClick UpdateClick;
        public event ButtonClick SubmitClick;
        public event ButtonClick CancelClick;

        #region 버튼상태제어
        public void setInsertButton(Boolean flag, Image img)
        {
            insert_button.Enabled = flag;
            insert_button.BackgroundImage = img;
        }

        public void setUpdateButton(Boolean flag, Image img)
        {
            update_button.Enabled = flag;
            update_button.BackgroundImage = img;
        }

        public void setDeleteButton(Boolean flag, Image img)
        {
            delete_button.Enabled = flag;
            delete_button.BackgroundImage = img;
        }

        public void setSubmitButton(Boolean flag, Image img)
        {
            submit_button.Enabled = flag;
            submit_button.BackgroundImage = img;
        }

        public void setCancelButton(Boolean flag, Image img)
        {
            cancel_button.Enabled = flag;
            cancel_button.BackgroundImage = img;
        }

        public void setButton_1()
        {
            setInsertButton(false, Properties.Resources.insert_);
            setDeleteButton(false, Properties.Resources.delete_);
            setUpdateButton(false, Properties.Resources.update_);
            setSubmitButton(true, Properties.Resources.submit);
            setCancelButton(true, Properties.Resources.cancel);
        }

        public void setButton_2()
        {
            setInsertButton(true, Properties.Resources.insert);
            setDeleteButton(true, Properties.Resources.delete);
            setUpdateButton(true, Properties.Resources.update);
            setSubmitButton(false, Properties.Resources.submit_);
            setCancelButton(false, Properties.Resources.cancel_);
        }
        #endregion

        private void insert_button_Click(object sender, EventArgs e)
        {
            setButton_1();
            this.InsertClick?.Invoke(sender, e);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            setButton_1();
            this.DeleteClick?.Invoke(sender, e);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            setButton_1();
            this.UpdateClick?.Invoke(sender, e);
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
                setButton_2();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            setButton_2();
            this.CancelClick?.Invoke(sender, e);
            var inf = new P_information();
            inf.cancelPerform(sender, e);
        }

        #region 버튼 툴팁
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
        #endregion

        #region REFLECTION BUTTON
        private void button_Click(object sender, EventArgs e)
        {
            Call_Method((string)(sender as Button).Tag);
        }

        private void Call_Method(String _mtd)
        {
            UserControl control = (UserControl)inf.tabControl1.SelectedTab.Controls[0];
            Type type = control.GetType();

            System.Reflection.PropertyInfo pi = type.GetProperty("mainControl");
            if(pi != null)
            {
                pi.SetValue(control, this);
            }

            System.Reflection.MethodInfo mtd = type.GetMethod(_mtd);
            mtd.Invoke(control, null);
        }
        #endregion
    }
}
