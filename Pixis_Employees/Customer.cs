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
        private PyxisairFlightReservationSystem pfrs;
        private BindingSource bindingSource = new BindingSource();
        private iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
        DataTable table;

        string connectionString = "DataSource=deathstar.gtc.edu";
        string sql = "SELECT * FROM CUSTOMER";


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
                sql = "Select * from CUSTOMER; ";
                    //where REGIONID " + " LIKE '%" + txt_filter_regionid.Text + "%'";
                adapter = new iDB2DataAdapter(sql, conn);

                dataSet = new DataSet();
                adapter.Fill(dataSet);

                //listBox1.Items.Clear();
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    //listBox1.Items.Add(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4] + " " + row[5]);
                }

                //show form
                UpdateCustomer updateCustomer = new UpdateCustomer();
                updateCustomer.Show();

                //conn.Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }
    }
}
