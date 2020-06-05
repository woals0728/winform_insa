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
            this.tHRM_FAM_LJMTableAdapter.Update(ds.THRM_FAM_LJM);
        }

        private void Family_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn com = new DataGridViewComboBoxColumn();
            com.Name = "관계";
            com.ValueMember = "FAM_REL";
            com.DisplayMember = "FAM_REL";
            com.DataSource = this.dataSet1.THRM_FAM_LJM;
            this.tHRM_FAM_LJMTableAdapter.Fill(this.dataSet1.THRM_FAM_LJM);
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

        }
    }
}
