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
   
    public partial class Customer : Form
    {

        //for IBM database querying
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataSet;
        

        private PyxisairFlightReservationSystem pfrs;
        private BindingSource bindingSource = new BindingSource();
        private iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
        DataTable table;

        string connectionString = "DataSource=deathstar.gtc.edu";
        string sql = "SELECT * FROM CUSTOMER";




        //string to hold the selected customer from dataGridView - passes into update button
        String selectedCustomer;

        public string SelectedCustomer { get => selectedCustomer; set => selectedCustomer = value; }



        public Customer(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Hide();
        }

        private void display(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.dataSet2.CUSTOMER);
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            display(sender, e);

        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show a confirmation dialog before closing
            var result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );


            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Close the form
                Environment.Exit(0);
            }

            if (result == DialogResult.No)
            {
                // Cancel the form close
                e.Cancel = true;
            }
        }




        protected void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //take value of Customernumber from selected cell row and populate to string for update button
                SelectedCustomer = (dataGridView1.CurrentRow.Cells[0].Value.ToString());

            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            display(sender, e);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //grab data from dataGridView

            try
            {
                //for IBM database querying
                iDB2Connection conn;
                iDB2DataAdapter adapter;
                DataSet dataSet;
                String sql;

                //build SQL query to pass to DB
                conn = new iDB2Connection(connectionString);
                conn.Open();
                sql = "Select * from CUSTOMER where CUSTNO " + " LIKE '%" + selectedCustomer + "%'";
                adapter = new iDB2DataAdapter(sql, conn);

                dataSet = new DataSet();
                adapter.Fill(dataSet);


                //show form
                UpdateCustomer updateCustomer = new UpdateCustomer();
                updateCustomer.Show();

                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dataSet.Tables[0].Rows[0];

                    foreach (GroupBox group in groups)
                    {

                        // Loop through each control inside the GroupBox
                        foreach (Control control in group.Controls)
                        {
                            if (control is TextBox textBox)
                            {
                                // Use the TextBox Name property to identify which data to assign
                                switch (textBox.Name)
                                {
                                    case "txtEmpNum":
                                        textBox.Text = row["EMPNO"].ToString();
                                        break;
                                    case "txtEmpFName":
                                        textBox.Text = row["EFNAME"].ToString();
                                        break;
                                    case "txtEmpLName":
                                        textBox.Text = row["ELNAME"].ToString();
                                        break;
                                    case "txtEmpAddress":
                                        textBox.Text = row["EADDR"].ToString();
                                        break;
                                    case "txtEmpCity":
                                        textBox.Text = row["ECITY"].ToString();
                                        break;
                                    case "txtEmpState":
                                        textBox.Text = row["ESTATE"].ToString();
                                        break;
                                    case "txtEmpZip":
                                        textBox.Text = row["EZIP"].ToString();
                                        break;
                                    case "txtEmpPhoneNumber":
                                        textBox.Text = row["EPHONE"].ToString();
                                        break;
                                    case "txtEmpEmail":
                                        textBox.Text = row["EMAIL"].ToString();
                                        break;
                                    case "txtEmpDOB":
                                        textBox.Text = row["DOB"].ToString();
                                        break;
                                    case "txtEmpGender":
                                        textBox.Text = row["GENDER"].ToString();
                                        break;
                                    case "txtJobId":
                                        textBox.Text = row["JOBID"].ToString();
                                        break;
                                    case "txtWorkStatus":
                                        textBox.Text = row["WRKSTATUS"].ToString();
                                        break;
                                    case "txtHourlyRate":
                                        textBox.Text = row["HRLYRATE"].ToString();
                                        break;
                                    case "txtEmpHireDate":
                                        textBox.Text = row["EMHIREDT"].ToString();
                                        break;
                                    case "txtEmpStartDate":
                                        textBox.Text = row["EMSTARTDT"].ToString();
                                        break;
                                    case "txtEmpTermDate":
                                        textBox.Text = row["EMTERMDT"].ToString();
                                        break;
                                    case "txtRegionId":
                                        textBox.Text = row["REGIONID"].ToString();
                                        break;
                                        // Add more cases as needed for additional TextBoxes
                                }

                            }
                        }
                    }
                }







                conn.Close();
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

    }
}
