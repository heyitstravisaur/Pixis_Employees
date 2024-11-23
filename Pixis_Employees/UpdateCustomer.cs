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


        String sql;
        string connectionString = "DataSource=deathstar.gtc.edu";


        public string selectedCustomer { get; set; }
        public iDB2Connection conn { get; set; }
        public iDB2DataAdapter adapter { get; set; }
        public DataSet dataSet { get; set; }

        public UpdateCustomer(string selectedCustomer, string connectionString, iDB2Connection conn, iDB2DataAdapter adapter)
        {

            InitializeComponent();



        }

       
        
        protected void UpdateCustomer_Load(object sender, EventArgs e)
        {


        }

        //method to add to customer table
        private void AddCustomerRecord(object sender, string connectionString, iDB2Connection conn, EventArgs e)
        {
            
            string cmdText = "INSERT INTO CUSTOMER Values(@CUSTNO, @CFNAME, @CLNAME, @CADDR, @CCITY, @CSTATE, @CSTATE, @CPHONE, @CEMAIL, @CDOB, @CGENDER, @CPWORD, @CSCCARD, @CSPYMTSTL, @CPWORDHASH);";

            try
            {
            

                iDB2Command cmd = new iDB2Command(cmdText, conn);
                cmd.DeriveParameters();

                cmd.Parameters["@CUSTNO"].Value = txtCustNum.Text;
                cmd.Parameters["@CFNAME"].Value = txtCustFName.Text;
                cmd.Parameters["@CLNAME"].Value = txtCustLName.Text;
                cmd.Parameters["@CADDR"].Value = txtCustAddress.Text;
                cmd.Parameters["@CCITY"].Value = txtCustCity.Text;
                cmd.Parameters["@CSTATE"].Value = txtCustState.Text;
                cmd.Parameters["@CPHONE"].Value = txtCustPhoneNumber.Text;
                cmd.Parameters["@CEMAIL"].Value = txtCustEmail.Text;
                cmd.Parameters["@CDOB"].Value = txtCustDOB.Text;
                cmd.Parameters["@CGENDER"].Value = txtCustGender.Text;
                cmd.Parameters["@CPWORD"].Value = txtCustPassword.Text;
                cmd.Parameters["@CSCCARD"].Value = txtCustCreditCard.Text;
                cmd.Parameters["@CSPYMTSTL"].Value = txtCustCSPYMTSTL.Text;
                cmd.Parameters["@CPWORDHASH"].Value = txtCustPasswordHash.Text;
                //cmd.ExecuteNonQuery();


                listBox1.Items.Add(cmd.Parameters.ToString());
                listBox1.Items.Add("Data added to the record, click display data button to view!");
            }

            catch (Exception ex) { listBox1.Items.Add(ex.Message); }

            finally { conn.Close(); }
        }

        //method to update record to customer table
        private void UpdateCustomerRecord(object sender, EventArgs e)
        {


            try

            {

                //sql statement building, taking selectedCustomer from Customer form
                sql = "Select * from CUSTOMER where CUSTNO " + " LIKE '%" + selectedCustomer + "%'";
                adapter = new iDB2DataAdapter(sql, conn);

                adapter.Fill(dataSet);

                adapter.ToString();


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



        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn = new iDB2Connection(connectionString);
            conn.Open();

            //open connection to IDB2 to update live data, pass through connectionstring from Customer form


            AddCustomerRecord(sender, connectionString, conn, e);  
        }
    }
}
