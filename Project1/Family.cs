using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Family : UserControl
    {
        public Family()
        {
            InitializeComponent();
        }

        private void fam_save_button_Click(object sender, EventArgs e)
        {
            BindingSource bs = (BindingSource)dataGridView2.DataSource;
            DataSet1 ds = bs.DataSource as DataSet1;
            //this.fAMILY_LJMTableAdapter.Update(ds.THRM_FAM_LJM);
        }

        private void Family_Load(object sender, EventArgs e)
        {
            this.fAMILY_LJMTableAdapter.Fill(this.dataSet9.FAMILY_LJM);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(item.Index);
            }
        }
    
        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = (BindingSource)dataGridView2.DataSource;
                DataSet1 ds = bs.DataSource as DataSet1;
                ds.Tables[0].Rows.Add("10001", "", "", "4", "5");
            }
            catch
            {
                MessageBox.Show("마지막 행을 작성후 추가해 주십시오.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
