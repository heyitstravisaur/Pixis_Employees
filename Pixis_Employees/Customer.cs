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
            //show form
            UpdateCustomer addCustomer = new UpdateCustomer(selectedCustomer, connectionString, conn, adapter);
            addCustomer.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {


            try

            {
                //passing Customer to Updatecustomer value
                selectedCustomer = SelectedCustomer;

                if (selectedCustomer == null)
                {
                    throw new ArgumentNullException();
                }

                else
                {

                    //show form
                    UpdateCustomer updateCustomer = new UpdateCustomer(selectedCustomer, connectionString, conn, adapter);
                    updateCustomer.Show();
                }


            }
            catch (ArgumentNullException ex) 
            {
                var result = MessageBox.Show(
                "Please choose a cell before continuing.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
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
