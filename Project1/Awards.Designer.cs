namespace Project1
{
    partial class Awards
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataSet3 = new Project1.DataSet3();
            this.tHRMAWARDLJMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHRM_AWARD_LJMTableAdapter = new Project1.DataSet3TableAdapters.THRM_AWARD_LJMTableAdapter();
            this.aWARDEMPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWARDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWARDTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWARDNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWARDKINDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWARDORGANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWARDCONTENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWARDINOUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWARDPOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWARDDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRMAWARDLJMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView4.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView4.ColumnHeadersHeight = 24;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aWARDEMPNODataGridViewTextBoxColumn,
            this.aWARDDATEDataGridViewTextBoxColumn,
            this.aWARDTYPEDataGridViewTextBoxColumn,
            this.aWARDNODataGridViewTextBoxColumn,
            this.aWARDKINDDataGridViewTextBoxColumn,
            this.aWARDORGANDataGridViewTextBoxColumn,
            this.aWARDCONTENTDataGridViewTextBoxColumn,
            this.aWARDINOUTDataGridViewTextBoxColumn,
            this.aWARDPOSDataGridViewTextBoxColumn,
            this.aWARDDEPTDataGridViewTextBoxColumn,
            this.dATASYS1DataGridViewTextBoxColumn,
            this.dATASYS2DataGridViewTextBoxColumn,
            this.dATASYS3DataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.tHRMAWARDLJMBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView4.EnableHeadersVisualStyles = false;
            this.dataGridView4.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView4.Location = new System.Drawing.Point(6, 35);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(1074, 305);
            this.dataGridView4.TabIndex = 67;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1031, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 23);
            this.button7.TabIndex = 65;
            this.button7.Text = "취소";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(976, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 23);
            this.button8.TabIndex = 66;
            this.button8.Text = "저장";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHRMAWARDLJMBindingSource
            // 
            this.tHRMAWARDLJMBindingSource.DataMember = "THRM_AWARD_LJM";
            this.tHRMAWARDLJMBindingSource.DataSource = this.dataSet3;
            // 
            // tHRM_AWARD_LJMTableAdapter
            // 
            this.tHRM_AWARD_LJMTableAdapter.ClearBeforeFill = true;
            // 
            // aWARDEMPNODataGridViewTextBoxColumn
            // 
            this.aWARDEMPNODataGridViewTextBoxColumn.DataPropertyName = "AWARD_EMPNO";
            this.aWARDEMPNODataGridViewTextBoxColumn.HeaderText = "AWARD_EMPNO";
            this.aWARDEMPNODataGridViewTextBoxColumn.Name = "aWARDEMPNODataGridViewTextBoxColumn";
            this.aWARDEMPNODataGridViewTextBoxColumn.Visible = false;
            // 
            // aWARDDATEDataGridViewTextBoxColumn
            // 
            this.aWARDDATEDataGridViewTextBoxColumn.DataPropertyName = "AWARD_DATE";
            this.aWARDDATEDataGridViewTextBoxColumn.HeaderText = "상벌일자";
            this.aWARDDATEDataGridViewTextBoxColumn.Name = "aWARDDATEDataGridViewTextBoxColumn";
            // 
            // aWARDTYPEDataGridViewTextBoxColumn
            // 
            this.aWARDTYPEDataGridViewTextBoxColumn.DataPropertyName = "AWARD_TYPE";
            this.aWARDTYPEDataGridViewTextBoxColumn.HeaderText = "상벌구분";
            this.aWARDTYPEDataGridViewTextBoxColumn.Name = "aWARDTYPEDataGridViewTextBoxColumn";
            // 
            // aWARDNODataGridViewTextBoxColumn
            // 
            this.aWARDNODataGridViewTextBoxColumn.DataPropertyName = "AWARD_NO";
            this.aWARDNODataGridViewTextBoxColumn.HeaderText = "상벌번호";
            this.aWARDNODataGridViewTextBoxColumn.Name = "aWARDNODataGridViewTextBoxColumn";
            // 
            // aWARDKINDDataGridViewTextBoxColumn
            // 
            this.aWARDKINDDataGridViewTextBoxColumn.DataPropertyName = "AWARD_KIND";
            this.aWARDKINDDataGridViewTextBoxColumn.HeaderText = "상벌종별";
            this.aWARDKINDDataGridViewTextBoxColumn.Name = "aWARDKINDDataGridViewTextBoxColumn";
            // 
            // aWARDORGANDataGridViewTextBoxColumn
            // 
            this.aWARDORGANDataGridViewTextBoxColumn.DataPropertyName = "AWARD_ORGAN";
            this.aWARDORGANDataGridViewTextBoxColumn.HeaderText = "시행처";
            this.aWARDORGANDataGridViewTextBoxColumn.Name = "aWARDORGANDataGridViewTextBoxColumn";
            // 
            // aWARDCONTENTDataGridViewTextBoxColumn
            // 
            this.aWARDCONTENTDataGridViewTextBoxColumn.DataPropertyName = "AWARD_CONTENT";
            this.aWARDCONTENTDataGridViewTextBoxColumn.HeaderText = "상벌내용";
            this.aWARDCONTENTDataGridViewTextBoxColumn.Name = "aWARDCONTENTDataGridViewTextBoxColumn";
            // 
            // aWARDINOUTDataGridViewTextBoxColumn
            // 
            this.aWARDINOUTDataGridViewTextBoxColumn.DataPropertyName = "AWARD_INOUT";
            this.aWARDINOUTDataGridViewTextBoxColumn.HeaderText = "내외구분";
            this.aWARDINOUTDataGridViewTextBoxColumn.Name = "aWARDINOUTDataGridViewTextBoxColumn";
            // 
            // aWARDPOSDataGridViewTextBoxColumn
            // 
            this.aWARDPOSDataGridViewTextBoxColumn.DataPropertyName = "AWARD_POS";
            this.aWARDPOSDataGridViewTextBoxColumn.HeaderText = "직급";
            this.aWARDPOSDataGridViewTextBoxColumn.Name = "aWARDPOSDataGridViewTextBoxColumn";
            // 
            // aWARDDEPTDataGridViewTextBoxColumn
            // 
            this.aWARDDEPTDataGridViewTextBoxColumn.DataPropertyName = "AWARD_DEPT";
            this.aWARDDEPTDataGridViewTextBoxColumn.HeaderText = "소속";
            this.aWARDDEPTDataGridViewTextBoxColumn.Name = "aWARDDEPTDataGridViewTextBoxColumn";
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
            // Awards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Name = "Awards";
            this.Size = new System.Drawing.Size(1086, 346);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRMAWARDLJMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.BindingSource tHRMAWARDLJMBindingSource;
        private DataSet3 dataSet3;
        private DataSet3TableAdapters.THRM_AWARD_LJMTableAdapter tHRM_AWARD_LJMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWARDEMPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWARDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWARDTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWARDNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWARDKINDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWARDORGANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWARDCONTENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWARDINOUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWARDPOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWARDDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS3DataGridViewTextBoxColumn;
    }
}
