
namespace Project2NET2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblSsan = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtSsan = new System.Windows.Forms.TextBox();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtIDNo = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpPayroll = new System.Windows.Forms.GroupBox();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBrowse = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.grpEmployee.SuspendLayout();
            this.grpPayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.lblPay);
            this.grpEmployee.Controls.Add(this.lblSsan);
            this.grpEmployee.Controls.Add(this.lblName);
            this.grpEmployee.Controls.Add(this.lblID);
            this.grpEmployee.Controls.Add(this.txtPay);
            this.grpEmployee.Controls.Add(this.txtSsan);
            this.grpEmployee.Controls.Add(this.txtMiddle);
            this.grpEmployee.Controls.Add(this.txtFirst);
            this.grpEmployee.Controls.Add(this.txtLast);
            this.grpEmployee.Controls.Add(this.txtIDNo);
            resources.ApplyResources(this.grpEmployee, "grpEmployee");
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPay
            // 
            resources.ApplyResources(this.lblPay, "lblPay");
            this.lblPay.Name = "lblPay";
            // 
            // lblSsan
            // 
            resources.ApplyResources(this.lblSsan, "lblSsan");
            this.lblSsan.Name = "lblSsan";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // txtPay
            // 
            resources.ApplyResources(this.txtPay, "txtPay");
            this.txtPay.Name = "txtPay";
            // 
            // txtSsan
            // 
            resources.ApplyResources(this.txtSsan, "txtSsan");
            this.txtSsan.Name = "txtSsan";
            // 
            // txtMiddle
            // 
            resources.ApplyResources(this.txtMiddle, "txtMiddle");
            this.txtMiddle.Name = "txtMiddle";
            // 
            // txtFirst
            // 
            resources.ApplyResources(this.txtFirst, "txtFirst");
            this.txtFirst.Name = "txtFirst";
            // 
            // txtLast
            // 
            resources.ApplyResources(this.txtLast, "txtLast");
            this.txtLast.Name = "txtLast";
            // 
            // txtIDNo
            // 
            resources.ApplyResources(this.txtIDNo, "txtIDNo");
            this.txtIDNo.Name = "txtIDNo";
            this.txtIDNo.TextChanged += new System.EventHandler(this.txtIDNo_TextChanged);
            // 
            // btnFirst
            // 
            resources.ApplyResources(this.btnFirst, "btnFirst");
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            resources.ApplyResources(this.btnLast, "btnLast");
            this.btnLast.Name = "btnLast";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpPayroll
            // 
            this.grpPayroll.Controls.Add(this.dgvPayroll);
            resources.ApplyResources(this.grpPayroll, "grpPayroll");
            this.grpPayroll.Name = "grpPayroll";
            this.grpPayroll.TabStop = false;
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.AllowUserToAddRows = false;
            this.dgvPayroll.AllowUserToDeleteRows = false;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpName,
            this.WeekEnd,
            this.HoursWorked,
            this.PayRate});
            resources.ApplyResources(this.dgvPayroll, "dgvPayroll");
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.ReadOnly = true;
            this.dgvPayroll.RowTemplate.Height = 26;
            this.dgvPayroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayroll_CellContentClick);
            // 
            // EmpID
            // 
            resources.ApplyResources(this.EmpID, "EmpID");
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // EmpName
            // 
            resources.ApplyResources(this.EmpName, "EmpName");
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // WeekEnd
            // 
            resources.ApplyResources(this.WeekEnd, "WeekEnd");
            this.WeekEnd.Name = "WeekEnd";
            this.WeekEnd.ReadOnly = true;
            // 
            // HoursWorked
            // 
            resources.ApplyResources(this.HoursWorked, "HoursWorked");
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.ReadOnly = true;
            // 
            // PayRate
            // 
            resources.ApplyResources(this.PayRate, "PayRate");
            this.PayRate.Name = "PayRate";
            this.PayRate.ReadOnly = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblBrowse
            // 
            resources.ApplyResources(this.lblBrowse, "lblBrowse");
            this.lblBrowse.Name = "lblBrowse";
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.Name = "lblError";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblBrowse);
            this.Controls.Add(this.grpPayroll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.grpEmployee);
            this.Name = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.grpPayroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblSsan;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtSsan;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtIDNo;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpPayroll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBrowse;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayRate;
    }
}