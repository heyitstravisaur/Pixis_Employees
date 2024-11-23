using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixis_Employees
{
    public partial class UpdateCustomer : Form
    {

        

        public string selectedCustomer { get; set; }
        public string connectionString { get; set; }
        public iDB2Connection conn { get; set; }
        public iDB2DataAdapter adapter { get; set; }
        public DataSet dataSet { get; set; }

        public UpdateCustomer(string selectedCustomer, string connectionString, iDB2Connection conn, iDB2DataAdapter ada
            )
        {
           
            InitializeComponent();

            String sql;



            try

            {
                //open connection to IDB2 to update live data, pass through connectionstring from Customer form
                conn = new iDB2Connection(connectionString);
                conn.Open();


                //sql statement building, taking selectedCustomer from Customer form
                sql = "Select * from CUSTOMER where CUSTNO " + " LIKE '%" + selectedCustomer + "%'";
                adapter = new iDB2DataAdapter(sql, conn);

                






                //if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                //{
                //    DataRow row = dataSet.Tables[0].Rows[0];

                //    foreach (GroupBox group in groups)
                //    {

                //        // Loop through each control inside the GroupBox
                //        foreach (Control control in group.Controls)
                //        {
                //            if (control is TextBox textBox)
                //            {
                //                // Use the TextBox Name property to identify which data to assign
                //                switch (textBox.Name)
                //                {
                //                    case "txtEmpNum":
                //                        textBox.Text = row["EMPNO"].ToString();
                //                        break;
                //                    case "txtEmpFName":
                //                        textBox.Text = row["EFNAME"].ToString();
                //                        break;
                //                    case "txtEmpLName":
                //                        textBox.Text = row["ELNAME"].ToString();
                //                        break;
                //                    case "txtEmpAddress":
                //                        textBox.Text = row["EADDR"].ToString();
                //                        break;
                //                    case "txtEmpCity":
                //                        textBox.Text = row["ECITY"].ToString();
                //                        break;
                //                    case "txtEmpState":
                //                        textBox.Text = row["ESTATE"].ToString();
                //                        break;
                //                    case "txtEmpZip":
                //                        textBox.Text = row["EZIP"].ToString();
                //                        break;
                //                    case "txtEmpPhoneNumber":
                //                        textBox.Text = row["EPHONE"].ToString();
                //                        break;
                //                    case "txtEmpEmail":
                //                        textBox.Text = row["EMAIL"].ToString();
                //                        break;
                //                    case "txtEmpDOB":
                //                        textBox.Text = row["DOB"].ToString();
                //                        break;
                //                    case "txtEmpGender":
                //                        textBox.Text = row["GENDER"].ToString();
                //                        break;
                //                    case "txtJobId":
                //                        textBox.Text = row["JOBID"].ToString();
                //                        break;
                //                    case "txtWorkStatus":
                //                        textBox.Text = row["WRKSTATUS"].ToString();
                //                        break;
                //                    case "txtHourlyRate":
                //                        textBox.Text = row["HRLYRATE"].ToString();
                //                        break;
                //                    case "txtEmpHireDate":
                //                        textBox.Text = row["EMHIREDT"].ToString();
                //                        break;
                //                    case "txtEmpStartDate":
                //                        textBox.Text = row["EMSTARTDT"].ToString();
                //                        break;
                //                    case "txtEmpTermDate":
                //                        textBox.Text = row["EMTERMDT"].ToString();
                //                        break;
                //                    case "txtRegionId":
                //                        textBox.Text = row["REGIONID"].ToString();
                //                        break;
                //                        // Add more cases as needed for additional TextBoxes
                //                }

                //            }
                //        }
                //    }
                //}





            }
            catch (Exception ex)
            {
                var result = MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }

       

        
        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

           

           
        }
    }
}
