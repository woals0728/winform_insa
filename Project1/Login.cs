using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;
using Project1.Properties;
using System;
using System.Windows.Forms;

namespace Project1
{
    public partial class Login : MetroForm
    {
        OracleDBManager dBManager = new OracleDBManager();

        OracleDataReader reader;

        public Login()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("아이디를 입력하세요.");
                return;
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("비밀번호를 입력하세요.");
                return;
            }

            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = dBManager.Connection;

                    cmd.CommandText = "select id from ADMIN_LJM where id = '" + textBox1.Text + "'";

                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        cmd.CommandText = "select * from ADMIN_LJM where pwd = '" + textBox2.Text + "' and id = '" + textBox1.Text + "'";
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            String admin_name = reader.GetString(2);
                            String admin_auth = reader.GetString(3);
                            string admin = admin_name + "(" + admin_auth + ")";
                            Hide();
                            MessageBox.Show(admin_name + "님 로그인 되었습니다.", "");
                            MainWindow f2 = new MainWindow();
                            f2.ADMIN_NAME.Text = admin;
                            f2.LOGIN_TIME.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            f2.ShowDialog();
                            f2 = null;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("비밀번호를 확인해주세요.");
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("아이디를 확인해주세요.");
                        return;
                    }
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButton1_Click(sender, e);
            }
            else
            {
                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default["login_id"].ToString();
            checkBox1.Checked = Settings.Default.ckd_id;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Settings.Default["login_id"] = textBox1.Text;
                Settings.Default["ckd_id"] = checkBox1.Checked;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default["login_id"] = "";

                Settings.Default["ckd_id"] = checkBox1.Checked;
                Settings.Default.Save();
            }
        }



    }
}
