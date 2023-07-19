
namespace Project2NET2
{
    partial class Form3
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.cmbSelectEmployee = new System.Windows.Forms.ComboBox();
            this.lblWeekEnd = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtWeekEnd = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.dgvPayroll2 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblPayrollData = new System.Windows.Forms.Label();
            this.sfdXML = new System.Windows.Forms.SaveFileDialog();
            this.pdlgData = new System.Windows.Forms.PrintDialog();
            this.pdPrint = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(149, 33);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(108, 17);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select Employee";
            this.lblSelect.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbSelectEmployee
            // 
            this.cmbSelectEmployee.FormattingEnabled = true;
            this.cmbSelectEmployee.Location = new System.Drawing.Point(263, 33);
            this.cmbSelectEmployee.Name = "cmbSelectEmployee";
            this.cmbSelectEmployee.Size = new System.Drawing.Size(121, 24);
            this.cmbSelectEmployee.TabIndex = 1;
            this.cmbSelectEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbSelectEmployee_SelectedIndexChanged);
            this.cmbSelectEmployee.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectEmployee_SelectionChangeCommitted);
            // 
            // lblWeekEnd
            // 
            this.lblWeekEnd.AutoSize = true;
            this.lblWeekEnd.Location = new System.Drawing.Point(158, 90);
            this.lblWeekEnd.Name = "lblWeekEnd";
            this.lblWeekEnd.Size = new System.Drawing.Size(89, 17);
            this.lblWeekEnd.TabIndex = 2;
            this.lblWeekEnd.Text = "Week Ending";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(149, 152);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(97, 17);
            this.lblHoursWorked.TabIndex = 3;
            this.lblHoursWorked.Text = "Hours Worked";
            // 
            // txtWeekEnd
            // 
            this.txtWeekEnd.Location = new System.Drawing.Point(263, 90);
            this.txtWeekEnd.Name = "txtWeekEnd";
            this.txtWeekEnd.Size = new System.Drawing.Size(100, 24);
            this.txtWeekEnd.TabIndex = 4;
            this.txtWeekEnd.TextChanged += new System.EventHandler(this.txtWeekEnd_TextChanged);
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(263, 152);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 24);
            this.txtHoursWorked.TabIndex = 5;
            // 
            // dgvPayroll2
            // 
            this.dgvPayroll2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll2.Location = new System.Drawing.Point(100, 221);
            this.dgvPayroll2.Name = "dgvPayroll2";
            this.dgvPayroll2.RowHeadersWidth = 51;
            this.dgvPayroll2.RowTemplate.Height = 26;
            this.dgvPayroll2.Size = new System.Drawing.Size(518, 150);
            this.dgvPayroll2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 402);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(182, 403);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(115, 23);
            this.btnCommit.TabIndex = 8;
            this.btnCommit.Text = "Commit Data";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(319, 402);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(440, 403);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(557, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(585, 63);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 17);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Error";
            // 
            // lblPayrollData
            // 
            this.lblPayrollData.AutoSize = true;
            this.lblPayrollData.Location = new System.Drawing.Point(24, 32);
            this.lblPayrollData.Name = "lblPayrollData";
            this.lblPayrollData.Size = new System.Drawing.Size(81, 17);
            this.lblPayrollData.TabIndex = 13;
            this.lblPayrollData.Text = "Payroll Data";
            // 
            // pdlgData
            // 
            this.pdlgData.UseEXDialog = true;
            // 
            // pdPrint
            // 
            this.pdPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdPrint_PrintPage);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPayrollData);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPayroll2);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtWeekEnd);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblWeekEnd);
            this.Controls.Add(this.cmbSelectEmployee);
            this.Controls.Add(this.lblSelect);
            this.Name = "Form3";
            this.Text = "Payroll Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cmbSelectEmployee;
        private System.Windows.Forms.Label lblWeekEnd;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txtWeekEnd;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.DataGridView dgvPayroll2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblPayrollData;
        private System.Windows.Forms.SaveFileDialog sfdXML;
        private System.Windows.Forms.PrintDialog pdlgData;
        private System.Drawing.Printing.PrintDocument pdPrint;
    }
}