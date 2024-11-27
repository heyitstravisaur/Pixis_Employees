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
        DataSet customerDataSet = new DataSet();


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

        private void display(object sender, DataSet customerDataSet, EventArgs e)
        {
            conn = new iDB2Connection(connectionString);
            conn.Open();
            iDB2DataAdapter adapter = new iDB2DataAdapter(sql, conn);
            customerDataSet.Clear();
            adapter.Fill(customerDataSet, "CUSTOMER");

            bindingSource.DataSource = customerDataSet.Tables["CUSTOMER"];
            dataGridView1.DataSource = bindingSource;

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            display(sender, customerDataSet, e);

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
            display(sender, customerDataSet, e);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            selectedCustomer = null; //make sure selectedCustomer is nulled out so new record option is chosen on next form.
            //show form
            UpdateCustomer addCustomer = new UpdateCustomer(selectedCustomer, connectionString, conn, adapter);
            addCustomer.Show();
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        {
                            MessageBox.Show($"Row {row.Index + 1} has empty fields. Please complete all fields before updating.");
                            return;
                        }
                    }
                }

                bindingSource.EndEdit();

                using (iDB2Connection conn = new iDB2Connection(connectionString))
                {
                    conn.Open();
                    string updateQuery = @"UPDATE CUSTOMER SET 
                                            CFNAME = @CFNAME,
                                            CLNAME = @CLNAME,
                                            CADDR = @CADDR,
                                            CCITY = @CCITY,
                                            CSTATE = @CSTATE,
                                            CZIP = @CZIP,
                                            CPHONE = @CPHONE,
                                            CEMAIL = @CEMAIL,
                                            CDOB = @CDOB,
                                            CGENDER = @CGENDER, 
                                            CPWORD = @CPWORD,
                                            CSCCARDNO = @CSCCARDNO,
                                            CSPYMTSTL = @CSPYMTSTL,
                                            CPWORDHASH = @CPWORDHASH
                                           WHERE CUSTNO = @CUSTNO";

                    foreach (DataRow row in customerDataSet.Tables["CUSTOMER"].Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            iDB2Command cmd = new iDB2Command(updateQuery, conn);
                            cmd.Parameters.Add(new iDB2Parameter("@CUSTNO", iDB2DbType.iDB2Decimal) { Value = Convert.ToDecimal(row["CUSTNO"])});
                            cmd.Parameters.Add(new iDB2Parameter("@CFNAME", iDB2DbType.iDB2Char) { Value = row["CFNAME"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@CLNAME", iDB2DbType.iDB2Char) { Value = row["CLNAME"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@CADDR", iDB2DbType.iDB2Char) { Value = row["CADDR"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@CCITY", iDB2DbType.iDB2Char) { Value = row["CCITY"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@CSTATE", iDB2DbType.iDB2Char) { Value = row["CSTATE"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@CZIP", iDB2DbType.iDB2Decimal) { Value = Convert.ToDecimal(row["CZIP"]) });
                            cmd.Parameters.Add(new iDB2Parameter("@CPHONE", iDB2DbType.iDB2Decimal) { Value = Convert.ToDecimal(row["CPHONE"]) });
                            cmd.Parameters.Add(new iDB2Parameter("@CEMAIL", iDB2DbType.iDB2Char) { Value = row["CEMAIL"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@CDOB", iDB2DbType.iDB2Date) { Value = DateTime.Parse(row["CDOB"].ToString()) });
                            cmd.Parameters.Add(new iDB2Parameter("@CGENDER", iDB2DbType.iDB2Char) { Value = row["CGENDER"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@CPWORD", iDB2DbType.iDB2Char) { Value = row["CPWORD"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@CSCCARDNO", iDB2DbType.iDB2Char) { Value = row["CSCCARDNO"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@CSPYMTSTL", iDB2DbType.iDB2Decimal) { Value = Convert.ToDecimal(row["CSPYMTSTL"]) });
                            cmd.Parameters.Add(new iDB2Parameter("@CPWORDHASH", iDB2DbType.iDB2Decimal) { Value = Convert.ToDecimal(row["CPWORDHASH"]) });

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Records updated successfully.");


                //try
                //{


                //    if (selectedCustomer == null || selectedCustomer == "")
                //    {
                //        var result = MessageBox.Show(
                //        "Please double click a Customer Number before clicking update.",
                //        "Error",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Error
                //        );
                //    }
                //    else
                //    {
                //        //build SQL query to pass to DB
                //        conn = new iDB2Connection(connectionString);
                //        conn.Open();

                //        string query = "SELECT * FROM CUSTOMER WHERE CUSTNO" + " LIKE '%" + SelectedCustomer + "%'";
                //        iDB2DataAdapter adapter = new iDB2DataAdapter(query, conn);
                //        adapter = new iDB2DataAdapter(sql, conn);



                //        customerDataSet = new DataSet();
                //        adapter.Fill(customerDataSet);

                //        UpdateCustomer updateCustomer = new UpdateCustomer(selectedCustomer, connectionString, conn, adapter, customerDataSet);
                //        updateCustomer.Show();


                //    }
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
