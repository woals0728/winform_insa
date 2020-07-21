namespace Project1
{
    partial class Eng_cert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eng_cert));
            this.print_button = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.year = new System.Windows.Forms.Label();
            this.use = new System.Windows.Forms.Label();
            this.entdate = new System.Windows.Forms.Label();
            this.dut = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // print_button
            // 
            this.print_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print_button.Location = new System.Drawing.Point(9, 6);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(61, 23);
            this.print_button.TabIndex = 72;
            this.print_button.Text = "Print";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project1.Properties.Resources.영문증명서2222;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.use);
            this.panel1.Controls.Add(this.entdate);
            this.panel1.Controls.Add(this.dut);
            this.panel1.Controls.Add(this.dept);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.birth);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(9, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 906);
            this.panel1.TabIndex = 71;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.BackColor = System.Drawing.Color.Transparent;
            this.year.Font = new System.Drawing.Font("함초롬바탕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(316, 719);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(110, 21);
            this.year.TabIndex = 1;
            this.year.Text = "MM/dd/yyyy";
            // 
            // use
            // 
            this.use.AutoSize = true;
            this.use.BackColor = System.Drawing.Color.Transparent;
            this.use.Font = new System.Drawing.Font("함초롬바탕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.use.Location = new System.Drawing.Point(179, 337);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(42, 21);
            this.use.TabIndex = 1;
            this.use.Text = "USE";
            // 
            // entdate
            // 
            this.entdate.AutoSize = true;
            this.entdate.BackColor = System.Drawing.Color.Transparent;
            this.entdate.Font = new System.Drawing.Font("함초롬바탕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entdate.Location = new System.Drawing.Point(179, 278);
            this.entdate.Name = "entdate";
            this.entdate.Size = new System.Drawing.Size(86, 21);
            this.entdate.TabIndex = 1;
            this.entdate.Text = "ENTDATE";
            // 
            // dut
            // 
            this.dut.AutoSize = true;
            this.dut.BackColor = System.Drawing.Color.Transparent;
            this.dut.Font = new System.Drawing.Font("함초롬바탕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dut.Location = new System.Drawing.Point(479, 277);
            this.dut.Name = "dut";
            this.dut.Size = new System.Drawing.Size(45, 21);
            this.dut.TabIndex = 1;
            this.dut.Text = "DUT";
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.BackColor = System.Drawing.Color.Transparent;
            this.dept.Font = new System.Drawing.Font("함초롬바탕", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dept.Location = new System.Drawing.Point(479, 221);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(42, 17);
            this.dept.TabIndex = 1;
            this.dept.Text = "DEPT";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.Color.Transparent;
            this.phone.Font = new System.Drawing.Font("함초롬바탕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(179, 219);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(66, 21);
            this.phone.TabIndex = 1;
            this.phone.Text = "PHONE";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Font = new System.Drawing.Font("함초롬바탕", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.address.Location = new System.Drawing.Point(179, 162);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(68, 17);
            this.address.TabIndex = 1;
            this.address.Text = "ADDRESS";
            // 
            // birth
            // 
            this.birth.AutoSize = true;
            this.birth.BackColor = System.Drawing.Color.Transparent;
            this.birth.Font = new System.Drawing.Font("함초롬바탕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth.Location = new System.Drawing.Point(479, 103);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(59, 21);
            this.birth.TabIndex = 1;
            this.birth.Text = "BIRTH";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("함초롬바탕", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(179, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 17);
            this.name.TabIndex = 1;
            this.name.Text = "NAME";
            // 
            // Eng_cert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(790, 950);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.print_button);
            this.MaximizeBox = false;
            this.Name = "Eng_cert";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label year;
        public System.Windows.Forms.Label use;
        public System.Windows.Forms.Label entdate;
        public System.Windows.Forms.Label dut;
        public System.Windows.Forms.Label dept;
        public System.Windows.Forms.Label phone;
        public System.Windows.Forms.Label address;
        public System.Windows.Forms.Label birth;
        public System.Windows.Forms.Label name;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}