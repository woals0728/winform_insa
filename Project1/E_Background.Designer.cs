namespace Project1
{
    partial class E_Background
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataSet2 = new Project1.DataSet2();
            this.tHRMEDULJMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHRM_EDU_LJMTableAdapter = new Project1.DataSet2TableAdapters.THRM_EDU_LJMTableAdapter();
            this.eDUEMPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDULOEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDUENTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDUGRADATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDUSCHNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDUDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDUDEGREEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDUGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDUGRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDULASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRMEDULJMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.ColumnHeadersHeight = 24;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eDUEMPNODataGridViewTextBoxColumn,
            this.eDULOEDataGridViewTextBoxColumn,
            this.eDUENTDATEDataGridViewTextBoxColumn,
            this.eDUGRADATEDataGridViewTextBoxColumn,
            this.eDUSCHNMDataGridViewTextBoxColumn,
            this.eDUDEPTDataGridViewTextBoxColumn,
            this.eDUDEGREEDataGridViewTextBoxColumn,
            this.eDUGRADEDataGridViewTextBoxColumn,
            this.eDUGRADataGridViewTextBoxColumn,
            this.eDULASTDataGridViewTextBoxColumn,
            this.dATASYS1DataGridViewTextBoxColumn,
            this.dATASYS2DataGridViewTextBoxColumn,
            this.dATASYS3DataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.tHRMEDULJMBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView3.Location = new System.Drawing.Point(6, 35);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(1074, 305);
            this.dataGridView3.TabIndex = 67;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(1031, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 23);
            this.button5.TabIndex = 65;
            this.button5.Text = "취소";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(976, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 23);
            this.button6.TabIndex = 66;
            this.button6.Text = "저장";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHRMEDULJMBindingSource
            // 
            this.tHRMEDULJMBindingSource.DataMember = "THRM_EDU_LJM";
            this.tHRMEDULJMBindingSource.DataSource = this.dataSet2;
            // 
            // tHRM_EDU_LJMTableAdapter
            // 
            this.tHRM_EDU_LJMTableAdapter.ClearBeforeFill = true;
            // 
            // eDUEMPNODataGridViewTextBoxColumn
            // 
            this.eDUEMPNODataGridViewTextBoxColumn.DataPropertyName = "EDU_EMPNO";
            this.eDUEMPNODataGridViewTextBoxColumn.HeaderText = "EDU_EMPNO";
            this.eDUEMPNODataGridViewTextBoxColumn.Name = "eDUEMPNODataGridViewTextBoxColumn";
            this.eDUEMPNODataGridViewTextBoxColumn.Visible = false;
            // 
            // eDULOEDataGridViewTextBoxColumn
            // 
            this.eDULOEDataGridViewTextBoxColumn.DataPropertyName = "EDU_LOE";
            this.eDULOEDataGridViewTextBoxColumn.HeaderText = "학력구분";
            this.eDULOEDataGridViewTextBoxColumn.Name = "eDULOEDataGridViewTextBoxColumn";
            // 
            // eDUENTDATEDataGridViewTextBoxColumn
            // 
            this.eDUENTDATEDataGridViewTextBoxColumn.DataPropertyName = "EDU_ENTDATE";
            this.eDUENTDATEDataGridViewTextBoxColumn.HeaderText = "입학일자";
            this.eDUENTDATEDataGridViewTextBoxColumn.Name = "eDUENTDATEDataGridViewTextBoxColumn";
            // 
            // eDUGRADATEDataGridViewTextBoxColumn
            // 
            this.eDUGRADATEDataGridViewTextBoxColumn.DataPropertyName = "EDU_GRADATE";
            this.eDUGRADATEDataGridViewTextBoxColumn.HeaderText = "졸업일자";
            this.eDUGRADATEDataGridViewTextBoxColumn.Name = "eDUGRADATEDataGridViewTextBoxColumn";
            // 
            // eDUSCHNMDataGridViewTextBoxColumn
            // 
            this.eDUSCHNMDataGridViewTextBoxColumn.DataPropertyName = "EDU_SCHNM";
            this.eDUSCHNMDataGridViewTextBoxColumn.HeaderText = "학교명";
            this.eDUSCHNMDataGridViewTextBoxColumn.Name = "eDUSCHNMDataGridViewTextBoxColumn";
            // 
            // eDUDEPTDataGridViewTextBoxColumn
            // 
            this.eDUDEPTDataGridViewTextBoxColumn.DataPropertyName = "EDU_DEPT";
            this.eDUDEPTDataGridViewTextBoxColumn.HeaderText = "학과(전공)";
            this.eDUDEPTDataGridViewTextBoxColumn.Name = "eDUDEPTDataGridViewTextBoxColumn";
            // 
            // eDUDEGREEDataGridViewTextBoxColumn
            // 
            this.eDUDEGREEDataGridViewTextBoxColumn.DataPropertyName = "EDU_DEGREE";
            this.eDUDEGREEDataGridViewTextBoxColumn.HeaderText = "학위";
            this.eDUDEGREEDataGridViewTextBoxColumn.Name = "eDUDEGREEDataGridViewTextBoxColumn";
            // 
            // eDUGRADEDataGridViewTextBoxColumn
            // 
            this.eDUGRADEDataGridViewTextBoxColumn.DataPropertyName = "EDU_GRADE";
            this.eDUGRADEDataGridViewTextBoxColumn.HeaderText = "성적";
            this.eDUGRADEDataGridViewTextBoxColumn.Name = "eDUGRADEDataGridViewTextBoxColumn";
            // 
            // eDUGRADataGridViewTextBoxColumn
            // 
            this.eDUGRADataGridViewTextBoxColumn.DataPropertyName = "EDU_GRA";
            this.eDUGRADataGridViewTextBoxColumn.HeaderText = "졸업구분";
            this.eDUGRADataGridViewTextBoxColumn.Name = "eDUGRADataGridViewTextBoxColumn";
            // 
            // eDULASTDataGridViewTextBoxColumn
            // 
            this.eDULASTDataGridViewTextBoxColumn.DataPropertyName = "EDU_LAST";
            this.eDULASTDataGridViewTextBoxColumn.HeaderText = "최종여부";
            this.eDULASTDataGridViewTextBoxColumn.Name = "eDULASTDataGridViewTextBoxColumn";
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
            // E_Background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Name = "E_Background";
            this.Size = new System.Drawing.Size(1086, 346);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRMEDULJMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource tHRMEDULJMBindingSource;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.THRM_EDU_LJMTableAdapter tHRM_EDU_LJMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDUEMPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDULOEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDUENTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDUGRADATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDUSCHNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDUDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDUDEGREEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDUGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDUGRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDULASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS3DataGridViewTextBoxColumn;
    }
}
