using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Project2NET2
{
    class clsDatabase
    {


        private static SqlConnection AcquireConnection()
        {
            return AcquireConnection("Payroll");
        }

        public static SqlConnection AcquireConnection(string strConnectionName)
        {
            SqlConnection cnSQL = null;
            Boolean blnError = false;

            if (strConnectionName.Trim().Length < 1)
            {
                blnError = true;
            }
            else if (ConfigurationManager.ConnectionStrings[strConnectionName] == null)
            {
                blnError = true;
            }
            else
            {
                cnSQL = new SqlConnection();
                cnSQL.ConnectionString = ConfigurationManager.ConnectionStrings[strConnectionName].ToString();

                try
                {
                    cnSQL.Open();

                }
                catch (Exception ex)
                {
                    blnError = true;
                    cnSQL.Dispose();
                }
            }

            if (blnError)
            {
                return null;
            }
            else
            {
                return cnSQL;
            }
        }

        /*internal static DataSet InsertPayroll()
        {
            throw new NotImplementedException();
        }*/

        public static DataSet GetAllEmployees()
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;

            }
            else
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetAllEmployees";

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                dsSQL = new DataSet();

                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    dsSQL.Dispose();
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }
        public static DataSet GetPayrollByEmployee(Int32 intEmpID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsData = null;

            cnSQL = AcquireConnection();
            if (cnSQL != null)
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetPayrollByEmployee";

                cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@EmpID"].Value = intEmpID;

                dsData = new DataSet();
                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsData);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    dsData.Dispose();
                    dsData = null;
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            return dsData;
        }
        public static Decimal GetPayRateByID(Int32 intEmpID)
        {
            Console.WriteLine("hi");
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            ///DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;
            Decimal decPayRate = 0M; 

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;

            }
            else
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetPayRateByID";

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@EmpID"].Value = intEmpID;

                cmdSQL.Parameters.Add(new SqlParameter("@PayRate", SqlDbType.Int));
                cmdSQL.Parameters["@PayRate"].Direction = ParameterDirection.Output; 

              // dsSQL = new DataSet();

                try
                {
                    cmdSQL.ExecuteNonQuery();
                    if(cmdSQL.Parameters["@PayRate"] != null)
                    {
                        decimal.TryParse(cmdSQL.Parameters["@PayRate"].Value.ToString(), out decPayRate);
                    }
                    
                   // daSQL = new SqlDataAdapter(cmdSQL);
                   // daSQL.Fill(dsSQL);
                   // daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    //dsSQL.Dispose();
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

           
                return decPayRate;
            
        }
        public static DataSet GetEmployeeNames()
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;
            }
            else
            {
                //** Build command to execute stored procedure
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetEmployeeNames";

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                dsSQL = new DataSet();

                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    dsSQL.Dispose();
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }
        public static DataSet InsertPayroll(Int32 intEmpID, decimal decHoursWorked, string strWeekEnding)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;


            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;
            }
            else
            {
                //** Build command to execute stored procedure
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "InsertPayroll";

                cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@EmpID"].Value = intEmpID;

                cmdSQL.Parameters.Add(new SqlParameter("@HoursWorked", SqlDbType.Decimal));
                cmdSQL.Parameters["@HoursWorked"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@HoursWorked"].Value = decHoursWorked;

                cmdSQL.Parameters.Add(new SqlParameter("@WeekEnding", SqlDbType.NVarChar));
                cmdSQL.Parameters["@WeekEnding"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@WeekEnding"].Value = strWeekEnding;

                dsSQL = new DataSet();
                
                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    dsSQL.Dispose();
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }
        
        }


    }




