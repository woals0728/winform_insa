namespace Project1
{
    partial class Career
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.cAREMPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARCOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARREGIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARYYYYMMFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARYYYYMMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARPOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARJOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARREASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHRMCARLJMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new Project1.DataSet4();
            this.tHRM_CAR_LJMTableAdapter = new Project1.DataSet4TableAdapters.THRM_CAR_LJMTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.fam_save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRMCARLJMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToResizeColumns = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView5.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView5.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView5.ColumnHeadersHeight = 24;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAREMPNODataGridViewTextBoxColumn,
            this.cARCOMDataGridViewTextBoxColumn,
            this.cARREGIONDataGridViewTextBoxColumn,
            this.cARYYYYMMFDataGridViewTextBoxColumn,
            this.cARYYYYMMTDataGridViewTextBoxColumn,
            this.cARPOSDataGridViewTextBoxColumn,
            this.cARDEPTDataGridViewTextBoxColumn,
            this.cARJOBDataGridViewTextBoxColumn,
            this.cARREASONDataGridViewTextBoxColumn,
            this.dATASYS1DataGridViewTextBoxColumn,
            this.dATASYS2DataGridViewTextBoxColumn,
            this.dATASYS3DataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.tHRMCARLJMBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView5.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView5.EnableHeadersVisualStyles = false;
            this.dataGridView5.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView5.Location = new System.Drawing.Point(6, 35);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.Size = new System.Drawing.Size(1074, 279);
            this.dataGridView5.TabIndex = 67;
            // 
            // cAREMPNODataGridViewTextBoxColumn
            // 
            this.cAREMPNODataGridViewTextBoxColumn.DataPropertyName = "CAR_EMPNO";
            this.cAREMPNODataGridViewTextBoxColumn.HeaderText = "CAR_EMPNO";
            this.cAREMPNODataGridViewTextBoxColumn.Name = "cAREMPNODataGridViewTextBoxColumn";
            this.cAREMPNODataGridViewTextBoxColumn.Visible = false;
            // 
            // cARCOMDataGridViewTextBoxColumn
            // 
            this.cARCOMDataGridViewTextBoxColumn.DataPropertyName = "CAR_COM";
            this.cARCOMDataGridViewTextBoxColumn.HeaderText = "근무처명";
            this.cARCOMDataGridViewTextBoxColumn.Name = "cARCOMDataGridViewTextBoxColumn";
            // 
            // cARREGIONDataGridViewTextBoxColumn
            // 
            this.cARREGIONDataGridViewTextBoxColumn.DataPropertyName = "CAR_REGION";
            this.cARREGIONDataGridViewTextBoxColumn.HeaderText = "소재지";
            this.cARREGIONDataGridViewTextBoxColumn.Name = "cARREGIONDataGridViewTextBoxColumn";
            // 
            // cARYYYYMMFDataGridViewTextBoxColumn
            // 
            this.cARYYYYMMFDataGridViewTextBoxColumn.DataPropertyName = "CAR_YYYYMM_F";
            this.cARYYYYMMFDataGridViewTextBoxColumn.HeaderText = "근무시작월";
            this.cARYYYYMMFDataGridViewTextBoxColumn.Name = "cARYYYYMMFDataGridViewTextBoxColumn";
            // 
            // cARYYYYMMTDataGridViewTextBoxColumn
            // 
            this.cARYYYYMMTDataGridViewTextBoxColumn.DataPropertyName = "CAR_YYYYMM_T";
            this.cARYYYYMMTDataGridViewTextBoxColumn.HeaderText = "근무종료월";
            this.cARYYYYMMTDataGridViewTextBoxColumn.Name = "cARYYYYMMTDataGridViewTextBoxColumn";
            // 
            // cARPOSDataGridViewTextBoxColumn
            // 
            this.cARPOSDataGridViewTextBoxColumn.DataPropertyName = "CAR_POS";
            this.cARPOSDataGridViewTextBoxColumn.HeaderText = "최종직급";
            this.cARPOSDataGridViewTextBoxColumn.Name = "cARPOSDataGridViewTextBoxColumn";
            // 
            // cARDEPTDataGridViewTextBoxColumn
            // 
            this.cARDEPTDataGridViewTextBoxColumn.DataPropertyName = "CAR_DEPT";
            this.cARDEPTDataGridViewTextBoxColumn.HeaderText = "담당부서";
            this.cARDEPTDataGridViewTextBoxColumn.Name = "cARDEPTDataGridViewTextBoxColumn";
            // 
            // cARJOBDataGridViewTextBoxColumn
            // 
            this.cARJOBDataGridViewTextBoxColumn.DataPropertyName = "CAR_JOB";
            this.cARJOBDataGridViewTextBoxColumn.HeaderText = "담당업무";
            this.cARJOBDataGridViewTextBoxColumn.Name = "cARJOBDataGridViewTextBoxColumn";
            // 
            // cARREASONDataGridViewTextBoxColumn
            // 
            this.cARREASONDataGridViewTextBoxColumn.DataPropertyName = "CAR_REASON";
            this.cARREASONDataGridViewTextBoxColumn.HeaderText = "퇴직/이직사유";
            this.cARREASONDataGridViewTextBoxColumn.Name = "cARREASONDataGridViewTextBoxColumn";
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
            // tHRMCARLJMBindingSource
            // 
            this.tHRMCARLJMBindingSource.DataMember = "THRM_CAR_LJM";
            this.tHRMCARLJMBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHRM_CAR_LJMTableAdapter
            // 
            this.tHRM_CAR_LJMTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1031, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 71;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // delete_button
            // 
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Location = new System.Drawing.Point(1019, 6);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(61, 23);
            this.delete_button.TabIndex = 70;
            this.delete_button.Text = "행 삭제";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Location = new System.Drawing.Point(952, 6);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(61, 23);
            this.add_button.TabIndex = 68;
            this.add_button.Text = "행 추가";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // fam_save_button
            // 
            this.fam_save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fam_save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fam_save_button.ForeColor = System.Drawing.Color.White;
            this.fam_save_button.Location = new System.Drawing.Point(976, 320);
            this.fam_save_button.Name = "fam_save_button";
            this.fam_save_button.Size = new System.Drawing.Size(49, 23);
            this.fam_save_button.TabIndex = 69;
            this.fam_save_button.Text = "저장";
            this.fam_save_button.UseVisualStyleBackColor = false;
            // 
            // Career
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.fam_save_button);
            this.Controls.Add(this.dataGridView5);
            this.Name = "Career";
            this.Size = new System.Drawing.Size(1086, 346);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRMCARLJMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource tHRMCARLJMBindingSource;
        private DataSet4 dataSet4;
        private DataSet4TableAdapters.THRM_CAR_LJMTableAdapter tHRM_CAR_LJMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAREMPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARCOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARREGIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARYYYYMMFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARYYYYMMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARPOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARJOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARREASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button fam_save_button;
    }
}
