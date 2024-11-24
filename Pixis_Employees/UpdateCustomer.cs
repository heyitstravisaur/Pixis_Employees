using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pixis_Employees
{
    public partial class UpdateCustomer : Form
    {


        String sql;
        string connectionString = "Data Source=deathstar.gtc.edu;Initial Catalog=S101FF5C";


        public string selectedCustomer { get; set; }
        public iDB2Connection conn { get; set; }
        public iDB2DataAdapter adapter { get; set; }
        public DataSet dataSet { get; set; }

        private void checkAddOrUpdate(string selectedCustomer)
        {

            //code if add gets us here, selected customer will be null and let us add record, if not null it's update function and pull customer record
            if (selectedCustomer != null)
            {
                btnAdd.Hide();
                listBox1.Items.Add("\nUpdate Customer form, please edit information and then click Update Existing Customer.");
            }
            else
            {
                btnUpdate.Hide();
                listBox1.Items.Add("\nAdd Customer form, please fill out all information and then click Add New Customer.");
            }
        }

        public UpdateCustomer(string selectedCustomer, string connectionString, iDB2Connection conn, iDB2DataAdapter adapter)
        {
            //add customer initialize
            InitializeComponent();
            checkAddOrUpdate(selectedCustomer);


        }

        public UpdateCustomer(string selectedCustomer, string connectionString, iDB2Connection conn, iDB2DataAdapter adapter, DataSet dataSet)
        {
            //update customer initialize
            InitializeComponent();
            checkAddOrUpdate(selectedCustomer);
            LoadUpdateCustomerRecord(selectedCustomer, connectionString, conn, adapter, dataSet);  
        }



        protected void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }

        //method to add to customer table
        private void AddCustomerRecord(object sender, string connectionString, EventArgs e)
        {

            //error handling code for all of the textboxes
            int parsedValue;

            // if customer number is empty
            if (txtCustNum.Text == "" || txtCustNum.Text == null)
            {
                var result = MessageBox.Show(
                "Customer Number is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if Customer number has any non number characters
            else if (!int.TryParse(txtCustNum.Text, out parsedValue))
            {
                var result = MessageBox.Show(
                "Customer Number field can only contain numbers.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if first name is empty
            else if (txtCustFName.Text == "" || txtCustFName.Text == null)
            {
                var result = MessageBox.Show(
                "Customer First Name field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            //if first name has any  number characters          
            else if (int.TryParse(txtCustFName.Text, out parsedValue))
            {
                var result = MessageBox.Show(
                "Customer First Name field cannot contain numbers.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if last name is empty
            else if (txtCustLName.Text == "" || txtCustLName.Text == null)
            {
                var result = MessageBox.Show(
                "Customer Last Name field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            //if last name has any number characters          
            else if (int.TryParse(txtCustLName.Text, out parsedValue))
            {
                var result = MessageBox.Show(
                "Customer Last Name field cannot contain numbers.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if address is empty
            else if (txtCustAddress.Text == "" || txtCustAddress.Text == null)
            {
                var result = MessageBox.Show(
                "Customer Address field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if city is empty
            else if (txtCustCity.Text == "" || txtCustCity.Text == null)
            {
                var result = MessageBox.Show(
                "Customer City field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            //if city has any number characters          
            else if (int.TryParse(txtCustCity.Text, out parsedValue))
            {
                var result = MessageBox.Show(
                "Customer City field cannot contain numbers.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if State is empty
            else if (txtCustState.Text == "" || txtCustState.Text == null)
            {
                var result = MessageBox.Show(
                "Customer State field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if state has any number characters          
            else if (int.TryParse(txtCustState.Text, out parsedValue))
            {
                var result = MessageBox.Show(
                "Customer State field cannot contain numbers.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if zip code is empty
            else if (txtCustZip.Text == "" || txtCustZip.Text == null)
            {
                var result = MessageBox.Show(
                "Customer Zip Code field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if zip code has any non-number characters          
            else if (!int.TryParse(txtCustZip.Text, out parsedValue))
            {
                var result = MessageBox.Show(
                "Customer Zip Code field can only contain numbers.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }


            //if phone is empty
            else if (txtCustPhoneNumber.Text == "" || txtCustPhoneNumber.Text == null)
            {
                var result = MessageBox.Show(
                "Customer Phone Number field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }


            //if email is empty
            else if (txtCustEmail.Text == "" || txtCustEmail.Text == null)
            {
                var result = MessageBox.Show(
                "Customer Email field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            
            //if DOB is empty
            else if (txtCustDOB.Text == "" || txtCustDOB.Text == null)
            {
                var result = MessageBox.Show(
                "Customer D.O.B. field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if gender is not M or f
            else if (txtCustGender.Text != "M" && txtCustGender.Text != "F")
            {
                var result = MessageBox.Show(
                "Gender can only be listed as 'M' or 'F'",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }


            //if password is empty
            else if (txtCustPassword.Text == "" || txtCustPassword.Text == null)
            {
                var result = MessageBox.Show(
                "Customer Password field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }


            //if credit card is empty
            else if (txtCustCreditCard.Text == "" || txtCustCreditCard.Text == null)
            {
                var result = MessageBox.Show(
                "Customer Credit Card field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }


            //if CSPYMTSTL card has any non-number characters          
            else if (!int.TryParse(txtCustCSPYMTSTL.Text, out parsedValue))
            {
                var result = MessageBox.Show(
                "CSPYMTSTL field can only contain numbers.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if CSPYMTSTL card is empty
            else if (txtCustCSPYMTSTL.Text == "" || txtCustCSPYMTSTL.Text == null)
            {
                var result = MessageBox.Show(
                "CSPYMTSTL field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if Customer Password Hash has any non-number characters          
            else if (!int.TryParse(txtCustPasswordHash.Text, out parsedValue))
            {
                var result = MessageBox.Show(
                "Customer Password Hash field can only contain numbers.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }

            //if Customer Password Hash card is empty
            else if (txtCustPasswordHash.Text == "" || txtCustPasswordHash.Text == null)
            {
                var result = MessageBox.Show(
                "Customer Password Hash field is empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }


            else
            {

                try
                {

                    conn = new iDB2Connection(connectionString);
                    conn.Open();

                    string cmdText = "INSERT INTO CUSTOMER Values(@CUSTNO, @CFNAME, @CLNAME, @CADDR, @CCITY, @CSTATE, @CZIP, @CPHONE, @CEMAIL, @CDOB, @CGENDER, @CPWORD, @CSCCARDNO, @CSPYMTSTL, @CPWORDHASH)";



                    iDB2Command cmd = new iDB2Command(cmdText, conn);
                    cmd.DeriveParameters();

                    cmd.Parameters["@CUSTNO"].Value = txtCustNum.Text;
                    cmd.Parameters["@CFNAME"].Value = txtCustFName.Text;
                    cmd.Parameters["@CLNAME"].Value = txtCustLName.Text;
                    cmd.Parameters["@CADDR"].Value = txtCustAddress.Text;
                    cmd.Parameters["@CCITY"].Value = txtCustCity.Text;
                    cmd.Parameters["@CSTATE"].Value = txtCustState.Text;
                    cmd.Parameters["@CZIP"].Value = txtCustZip.Text;
                    cmd.Parameters["@CPHONE"].Value = txtCustPhoneNumber.Text;
                    cmd.Parameters["@CEMAIL"].Value = txtCustEmail.Text;
                    cmd.Parameters["@CDOB"].Value = txtCustDOB.Text;
                    cmd.Parameters["@CGENDER"].Value = txtCustGender.Text;
                    cmd.Parameters["@CPWORD"].Value = txtCustPassword.Text;
                    cmd.Parameters["@CSCCARDNO"].Value = txtCustCreditCard.Text;
                    cmd.Parameters["@CSPYMTSTL"].Value = txtCustCSPYMTSTL.Text;
                    cmd.Parameters["@CPWORDHASH"].Value = txtCustPasswordHash.Text;
                    cmd.ExecuteNonQuery();



                    //hard coding values test
                    //cmd.Parameters["@CUSTNO"].Value = 5123;
                    //cmd.Parameters["@CFNAME"].Value = "Travis";
                    //cmd.Parameters["@CLNAME"].Value = "Dunk";
                    //cmd.Parameters["@CADDR"].Value = "1001 Main";
                    //cmd.Parameters["@CCITY"].Value = "Racine";
                    //cmd.Parameters["@CSTATE"].Value = "WI";
                    //cmd.Parameters["@CZIP"].Value = 53403;
                    //cmd.Parameters["@CPHONE"].Value = 12345678;
                    //cmd.Parameters["@CEMAIL"].Value = "td@gtc.edu";
                    //cmd.Parameters["@CDOB"].Value = "1989-07-13";
                    //cmd.Parameters["@CGENDER"].Value = "M";
                    //cmd.Parameters["@CPWORD"].Value = "23fans244";
                    //cmd.Parameters["@CSCCARDNO"].Value = "754782992"; //has to be string
                    //cmd.Parameters["@CSPYMTSTL"].Value = 25451.10;
                    //cmd.Parameters["@CPWORDHASH"].Value = 4209; // hash can only be 4 numbers
                    //cmd.ExecuteNonQuery();


                    //listBox1.Items.Add(cmd.Parameters.ToString());
                    //listBox1.Items.Add("Data added to the record, click display data button to view!");


                    var result = MessageBox.Show(
                    "Record has been added! Please refresh the table to view.",
                    "Record Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                    this.Close();
                }

                catch (Exception ex) { listBox1.Items.Add(ex.Message); }

                finally 
                { 
                    conn.Close(); 
                    
                }
            }

        }

        //method to update record to customer table
        private void LoadUpdateCustomerRecord(string selectedCustomer, string connectionString, iDB2Connection conn, iDB2DataAdapter adapter, DataSet dataSet)
        {
            //establish connection from pulled customer record into the update form
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataRow row = ds.Tables[0].Rows[0];


            //start reading data into the text fields
            txtCustNum.Text = row["CUSTNO"].ToString();
            txtCustFName.Text = row["CFNAME"].ToString();
            txtCustLName.Text = row["CLNAME"].ToString();
            txtCustAddress.Text = row["CADDR"].ToString();
            txtCustCity.Text = row["CCITY"].ToString();
            txtCustState.Text = row["CSTATE"].ToString();
            txtCustZip.Text = row["CZIP"].ToString();
            txtCustPhoneNumber.Text = row["CPHONE"].ToString();
            txtCustEmail.Text = row["CEMAIL"].ToString();
            txtCustDOB.Text = row["CDOB"].ToString();
            txtCustGender.Text = row["CGENDER"].ToString();
            txtCustPassword.Text = row["CPWORD"].ToString();
            txtCustCreditCard.Text = row["CSCCARDNO"].ToString();
            txtCustCSPYMTSTL.Text = row["CSPYMTSTL"].ToString();
            txtCustPasswordHash.Text = row["CPWORDHASH"].ToString();



        }


        private void btnAdd_Click(object sender, EventArgs e)
        {


            //open connection to IDB2 to update live data, pass through connectionstring from Customer form
            AddCustomerRecord(sender, connectionString, e);  
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                conn = new iDB2Connection(connectionString);
                conn.Open();

                string cmdText = "UPDATE CUSTOMER SET CFNAME = '@CFNAME' WHERE CUSTNO = " + txtCustNum.Text;

                //hard coded cmdText Test example
                //string cmdText = "UPDATE CUSTOMER SET CFNAME = 'JACK' WHERE CUSTNO = 342187361";

                //string cmdText = "UPDATE CUSTOMER SET " +
                //    "CUSTNO = '" + txtCustNum.Text + "', " +
                //    "CFNAME = '" + txtCustFName.Text + "', " +
                //    "CLNAME = '" + txtCustLName.Text + "', " +
                //    "CADDR = '" + txtCustAddress.Text + "', " +
                //    "CCITY = '" + txtCustCity.Text + "', " +
                //    "CSTATE = '" + txtCustState.Text + "', " +
                //    "CZIP = '" + txtCustZip.Text + "', " +
                //    "CPHONE = '" + txtCustPhoneNumber.Text + "', " +
                //    "CDOB = '" + txtCustDOB.Text + "', " +
                //    "CPWORD = '" + txtCustPassword.Text + "', " +
                //    "CSCCARDNO = '" + txtCustCreditCard.Text + "', " +
                //    "CSPYMTSTL = '" + txtCustCSPYMTSTL.Text + "', " +
                //    "CPWORDHASH = '" + txtCustPasswordHash.Text + "', " +
                //    "WHERE CUSTNO = " + txtCustNum.Text;


                iDB2Command cmd = new iDB2Command(cmdText, conn);
                cmd.DeriveParameters();

                cmd.Parameters["@CFNAME"].Value = txtCustFName.Text;

                cmd.ExecuteNonQuery();

               

                var result2 = MessageBox.Show(
                cmd.ToString(),
                "Query sending",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );


                cmd.ExecuteNonQuery();

                var result = MessageBox.Show(
                "Record has been updated! Please refresh the table to view.",
                "Record Added",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
                this.Close();
            }
            catch(Exception ex)
            {
                var result = MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                this.Close();
            }


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
