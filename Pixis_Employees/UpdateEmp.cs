using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixis_Employees
{
    internal class UpdateEmp
    {

        public static void update(List<GroupBox> groupBoxes)
        {
            //varibales for switch case (for holding the text from the textboxes in the AddUpdate form)
            string empAddress = "";
            string empDOB = "";
            string empCity = "";
            string empEmail = "";
            string empFName = "";
            string empGender = "";
            string empHireDate = "";
            string empLName = "";
            string empNum = "";
            string empPhoneNumber = "";
            string empStartDate = "";
            string empState = "";
            string empTermDate = "";
            string empZip = "";
            string hourlyRate = "";
            string jobId = "";
            string regionId = "";
            string workStatus = "";

            //Varibales for the sql statement
            iDB2Connection conn = new iDB2Connection();

            foreach (var group in groupBoxes)
            {
                foreach (Control control in group.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        switch (textBox.Name)
                        {
                            case "txtEmpNum":
                                empNum = textBox.Text;
                                break;
                            case "txtEmpFName":
                                empFName = textBox.Text;
                                break;
                            case "txtEmpLName":
                                empLName = textBox.Text;
                                break;
                            case "txtEmpAddress":
                                empAddress = textBox.Text;
                                break;
                            case "txtEmpCity":
                                empCity = textBox.Text;
                                break;
                            case "txtEmpState":
                                empState = textBox.Text;
                                break;
                            case "txtEmpZip":
                                empZip = textBox.Text;
                                break;
                            case "txtEmpPhoneNumber":
                                empPhoneNumber = textBox.Text;
                                break;
                            case "txtEmpEmail":
                                empEmail = textBox.Text;
                                break;
                            case "txtEmpDOB":
                                empDOB = textBox.Text;
                                break;
                            case "txtEmpGender":
                                empGender = textBox.Text;
                                break;
                            case "txtJobId":
                                jobId = textBox.Text;
                                break;
                            case "txtWorkStatus":
                                workStatus = textBox.Text;
                                break;
                            case "txtHourlyRate":
                                hourlyRate = textBox.Text;
                                break;
                            case "txtEmpHireDate":
                                empHireDate = textBox.Text;
                                break;
                            case "txtEmpStartDate":
                                empStartDate = textBox.Text;
                                break;
                            case "txtEmpTermDate":
                                empTermDate = textBox.Text;
                                break;
                            case "txtRegionId":
                                regionId = textBox.Text;
                                break;
                        }
                    }
                }
            }

            string cmdText = "UPDATE EMPLOYEE SET " +
                             "EFNAME = @empFName, " +
                             "ELNAME = @empLName, " +
                             "EADDR = @empAddress, " +
                             "ECITY = @empCity, " +
                             "ESTATE = @empState, " +
                             "EZIP = @empZip, " +
                             "EPHONE = @empPhoneNumber, " +
                             "EMAIL = @empEmail, " +
                             "DOB = @empDOB, " +
                             "GENDER = @empGender, " +
                             "JOBID = @jobId, " +
                             "WRKSTATUS = @workStatus, " +
                             "HRLYRATE = @hourlyRate, " +
                             "EMHIREDT = @empHireDate, " +
                             "EMSTARTDT = @empStartDate, " +
                             "EMTERMDT = @empTermDate, " +
                             "REGIONID = @regionId " +
                             "WHERE EMPNO = @empNum";


            string connName = "Data Source=deathstar.gtc.edu;User ID=itpa638;Initial Catalog=S101FF5C";

            try
            {
                conn = new iDB2Connection(connName);
                conn.Open();

                iDB2Command cmd = new iDB2Command(cmdText, conn);

                cmd.Parameters.AddWithValue("@empNum", empNum.Trim());
                cmd.Parameters.AddWithValue("@empFName", empFName.Trim());
                cmd.Parameters.AddWithValue("@empLName", empLName.Trim());
                cmd.Parameters.AddWithValue("@empAddress", empAddress.Trim());
                cmd.Parameters.AddWithValue("@empCity", empCity.Trim());
                cmd.Parameters.AddWithValue("@empState", empState.Trim());
                cmd.Parameters.AddWithValue("@empZip", empZip.Trim());
                cmd.Parameters.AddWithValue("@empPhoneNumber", empPhoneNumber.Trim());
                cmd.Parameters.AddWithValue("@empEmail", empEmail.Trim());
                cmd.Parameters.AddWithValue("@empDOB", DateTime.Parse(empDOB).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@empGender", empGender.Trim());
                cmd.Parameters.AddWithValue("@jobId", jobId.Trim());
                cmd.Parameters.AddWithValue("@workStatus", workStatus.Trim());
                cmd.Parameters.AddWithValue("@hourlyRate", hourlyRate.Trim());
                cmd.Parameters.AddWithValue("@empHireDate", DateTime.Parse(empHireDate).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@empStartDate", DateTime.Parse(empStartDate).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@empTermDate", DateTime.Parse(empTermDate).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@regionId", regionId.Trim());

                int rowsAffected = cmd.ExecuteNonQuery();

                // Optionally check if the update was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee updated successfully!");
                }
                else
                {
                    MessageBox.Show("Update failed. No rows were affected.");
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., SQL errors)
                MessageBox.Show("Error updating employee: " + ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
