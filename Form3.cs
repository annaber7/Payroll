using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Project2NET2
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        DataSet dsEmp;
        DataTable dtNewTable = null;
        Form frmMsg = new Form();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadEmployees()
        {
            if (dsEmp != null)
            {
                dsEmp.Dispose();
            }

            //intCurrRow = 0;

            dsEmp = clsDatabase.GetEmployeeNames();
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
                cmbSelectEmployee.DisplayMember = "FullName";
                cmbSelectEmployee.ValueMember = "EmpID";
                cmbSelectEmployee.DataSource = dsEmp.Tables[0];
            }

        }
        private void txtWeekEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSelectEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Boolean blnOk = true;
            Decimal decValue = 0M;
            lblError.Text = "";
            Decimal PayRate = 0M;
            String Name = cmbSelectEmployee.Text;
            String ID = cmbSelectEmployee.SelectedValue.ToString(); 

            if (!Decimal.TryParse(txtHoursWorked.Text, out decValue))
            {
                lblError.Text = "Hours worked must be numeric";
                blnOk = false;
            }
            if (blnOk)
            {
                PayRate = clsDatabase.GetPayRateByID(Convert.ToInt32(cmbSelectEmployee.SelectedValue));
                dtNewTable.Rows.Add(Convert.ToInt32(ID), Name, txtHoursWorked.Text, txtWeekEnd.Text,(decValue * PayRate).ToString("c"));
                ClearForm();
            }
            void ClearForm()
            {
                txtHoursWorked.Text = "";
                txtWeekEnd.Text = "";
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            CreateDataTable();
            {
                if (ConfigurationManager.AppSettings["AppTitle"] != null)
                {
                    lblPayrollData.Text = ConfigurationManager.AppSettings["AppTitle"].ToString();
                }
                LoadEmployees();

            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                DialogResult dlgAnswer;
                dlgAnswer = MessageBox.Show("Do you want to Exit?", "Exit Program", MessageBoxButtons.YesNo);
                if (dlgAnswer == System.Windows.Forms.DialogResult.Yes)
                {

                    if (dsEmp != null)
                    {
                        dsEmp.Dispose();
                    }
                    if (dtNewTable != null)
                    {
                        dtNewTable.Dispose();
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        private void CreateDataTable()
        {
            lblError.Text = "";

            if (dtNewTable != null)
            {
                dtNewTable.Dispose();
            }
            dtNewTable = new DataTable();
            dtNewTable.TableName = "NewDataEntry";
            dtNewTable.Columns.Add("EmpID", typeof(Int32));
            dtNewTable.Columns.Add("FullName", typeof(String));
            dtNewTable.Columns.Add("HoursWorked", typeof(Decimal));
            dtNewTable.Columns.Add("WeekEnding", typeof(String));
            dtNewTable.Columns.Add("TotalPay", typeof(String)); 

            dgvPayroll2.DataSource = dtNewTable;

            dgvPayroll2.AllowUserToAddRows = false;
            dgvPayroll2.AllowUserToDeleteRows = false;
            dgvPayroll2.AllowUserToOrderColumns = false;
            dgvPayroll2.Columns[0].Width = 200;
            dgvPayroll2.Columns[1].Width = 200;
            dgvPayroll2.Columns[2].Width = 200;
            dgvPayroll2.Columns[3].Width = 200;
            dgvPayroll2.Columns[4].Width = 200; 

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertPayroll()
        {
            Int32 intRow;
            for (intRow = 0; intRow < dtNewTable.Rows.Count; intRow++)
            {
                clsDatabase.InsertPayroll(Convert.ToInt32(dtNewTable.Rows[intRow]["EmpID"]), Convert.ToDecimal(dtNewTable.Rows[intRow]["HoursWorked"]), dtNewTable.Rows[intRow]["WeekEnding"].ToString());
            }
        }
        //{
        //    SqlConnection cnSQL;
        //    SqlDataAdapter daSQL;
        //    btnExport.Enabled = false; 
        //    if(ConfigurationManager.ConnectionStrings["Payroll"] != null)
        //    {
        //        cnSQL = clsDatabase.AcquireConnection("Payroll"); 
        //        if(cnSQL == null)
        //        {
        //            lblError.Text = "Error connecting to database";
        //        }
        //        else
        //        {
        //            if(dsEmp != null)
        //            {
        //                dsEmp = null;
        //            }
        //            dsEmp = new DataSet();
        //            try
        //            {
        //                daSQL = new SqlDataAdapter("Select * from dbo.Payroll", cnSQL);
        //                daSQL.Fill(dsEmp);
        //                daSQL.Dispose();
        //                dgvPayroll2.DataSource = dsEmp.Tables[0];
        //                btnExport.Enabled = true; 
        //            }
        //            catch(Exception ex)
        //            {
        //                lblError.Text = "Error retrieving Payroll information";
        //                dsEmp.Dispose();
        //                dsEmp = null; 
        //            }
        //            finally
        //            {
        //                cnSQL.Close();
        //                cnSQL.Dispose(); 
        //            }
        //        }
        //    }
        //    else
        //    {
        //        lblError.Text = "No payroll information retrieved"; 
        //    }
        //}
        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult dlgAnswer;
            //DataSet dsXML;

            sfdXML.DefaultExt = "xml";
            sfdXML.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            sfdXML.InitialDirectory = "C:\\";
            sfdXML.OverwritePrompt = true;
            sfdXML.Title = "Save XML File";

            dlgAnswer = sfdXML.ShowDialog();
            if (dlgAnswer == DialogResult.OK)
            {
                dtNewTable.WriteXml(sfdXML.FileName);

                //** Now read back into another dataset
                //dsXML = new DataSet();
                //dsXML.ReadXml(sfdXML.FileName);
                //dgvPayroll2.DataSource = dsXML.Tables[0];
            }
        }

        private void cmbSelectEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult;
            lblError.Text = "";
            dlgResult = pdlgData.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                pdPrint.PrinterSettings = pdlgData.PrinterSettings;
                pdPrint.Print();
                dtNewTable.Rows.Clear();
            }
        }

        private void pdPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fDoc;
            Single sglXPos;
            Single sglYPos;
            Int32 intRow;
            Decimal decTotalValue;
            Decimal decRecords; 


            fDoc = new Font("Arial", 12);
            e.Graphics.DrawString("Payroll Sheet", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(250), Convert.ToSingle(75));

            sglYPos = Convert.ToSingle(125);
            e.Graphics.DrawString("EmpID", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(30.0), sglYPos);
            e.Graphics.DrawString("Name", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(200.0), sglYPos);
            e.Graphics.DrawString("HoursWorked", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(200.0), sglYPos);
            e.Graphics.DrawString("WeekEnding", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(400.0), sglYPos);
            e.Graphics.DrawString("TotalPay", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(200.0), sglYPos); 

            decTotalValue = 0M;
            decRecords = 0M; 

            for (intRow = 0; intRow < dtNewTable.Rows.Count; intRow++)
            {
                sglXPos = Convert.ToSingle(30);
                sglYPos += Convert.ToSingle(fDoc.Height);
                e.Graphics.DrawString(dtNewTable.Rows[intRow]["EmpID"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                sglYPos += Convert.ToSingle(fDoc.Height);
                e.Graphics.DrawString(dtNewTable.Rows[intRow]["Name"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                sglXPos = Convert.ToSingle(200);
                e.Graphics.DrawString(dtNewTable.Rows[intRow]["WeekEnding"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                sglXPos = Convert.ToSingle(400);
                e.Graphics.DrawString(dtNewTable.Rows[intRow]["HoursWorked"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                sglXPos = Convert.ToSingle(400);
                e.Graphics.DrawString(dtNewTable.Rows[intRow]["TotalPay"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                decRecords = Convert.ToDecimal(dtNewTable.Rows.Count);
                decTotalValue += Convert.ToDecimal(dtNewTable.Rows[intRow]["TotalPay"]);
            }

            sglYPos += (Convert.ToSingle(fDoc.Height * 2));
            e.Graphics.DrawString("Totle Value:" + decTotalValue.ToString("c"), fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(50), sglYPos);

            sglYPos += (Convert.ToSingle(fDoc.Height * 2));
            e.Graphics.DrawString("Total Records:" + decRecords.ToString("c"), fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(50), sglYPos);
            DateTime.Now.ToString("yyyy MMM dd hh:mm:ss"); 
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            InsertPayroll();
            //    {
            //        for (intRow = 0; intRow < dtNewTable.Rows.Count; intRow++)
            //        {
            //            sglXPos = Convert.ToSingle(30);
            //            sglYPos += Convert.ToSingle(fDoc.Height);
            //            e.Graphics.DrawString(dtNewTable.Rows[intRow]["EmpID"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

            //            sglXPos = Convert.ToSingle(200);
            //            e.Graphics.DrawString(dtNewTable.Rows[intRow]["WeekEnding"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

            //            sglXPos = Convert.ToSingle(400);
            //            e.Graphics.DrawString(dtNewTable.Rows[intRow]["HoursWorked"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

            //            decTotalValue += Convert.ToDecimal(dtNewTable.Rows[intRow][""]);
            //        }
            //    }
            //}
        }
    }
}
