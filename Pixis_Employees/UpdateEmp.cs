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
            string empAddress;
            string empDOB;
            string empCity;
            string empEmail;
            string empFName;
            string empGender;
            string empHireDate;
            string empLName;
            string empNum;
            string empPhoneNumber;
            string empStartDate;
            string empState;
            string empTermDate;
            string empZip;
            string hourlyRate;
            string jobId;
            string regionId;
            string workStatus;

            //Varibales for the sql statement
            iDB2Connection conn;
            iDB2DataAdapter iDBAdapter;
            DataTable dt;

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
                            case "txtLName":
                                empLName = textBox.Text;
                                break;
                            case "txtEmployeeAddress":
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

            string cmdText = "UPDATE EMPLOYEE " +
                             "SET EFNAME = @empFName, " +
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

        }
    }
}
