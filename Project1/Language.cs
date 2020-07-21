using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Project1
{
    public partial class Language : UserControl
    {
        public MainWindow mainControl { get; set; }

        OracleDBManager dBManager = new OracleDBManager();
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleDataReader reader;

        public P_information P_info { get; set; }
        public Language()
        {
            InitializeComponent();
        }

        public string empno;

        private void save_button_Click(object sender, EventArgs e)
        {
            if (dBManager.GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    OracleTransaction tran = dBManager.Connection.BeginTransaction();
                    cmd.Transaction = tran;
                    cmd.Connection = dBManager.Connection;

                    empno = P_info.Empno;
                    cmd.CommandText = "select * from thrm_forl_ljm where forl_empno = " + empno;
                    adapter.SelectCommand = cmd;
                    try
                    {
                        OracleCommandBuilder cb = new OracleCommandBuilder(adapter);
                        adapter.Update(ds, "Info");
                        dataGridView7.DataSource = ds.Tables["Info"];
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        tran.Rollback();
                    }

                }
            }
        }


        private void delete_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 정보를 삭제 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView7.SelectedRows)
                {
                    dataGridView7.Rows.RemoveAt(item.Index);
                }
            }
            else
            {
                return;
            }

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                empno = P_info.Empno;
                string user = P_info.User;
                dataGridView7.DataSource = ds.Tables["Info"];
                ds.Tables["Info"].Rows.Add(empno, "", "", "", "", DateTime.Now, "A", user);

            }
            catch
            {

            }
        }

        public void DataLoad()
        {
            try
            {
                if (empno == P_info.Empno)
                {
                    return;
                }
                if (dBManager.GetConnection() == true)
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        ds.Clear();
                        cmd.Connection = dBManager.Connection;
                        cmd.CommandText = "select cd_code, cd_codnms from tieas_cd_ljm where cd_grpcd='FOR' and cd_use = 'Y'";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Code");
                        empno = P_info.Empno;
                        cmd.CommandText = "select * from thrm_forl_ljm where forl_empno = " + empno;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Info");
                        dataGridView7.DataSource = ds.Tables["Info"];
                        this.dataGridView7.Columns["FORL_EMPNO"].Visible = false;
                        this.dataGridView7.Columns["FORL_SCORE"].HeaderText = "점수";
                        this.dataGridView7.Columns["FORL_ACQDATE"].HeaderText = "취득일";
                        this.dataGridView7.Columns["FORL_ORGAN"].HeaderText = "발급기관";
                        ((DataGridViewTextBoxColumn)dataGridView7.Columns["FORL_ACQDATE"]).MaxInputLength = 8;
                        this.dataGridView7.Columns["DATASYS1"].Visible = false;
                        this.dataGridView7.Columns["DATASYS2"].Visible = false;
                        this.dataGridView7.Columns["DATASYS3"].Visible = false;
                        dataGridView7.Columns.Remove("FORL_CODE");
                        AddComboBoxColumns();
                    }
                }
            }
            catch
            {

            }
        }

        private void AddComboBoxColumns()
        {
            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            {
                col.DataPropertyName = "FORL_CODE";
                col.FlatStyle = FlatStyle.Flat;
            }
            col.DataSource = ds.Tables["Code"];
            col.DisplayMember = "CD_CODNMS";
            col.ValueMember = "CD_CODE";
            col.HeaderText = "외국어코드";
            dataGridView7.Columns.Insert(1, col);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("작성중인 사항을 저장하지 않고 취소하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                empno = "";
                DataLoad();
            }
            else
            {
                return;
            }
        }
    }
}
