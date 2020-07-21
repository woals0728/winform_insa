using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    public partial class MainWindow : MetroForm
    {
        P_information inf;
        Reference refer;
        Code_info cd;
        Code_grp_info cd_grp;
        Code_dept cd_dept;
        Cert e_cert;
        Eng_cert eng_cert;
        Issuance issue;
        Pos_stat pstat;
        Dept_stat dstat;
        In_progress ipro;
        Out_progress opro;


        private List<UserControl> userList;


        public MainWindow()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable()); // 메뉴 색상 설정
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
            this.panel1.Controls.Add(new MainDisplay());
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

        public void setButton_3()
        {
            setInsertButton(false, Properties.Resources.insert_);
            setDeleteButton(false, Properties.Resources.delete_);
            setUpdateButton(false, Properties.Resources.update_);
            setSubmitButton(false, Properties.Resources.submit_);
            setCancelButton(false, Properties.Resources.cancel_);
        }
        #endregion

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

        #region Button Reflection
        private void button_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name != "P_information")
                {
                    Call_Method2((string)(sender as Button).Tag);
                }
                else
                {
                    if ((string)(sender as Button).Tag == "insert_button" || (string)(sender as Button).Tag == "update_button" || (string)(sender as Button).Tag == "delete_button")
                    {
                        Call_Method((string)(sender as Button).Tag);
                        setButton_1();
                    }
                    if ((string)(sender as Button).Tag == "submit_button" || (string)(sender as Button).Tag == "cancel_button")
                    {
                        Call_Method((string)(sender as Button).Tag);
                        setInsertButton(true, Properties.Resources.insert);
                        setDeleteButton(false, Properties.Resources.delete_);
                        setUpdateButton(false, Properties.Resources.update_);
                        setSubmitButton(false, Properties.Resources.submit_);
                        setCancelButton(false, Properties.Resources.cancel_);
                    }
                }
            }

        }

        private void Call_Method(String _mtd)
        {
            UserControl control = (UserControl)inf.tabControl1.SelectedTab.Controls[0];
            Type type = control.GetType();

            System.Reflection.PropertyInfo pi = type.GetProperty("mainControl");
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

        private void Call_Method2(String _mtd)
        {
            UserControl control = (UserControl)panel1.Controls[0];
            Type type = control.GetType();

            System.Reflection.MethodInfo mtd = type.GetMethod(_mtd);
            if (_mtd == null || mtd == null)
            {
                return;
            }
            mtd.Invoke(control, null);
        }

        #endregion

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

            string user = USER.Text;
            this.inf = new P_information();
            inf.User = user;
            panel1.Controls.Add(inf);
            Load_Control(new Information());
            Load_Control(new Family());
            Load_Control(new E_Background());
            Load_Control(new Awards());
            Load_Control(new Career());
            Load_Control(new License());
            Load_Control(new Language());
            UserControl control = (UserControl)panel1.Controls[0];
            Type type = control.GetType();
            System.Reflection.PropertyInfo pi = type.GetProperty("main_P");
            if (pi != null)
            {
                pi.SetValue(control, this);
            }
            setInsertButton(true, Properties.Resources.insert);
            setDeleteButton(false, Properties.Resources.delete_);
            setUpdateButton(false, Properties.Resources.update_);
            setSubmitButton(false, Properties.Resources.submit_);
            setCancelButton(false, Properties.Resources.cancel_);
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
            string user = USER.Text;
            this.refer = new Reference();
            refer.User = user;
            panel1.Controls.Add(refer);
            UserControl control = (UserControl)panel1.Controls[0];
            Type type = control.GetType();
            System.Reflection.PropertyInfo pi = type.GetProperty("main_P");
            if (pi != null)
            {
                pi.SetValue(control, this);
            }
            setButton_3();
        }

        private void 코드관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name == "Code_info")
                {
                    return;
                }
                ctrl.Dispose();
            }
            this.cd = new Code_info();
            cd.user = USER.Text;
            panel1.Controls.Add(cd);
            setButton_1();
        }

        private void 코드그룹관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name == "Code_grp_info")
                {
                    return;
                }
                ctrl.Dispose();
            }
            this.cd_grp = new Code_grp_info();
            panel1.Controls.Add(cd_grp);
            setButton_1();
        }

        private void 부서코드관리ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name == "Code_dept")
                {
                    return;
                }
                ctrl.Dispose();
            }
            this.cd_dept = new Code_dept();
            cd_dept.user = USER.Text;
            panel1.Controls.Add(cd_dept);
            setButton_1();
        }

        private void 재직증명서ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name == "Cert")
                {
                    return;
                }
                ctrl.Dispose();
            }
            this.e_cert = new Cert();
            e_cert.User = USER.Text;
            panel1.Controls.Add(e_cert);
            setButton_3();
        }

        private void 제증명서발급대장조회ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name == "Issuance")
                {
                    return;
                }
                ctrl.Dispose();
            }
            this.issue = new Issuance();
            panel1.Controls.Add(issue);
            setButton_3();
        }

        private void 부서별인원현황ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name == "Dept_stat")
                {
                    return;
                }
                ctrl.Dispose();
            }
            this.dstat = new Dept_stat();
            panel1.Controls.Add(dstat);
            setButton_3();
        }

        private void 직급별인원현황ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name == "Pos_stat")
                {
                    return;
                }
                ctrl.Dispose();
            }
            this.pstat = new Pos_stat();
            panel1.Controls.Add(pstat);
            setButton_3();
        }

        private void 입사인원추이ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name == "In_progress")
                {
                    return;
                }
                ctrl.Dispose();
            }
            this.ipro = new In_progress();
            panel1.Controls.Add(ipro);
            setButton_3();
        }

        private void 퇴사인원추이ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name == "Out_progress")
                {
                    return;
                }
                ctrl.Dispose();
            }
            this.opro = new Out_progress();
            panel1.Controls.Add(opro);
            setButton_3();
        }
    }
}