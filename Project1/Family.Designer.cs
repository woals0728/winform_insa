﻿namespace Project1
{
    partial class Family
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.fam_save_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet9 = new Project1.DataSet9();
            this.fAMILYLJMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAMILY_LJMTableAdapter = new Project1.DataSet9TableAdapters.FAMILY_LJMTableAdapter();
            this.fAMEMPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMRELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDCODNMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMBTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMLTGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASYS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILYLJMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeight = 26;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fAMEMPNODataGridViewTextBoxColumn,
            this.fAMRELDataGridViewTextBoxColumn,
            this.cDCODNMSDataGridViewTextBoxColumn,
            this.fAMNAMEDataGridViewTextBoxColumn,
            this.fAMBTHDataGridViewTextBoxColumn,
            this.fAMLTGDataGridViewTextBoxColumn,
            this.dATASYS1DataGridViewTextBoxColumn,
            this.dATASYS2DataGridViewTextBoxColumn,
            this.dATASYS3DataGridViewTextBoxColumn,
            this.cDCODEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fAMILYLJMBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView2.Location = new System.Drawing.Point(6, 35);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1074, 279);
            this.dataGridView2.TabIndex = 64;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // add_button
            // 
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Location = new System.Drawing.Point(952, 6);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(61, 23);
            this.add_button.TabIndex = 62;
            this.add_button.Text = "행 추가";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // fam_save_button
            // 
            this.fam_save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fam_save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fam_save_button.ForeColor = System.Drawing.Color.White;
            this.fam_save_button.Location = new System.Drawing.Point(976, 320);
            this.fam_save_button.Name = "fam_save_button";
            this.fam_save_button.Size = new System.Drawing.Size(49, 23);
            this.fam_save_button.TabIndex = 63;
            this.fam_save_button.Text = "저장";
            this.fam_save_button.UseVisualStyleBackColor = false;
            this.fam_save_button.Click += new System.EventHandler(this.fam_save_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Location = new System.Drawing.Point(1019, 6);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(61, 23);
            this.delete_button.TabIndex = 65;
            this.delete_button.Text = "행 삭제";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1031, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet9
            // 
            this.dataSet9.DataSetName = "DataSet9";
            this.dataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fAMILYLJMBindingSource
            // 
            this.fAMILYLJMBindingSource.DataMember = "FAMILY_LJM";
            this.fAMILYLJMBindingSource.DataSource = this.dataSet9;
            // 
            // fAMILY_LJMTableAdapter
            // 
            this.fAMILY_LJMTableAdapter.ClearBeforeFill = true;
            // 
            // fAMEMPNODataGridViewTextBoxColumn
            // 
            this.fAMEMPNODataGridViewTextBoxColumn.DataPropertyName = "FAM_EMPNO";
            this.fAMEMPNODataGridViewTextBoxColumn.HeaderText = "FAM_EMPNO";
            this.fAMEMPNODataGridViewTextBoxColumn.Name = "fAMEMPNODataGridViewTextBoxColumn";
            this.fAMEMPNODataGridViewTextBoxColumn.Visible = false;
            // 
            // fAMRELDataGridViewTextBoxColumn
            // 
            this.fAMRELDataGridViewTextBoxColumn.DataPropertyName = "FAM_REL";
            this.fAMRELDataGridViewTextBoxColumn.HeaderText = "FAM_REL";
            this.fAMRELDataGridViewTextBoxColumn.Name = "fAMRELDataGridViewTextBoxColumn";
            this.fAMRELDataGridViewTextBoxColumn.Visible = false;
            // 
            // cDCODNMSDataGridViewTextBoxColumn
            // 
            this.cDCODNMSDataGridViewTextBoxColumn.DataPropertyName = "CD_CODNMS";
            this.cDCODNMSDataGridViewTextBoxColumn.HeaderText = "관계";
            this.cDCODNMSDataGridViewTextBoxColumn.Name = "cDCODNMSDataGridViewTextBoxColumn";
            // 
            // fAMNAMEDataGridViewTextBoxColumn
            // 
            this.fAMNAMEDataGridViewTextBoxColumn.DataPropertyName = "FAM_NAME";
            this.fAMNAMEDataGridViewTextBoxColumn.HeaderText = "성명";
            this.fAMNAMEDataGridViewTextBoxColumn.Name = "fAMNAMEDataGridViewTextBoxColumn";
            // 
            // fAMBTHDataGridViewTextBoxColumn
            // 
            this.fAMBTHDataGridViewTextBoxColumn.DataPropertyName = "FAM_BTH";
            this.fAMBTHDataGridViewTextBoxColumn.HeaderText = "생년월일";
            this.fAMBTHDataGridViewTextBoxColumn.Name = "fAMBTHDataGridViewTextBoxColumn";
            // 
            // fAMLTGDataGridViewTextBoxColumn
            // 
            this.fAMLTGDataGridViewTextBoxColumn.DataPropertyName = "FAM_LTG";
            this.fAMLTGDataGridViewTextBoxColumn.HeaderText = "동거여부";
            this.fAMLTGDataGridViewTextBoxColumn.Name = "fAMLTGDataGridViewTextBoxColumn";
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
            // cDCODEDataGridViewTextBoxColumn
            // 
            this.cDCODEDataGridViewTextBoxColumn.DataPropertyName = "CD_CODE";
            this.cDCODEDataGridViewTextBoxColumn.HeaderText = "CD_CODE";
            this.cDCODEDataGridViewTextBoxColumn.Name = "cDCODEDataGridViewTextBoxColumn";
            this.cDCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // Family
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.fam_save_button);
            this.Name = "Family";
            this.Size = new System.Drawing.Size(1086, 346);
            this.Tag = "가족사항";
            this.Load += new System.EventHandler(this.Family_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILYLJMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button fam_save_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource fAMILYLJMBindingSource;
        private DataSet9 dataSet9;
        private DataSet9TableAdapters.FAMILY_LJMTableAdapter fAMILY_LJMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMEMPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMRELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDCODNMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMBTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMLTGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASYS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDCODEDataGridViewTextBoxColumn;
    }
}
