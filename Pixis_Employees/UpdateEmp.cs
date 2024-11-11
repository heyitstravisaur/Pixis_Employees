using System;
using System.Collections.Generic;
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

            foreach (var group in groupBoxes)
            {
                foreach (Control control in group.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        switch (textBox.Name)
                        {
                            case "txtEmpNum":
                                empNum = textBox.Name;
                                break;
                            case "txtEmpFName":
                                empFName = textBox.Name;
                                break;
                            case "txtLName":
                                empLName = textBox.Name;
                                break;
                            case "txtEmpCity":
                                empCity = textBox.Name;
                                break;
                            case "txtEmpState":
                                empState = textBox.Name;
                                break;
                            case "txtEmpZip":
                                empZip = textBox.Name;
                                break;
                            case "txtEmpPhoneNumber":
                                empPhoneNumber = textBox.Name;
                                break;
                            case "txtEmpEmail":
                                empEmail = textBox.Name;
                                break;
                            case "txtEmpDOB":
                                empDOB = textBox.Name;
                                break;
                            case "txtEmpGender":
                                empGender = textBox.Name;
                                break;
                            case "txtJobId":
                                jobId = textBox.Name;
                                break;
                            case "txtWorkStatus":
                                workStatus = textBox.Name;
                                break;
                            case "txtHourlyRate":
                                hourlyRate = textBox.Name;
                                break;
                            case "txtEmpHireDate":
                                empHireDate = textBox.Name;
                                break;
                            case "txtEmpStartDate":
                                empStartDate = textBox.Name;
                                break;
                            case "txtEmpTermDate":
                                empTermDate = textBox.Name;
                                break;
                            case "txtRegionId":
                                regionId = textBox.Name;
                                break;
                        }
                    }
                }
            }


        }
    }
}
