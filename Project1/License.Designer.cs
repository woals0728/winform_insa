﻿namespace Project1
{
    partial class License
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.dataSet5 = new Project1.DataSet5();
            this.tHRMLICLJMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHRM_LIC_LJMTableAdapter = new Project1.DataSet5TableAdapters.THRM_LIC_LJMTableAdapter();
            this.lICEMPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lICCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lICGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lICACQDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lICORGANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRMLICLJMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AllowUserToResizeColumns = false;
            this.dataGridView6.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView6.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView6.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView6.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView6.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView6.ColumnHeadersHeight = 24;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lICEMPNODataGridViewTextBoxColumn,
            this.lICCODEDataGridViewTextBoxColumn,
            this.lICGRADEDataGridViewTextBoxColumn,
            this.lICACQDATEDataGridViewTextBoxColumn,
            this.lICORGANDataGridViewTextBoxColumn,
            this.dATASYS1DataGridViewTextBoxColumn,
            this.dATASYS2DataGridViewTextBoxColumn,
            this.dATASYS3DataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.tHRMLICLJMBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView6.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView6.EnableHeadersVisualStyles = false;
            this.dataGridView6.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView6.Location = new System.Drawing.Point(6, 35);
            this.dataGridView6.MultiSelect = false;
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView6.RowHeadersVisible = false;
            this.dataGridView6.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView6.RowTemplate.Height = 23;
            this.dataGridView6.Size = new System.Drawing.Size(1074, 305);
            this.dataGridView6.TabIndex = 67;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(1031, 6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(49, 23);
            this.button11.TabIndex = 65;
            this.button11.Text = "취소";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(976, 6);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(49, 23);
            this.button12.TabIndex = 66;
            this.button12.Text = "저장";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHRMLICLJMBindingSource
            // 
            this.tHRMLICLJMBindingSource.DataMember = "THRM_LIC_LJM";
            this.tHRMLICLJMBindingSource.DataSource = this.dataSet5;
            // 
            // tHRM_LIC_LJMTableAdapter
            // 
            this.tHRM_LIC_LJMTableAdapter.ClearBeforeFill = true;
            // 
            // lICEMPNODataGridViewTextBoxColumn
            // 
            this.lICEMPNODataGridViewTextBoxColumn.DataPropertyName = "LIC_EMPNO";
            this.lICEMPNODataGridViewTextBoxColumn.HeaderText = "LIC_EMPNO";
            this.lICEMPNODataGridViewTextBoxColumn.Name = "lICEMPNODataGridViewTextBoxColumn";
            this.lICEMPNODataGridViewTextBoxColumn.Visible = false;
            // 
            // lICCODEDataGridViewTextBoxColumn
            // 
            this.lICCODEDataGridViewTextBoxColumn.DataPropertyName = "LIC_CODE";
            this.lICCODEDataGridViewTextBoxColumn.HeaderText = "자격면허코드";
            this.lICCODEDataGridViewTextBoxColumn.Name = "lICCODEDataGridViewTextBoxColumn";
            // 
            // lICGRADEDataGridViewTextBoxColumn
            // 
            this.lICGRADEDataGridViewTextBoxColumn.DataPropertyName = "LIC_GRADE";
            this.lICGRADEDataGridViewTextBoxColumn.HeaderText = "급수";
            this.lICGRADEDataGridViewTextBoxColumn.Name = "lICGRADEDataGridViewTextBoxColumn";
            // 
            // lICACQDATEDataGridViewTextBoxColumn
            // 
            this.lICACQDATEDataGridViewTextBoxColumn.DataPropertyName = "LIC_ACQDATE";
            this.lICACQDATEDataGridViewTextBoxColumn.HeaderText = "취득일";
            this.lICACQDATEDataGridViewTextBoxColumn.Name = "lICACQDATEDataGridViewTextBoxColumn";
            // 
            // lICORGANDataGridViewTextBoxColumn
            // 
            this.lICORGANDataGridViewTextBoxColumn.DataPropertyName = "LIC_ORGAN";
            this.lICORGANDataGridViewTextBoxColumn.HeaderText = "발급기관";
            this.lICORGANDataGridViewTextBoxColumn.Name = "lICORGANDataGridViewTextBoxColumn";
            // 
            // dATASYS1DataGridViewTextBoxColumn
            // 
            this.dATASYS1DataGridViewTextBoxColumn.DataPropertyName = "DATASYS1";
            this.dATASYS1DataGridViewTextBoxColumn.HeaderText = "DATASYS1";
            this.dATASYS1DataGridViewTextBoxColumn.Name = "dATASYS1DataGridViewTextBoxColumn";
            this.dATASYS1DataGridViewTextBoxColumn.Visible = false;
            // 
            // dATASYS2DataGridViewTextBoxColumn
            // 
            this.dATASYS2DataGridViewTextBoxColumn.DataPropertyName = "DATASYS2";
            this.dATASYS2DataGridViewTextBoxColumn.HeaderText = "DATASYS2";
            this.dATASYS2DataGridViewTextBoxColumn.Name = "dATASYS2DataGridViewTextBoxColumn";
            this.dATASYS2DataGridViewTextBoxColumn.Visible = false;
            // 
            // dATASYS3DataGridViewTextBoxColumn
            // 
            this.dATASYS3DataGridViewTextBoxColumn.DataPropertyName = "DATASYS3";
            this.dATASYS3DataGridViewTextBoxColumn.HeaderText = "DATASYS3";
            this.dATASYS3DataGridViewTextBoxColumn.Name = "dATASYS3DataGridViewTextBoxColumn";
            this.dATASYS3DataGridViewTextBoxColumn.Visible = false;
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Name = "License";
            this.Size = new System.Drawing.Size(1086, 346);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRMLICLJMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.BindingSource tHRMLICLJMBindingSource;
        private DataSet5 dataSet5;
        private DataSet5TableAdapters.THRM_LIC_LJMTableAdapter tHRM_LIC_LJMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lICEMPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lICCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lICGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lICACQDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lICORGANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS3DataGridViewTextBoxColumn;
    }
}