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
    internal class Add
    {
        public static void addEmp(List<GroupBox> groupBoxes)
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

            string connName = "Data Source=deathstar.gtc.edu;User ID=itpa638;Initial Catalog=S101FF5C";

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

            string cmdText = "INSERT INTO EMPLOYEE VALUES(" +
                         "@EMPNO, " +
                         "@EFNAME, " +
                         "@ELNAME, " +
                         "@EADDR, " +
                         "@ECITY, " +
                         "@ESTATE, " +
                         "@EZIP, " +
                         "@EPHONE, " +
                         "@EMAIL, " +
                         "@DOB, " +
                         "@GENDER, " +
                         "@JOBID, " +
                         "@WRKSTATUS, " +
                         "@HRLYRATE, " +
                         "@EMHIREDT, " +
                         "@EMSTARTDT, " +
                         "@EMTERMDT, " +
                         "@REGIONID)";

            try
            {
                conn = new iDB2Connection(connName);
                conn.Open();

                iDB2Command cmd = new iDB2Command(cmdText, conn);
                cmd.DeriveParameters();

                cmd.Parameters["@EMPNO"].Value =empNum;
                cmd.Parameters["@EFNAME"].Value = string.IsNullOrWhiteSpace(empFName) ? " " : ToUpperCase(empFName);
                cmd.Parameters["@ELNAME"].Value = string.IsNullOrWhiteSpace(empLName) ? " " : ToUpperCase(empLName);
                cmd.Parameters["@EADDR"].Value = string.IsNullOrWhiteSpace(empAddress) ? " " : empAddress;
                cmd.Parameters["@ECITY"].Value = string.IsNullOrWhiteSpace(empCity) ? " " : ToUpperCase(empCity);
                cmd.Parameters["@ESTATE"].Value = string.IsNullOrWhiteSpace(empState) ? " " : ToUpperCase(empState);
                cmd.Parameters["@EZIP"].Value = string.IsNullOrWhiteSpace(empZip) ? " " : empZip;
                cmd.Parameters["@EPHONE"].Value = string.IsNullOrWhiteSpace(empPhoneNumber) ? " " : empPhoneNumber;
                cmd.Parameters["@EMAIL"].Value = string.IsNullOrWhiteSpace(empPhoneNumber) ? " " : empEmail;
                cmd.Parameters["@DOB"].Value = string.IsNullOrWhiteSpace(empDOB) ? "0001-01-01" : empDOB;
                cmd.Parameters["@GENDER"].Value = string.IsNullOrWhiteSpace(empGender) ? " " : empGender.ToUpper();
                cmd.Parameters["@JOBID"].Value = string.IsNullOrWhiteSpace(jobId) ? " " : jobId;
                cmd.Parameters["@WRKSTATUS"].Value = string.IsNullOrWhiteSpace(workStatus) ? " " : ToUpperCase(workStatus);
                cmd.Parameters["@HRLYRATE"].Value = string.IsNullOrWhiteSpace(hourlyRate) ? " " : hourlyRate;
                cmd.Parameters["@EMHIREDT"].Value = string.IsNullOrWhiteSpace(empHireDate) ? "0001-01-01" : empHireDate;
                cmd.Parameters["@EMSTARTDT"].Value = string.IsNullOrWhiteSpace(empStartDate) ? "0001-01-01" : empStartDate;
                cmd.Parameters["@EMTERMDT"].Value = string.IsNullOrWhiteSpace(empTermDate) ? "0001-01-01" : empTermDate;
                cmd.Parameters["@REGIONID"].Value = string.IsNullOrWhiteSpace(empGender) ? " " : regionId.ToUpper();

                int rowsAffected = cmd.ExecuteNonQuery();

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
                MessageBox.Show("Error updating employee: " + ex.Message);
            }
            finally { conn.Close(); }

        }

        public static string ToUpperCase(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}
