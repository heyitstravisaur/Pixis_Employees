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

                cmd.Parameters["@EMPNO"].Value = empNum;
                cmd.Parameters["@EFNAME"].Value = empFName;
                cmd.Parameters["@ELNAME"].Value = empLName;
                cmd.Parameters["@EADDR"].Value = empAddress;
                cmd.Parameters["@ECITY"].Value = empCity;
                cmd.Parameters["@ESTATE"].Value = empState;
                cmd.Parameters["@EZIP"].Value = empZip;
                cmd.Parameters["@EPHONE"].Value = empPhoneNumber;
                cmd.Parameters["@EMAIL"].Value = empEmail;
                cmd.Parameters["@DOB"].Value = DateTime.Parse(empDOB);
                cmd.Parameters["@GENDER"].Value = empGender;
                cmd.Parameters["@JOBID"].Value = jobId;
                cmd.Parameters["@WRKSTATUS"].Value = workStatus;
                cmd.Parameters["@HRLYRATE"].Value = hourlyRate;
                cmd.Parameters["@EMHIREDT"].Value = DateTime.Parse(empHireDate);
                cmd.Parameters["@EMSTARTDT"].Value = DateTime.Parse(empStartDate);
                cmd.Parameters["@EMTERMDT"].Value = DateTime.Parse(empTermDate);
                cmd.Parameters["@REGIONID"].Value = regionId;

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
