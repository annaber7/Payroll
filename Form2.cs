using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
using System.Configuration; 

namespace Project2NET2
{
    public partial class Form2 : Form
    {
        DataSet dsEmp = null;
        Int32 intCurrRow = 0;
        //private object dgvPayRate;

        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["AppTitle"] != null)
            {
                lblBrowse.Text = ConfigurationManager.AppSettings["AppTitle"].ToString();
            }
            DisableNavigation();
            LoadEmployees();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgAnswer;
            dlgAnswer = MessageBox.Show("Do you want to Exit?", "Exit Program", MessageBoxButtons.YesNo);
            if (dlgAnswer == System.Windows.Forms.DialogResult.Yes)
            {

                if (dsEmp != null)
                {
                    dsEmp.Dispose();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DisableNavigation()
        {
            btnFirst.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
        }

        private void EnableNavigation()
        {
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true; 

        }

        private void LoadEmployees()
        {
            if (dsEmp != null)
            {
                dsEmp.Dispose();
            }

            intCurrRow = 0;

            dsEmp = clsDatabase.GetAllEmployees();
            if (dsEmp == null)
            {
                MessageBox.Show("Unable to find employee information", "SELECT");
            }
            else if (dsEmp.Tables.Count < 1)
            {
                MessageBox.Show("Unable to find employee information", "SELECT");
                dsEmp.Dispose();
                dsEmp = null; 
            }
            else if (dsEmp.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("Employee information unavailable", "SELECT"); 
            }
            else
            {
                EnableNavigation();
                ShowEmployee(); 
            }

        }
        private void ShowEmployee()
        {
            ClearAllData();
            if (dsEmp.Tables[0].Rows.Count > intCurrRow)
            {


                txtIDNo.Text = dsEmp.Tables[0].Rows[intCurrRow]["EmpID"].ToString();
                txtFirst.Text = dsEmp.Tables[0].Rows[intCurrRow]["FName"].ToString();
                //txtMiddle.Text = dsEmp.Tables[0].Rows[intCurrRow]["Middle"].ToString();
                txtLast.Text = dsEmp.Tables[0].Rows[intCurrRow]["LName"].ToString();
                txtSsan.Text = dsEmp.Tables[0].Rows[intCurrRow]["SSAN"].ToString();
                txtPay.Text = dsEmp.Tables[0].Rows[intCurrRow]["PayRate"].ToString();
                if (dsEmp.Tables[0].Rows[intCurrRow]["MInit"] == DBNull.Value)
                {
                    txtMiddle.Text = "";
                }
                else
                {
                    txtMiddle.Text = dsEmp.Tables[0].Rows[intCurrRow]["MInit"].ToString();
                }


                DataSet dsSQL;
                dsSQL = clsDatabase.GetPayrollByEmployee(Convert.ToInt32(txtIDNo.Text));
                dgvPayroll.DataSource = dsSQL.Tables[0];
            }
            
        }

        //private void txtIDNo_TextChanged(object sender, EventArgs e)
        //{
        //    lblError.Text = "";
        //    intCurrRow = 0;
        //    ShowEmployee(); 
        //}

        private void ClearAllData()
        {
            txtIDNo.Text = "";
            txtFirst.Text = "";
            txtMiddle.Text = "";
            txtLast.Text = "";
            txtSsan.Text = "";
            txtPay.Text = ""; 
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow = dsEmp.Tables[0].Rows.Count - 1;
            ShowEmployee(); 

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow += 1;
            if(intCurrRow >= dsEmp.Tables[0].Rows.Count)
            {
                intCurrRow = dsEmp.Tables[0].Rows.Count - 1;
            }
            ShowEmployee(); 
        }
        
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow = dsEmp.Tables[0].Rows.Count + 1;
            ShowEmployee(); 
        }

        private void DisplayPayrate(Int32 intEmpID)
        {
            DataSet dsEmp;
            Decimal decPayRate;
            decPayRate = clsDatabase.GetPayRateByID(intEmpID);
            if(decPayRate < 0.0M)
            {
                lblError.Text = "Unable to find pay rate";
                txtPay.Text = "0.00";
            }
            else
            {
                txtPay.Text = decPayRate.ToString("c");
            }
            dsEmp = clsDatabase.GetPayrollByEmployee(intEmpID);
            if(dsEmp == null)
            {
                lblError.Text = "Error find payroll information for ID:" + intEmpID.ToString();
            }
            else
            {
                dgvPayroll.DataSource = dsEmp.Tables[0];
            }

        }

        private void dgvPayroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIDNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
