namespace Project1
{
    partial class Language
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
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.fORLEMPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORLCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORLSCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORLACQDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORLORGANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHRMFORLLJMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new Project1.DataSet6();
            this.tHRM_FORL_LJMTableAdapter = new Project1.DataSet6TableAdapters.THRM_FORL_LJMTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.fam_save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRMFORLLJMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.AllowUserToDeleteRows = false;
            this.dataGridView7.AllowUserToResizeColumns = false;
            this.dataGridView7.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView7.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView7.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView7.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView7.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView7.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView7.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView7.ColumnHeadersHeight = 24;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fORLEMPNODataGridViewTextBoxColumn,
            this.fORLCODEDataGridViewTextBoxColumn,
            this.fORLSCOREDataGridViewTextBoxColumn,
            this.fORLACQDATEDataGridViewTextBoxColumn,
            this.fORLORGANDataGridViewTextBoxColumn,
            this.dATASYS1DataGridViewTextBoxColumn,
            this.dATASYS2DataGridViewTextBoxColumn,
            this.dATASYS3DataGridViewTextBoxColumn});
            this.dataGridView7.DataSource = this.tHRMFORLLJMBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView7.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView7.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView7.EnableHeadersVisualStyles = false;
            this.dataGridView7.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView7.Location = new System.Drawing.Point(6, 35);
            this.dataGridView7.MultiSelect = false;
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView7.RowHeadersVisible = false;
            this.dataGridView7.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView7.RowTemplate.Height = 23;
            this.dataGridView7.Size = new System.Drawing.Size(1074, 279);
            this.dataGridView7.TabIndex = 67;
            // 
            // fORLEMPNODataGridViewTextBoxColumn
            // 
            this.fORLEMPNODataGridViewTextBoxColumn.DataPropertyName = "FORL_EMPNO";
            this.fORLEMPNODataGridViewTextBoxColumn.HeaderText = "FORL_EMPNO";
            this.fORLEMPNODataGridViewTextBoxColumn.Name = "fORLEMPNODataGridViewTextBoxColumn";
            this.fORLEMPNODataGridViewTextBoxColumn.Visible = false;
            // 
            // fORLCODEDataGridViewTextBoxColumn
            // 
            this.fORLCODEDataGridViewTextBoxColumn.DataPropertyName = "FORL_CODE";
            this.fORLCODEDataGridViewTextBoxColumn.HeaderText = "외국어코드";
            this.fORLCODEDataGridViewTextBoxColumn.Name = "fORLCODEDataGridViewTextBoxColumn";
            // 
            // fORLSCOREDataGridViewTextBoxColumn
            // 
            this.fORLSCOREDataGridViewTextBoxColumn.DataPropertyName = "FORL_SCORE";
            this.fORLSCOREDataGridViewTextBoxColumn.HeaderText = "점수";
            this.fORLSCOREDataGridViewTextBoxColumn.Name = "fORLSCOREDataGridViewTextBoxColumn";
            // 
            // fORLACQDATEDataGridViewTextBoxColumn
            // 
            this.fORLACQDATEDataGridViewTextBoxColumn.DataPropertyName = "FORL_ACQDATE";
            this.fORLACQDATEDataGridViewTextBoxColumn.HeaderText = "취득일";
            this.fORLACQDATEDataGridViewTextBoxColumn.Name = "fORLACQDATEDataGridViewTextBoxColumn";
            // 
            // fORLORGANDataGridViewTextBoxColumn
            // 
            this.fORLORGANDataGridViewTextBoxColumn.DataPropertyName = "FORL_ORGAN";
            this.fORLORGANDataGridViewTextBoxColumn.HeaderText = "발급기관";
            this.fORLORGANDataGridViewTextBoxColumn.Name = "fORLORGANDataGridViewTextBoxColumn";
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
            // tHRMFORLLJMBindingSource
            // 
            this.tHRMFORLLJMBindingSource.DataMember = "THRM_FORL_LJM";
            this.tHRMFORLLJMBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHRM_FORL_LJMTableAdapter
            // 
            this.tHRM_FORL_LJMTableAdapter.ClearBeforeFill = true;
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
            // Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.fam_save_button);
            this.Controls.Add(this.dataGridView7);
            this.Name = "Language";
            this.Size = new System.Drawing.Size(1086, 346);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRMFORLLJMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.BindingSource tHRMFORLLJMBindingSource;
        private DataSet6 dataSet6;
        private DataSet6TableAdapters.THRM_FORL_LJMTableAdapter tHRM_FORL_LJMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORLEMPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORLCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORLSCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORLACQDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORLORGANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button fam_save_button;
    }
}
