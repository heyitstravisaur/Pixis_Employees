﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pixis_Employees
{


    public partial class Employee : Form
    {
        private PyxisairFlightReservationSystem pfrs;
        private BindingSource bindingSource = new BindingSource();
        private iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
        DataTable table;

        string connectionString = "DataSource=deathstar.gtc.edu";
        string sql = "SELECT * FROM EMPLOYEE";


        public Employee(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //going to send a name for the title
            AddUpdate addUpdate = new AddUpdate(this);
            string title = "Add New Employee";
            addUpdate.title = title;
            addUpdate.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeNumber employeeNumber = new EmployeeNumber(this);
            employeeNumber.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

           
            display();
        }

        //display Data Grid View Table on form load
        private void display()
        {

            try
            {
                dataGridView1.DataSource = bindingSource;

                dataAdapter = new iDB2DataAdapter(sql, connectionString);
                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(dataAdapter);
                table = new DataTable();

                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
            }
            catch (Exception ex) { }
        }

        private void txt_filter_regionid_TextChanged(object sender, EventArgs e)
        {

            //Tried a few different attempts in filtering dataGridView1 from different approaches before settling on code below

            //1-//(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Field = '{0}'", txt_filter_regionid.Text);

            //2-//(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Field = '{REGIONID}'", txt_filter_regionid.Text);

            //3-//String columnName = "REGIONID";
            //String filterValue = txt_filter_regionid.Text;
            //string rowFilter = string.Format("[{0}] = '{1}'", columnName, filterValue);
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;


            //filter template for use
            //dataGridView1.Columns[0].HeaderText.ToString() + " LIKE '%" + txt_filter_regionid.Text + "%'"
            //+ bs.Filter = "Convert(EMPNO, 'System.String') like '%" + txt_filter_empno.Text + "%'"
            //+ dataGridView1.Columns[2].HeaderText.ToString() + " LIKE '%" + txt_filter_efname.Text + "%'"
            //+ dataGridView1.Columns[3].HeaderText.ToString() + " LIKE '%" + txt_filter_elname.Text + "%'"
            //+ dataGridView1.Columns[4].HeaderText.ToString() + " LIKE '%" + txt_filter_eaddr.Text + "%'"
            //+ dataGridView1.Columns[5].HeaderText.ToString() + " LIKE '%" + txt_filter_ecity.Text + "%'"
            //+ dataGridView1.Columns[6].HeaderText.ToString() + " LIKE '%" + txt_filter_estate.Text + "%'"
            //+ dataGridView1.Columns[7].HeaderText.ToString() + " LIKE '%" + txt_filter_ezip.Text + "%'";



            //credit to https://stackoverflow.com/questions/21845016/how-can-i-filter-a-datagridview
            //to help figure out filtering a data grid view by text

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[0].HeaderText.ToString() + " LIKE '%" + txt_filter_regionid.Text + "%'";
            dataGridView1.DataSource = bs;
            


        }

        private void txt_filter_empno_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            //bs.Filter = dataGridView1.Columns[1].HeaderText.ToString() + " LIKE '%" + txt_filter_empno.Text + "%'";

            //THANKS TO:
            //https://stackoverflow.com/questions/37022308/using-a-textbox-entry-to-filter-a-datagridview-with-an-int-value-vs-c-sharp
            //to help figure how how to filter by int rather than string
            bs.Filter = "Convert(EMPNO, 'System.String') like '%" + txt_filter_empno.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void txt_filter_efname_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[2].HeaderText.ToString() + " LIKE '%" + txt_filter_efname.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void txt_filter_elname_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[3].HeaderText.ToString() + " LIKE '%" + txt_filter_elname.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void txt_filter_eaddr_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[4].HeaderText.ToString() + " LIKE '%" + txt_filter_eaddr.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void txt_filter_ecity_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[5].HeaderText.ToString() + " LIKE '%" + txt_filter_ecity.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void txt_filter_estate_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[6].HeaderText.ToString() + " LIKE '%" + txt_filter_estate.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void txt_filter_ezip_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[7].HeaderText.ToString() + " LIKE '%" + txt_filter_ezip.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
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


        //Method for taking filtered values from datagrid to string, not using in current version
        public static string DGVtoString(DataGridView dgv, char delimiter)
        {
            StringBuilder @sb = new StringBuilder();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value);
                    sb.Append(delimiter);                  
                }
                sb.Remove(sb.Length - 1, 1); // Removes the last delimiter
                //sb.Append("\n");
                sb.AppendLine();
            }

            return @sb.ToString();
        }


        private void btn_employees_from_region_Click(object sender, EventArgs e)
        {

            //String empRegion = txt_filter_regionid.Text;

            //old filter method
            //String @regionalEmployees = DGVtoString(dataGridView1, '-' );


            if (txt_filter_regionid.Text == "")
            {
                var result = MessageBox.Show(
                    "Your employee region is empty, please populate employee region and then try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            else
            {

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
                    sql = "Select * from EMPLOYEE where REGIONID " + " LIKE '%" + txt_filter_regionid.Text + "%'";
                    adapter = new iDB2DataAdapter(sql, conn);

                    dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    listBox1.Items.Clear();
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {                        
                        listBox1.Items.Add(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4] + " " + row[5]);
                    }

                    conn.Close();
                }
                catch (Exception ex) {
                    var result = MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                }

                finally
                {
                    listBox1.Items.Add("Process has completed.");
                }
            }

        }

        private void btn_determine_state_Click(object sender, EventArgs e)
        {

            if (txt_filter_empno.Text == "")
            {
                var result = MessageBox.Show(
                    "Your employee number is empty, please populate employee region and then try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            else
            {

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
                    sql = "Select * from EMPLOYEE where EMPNO " + " LIKE '%" + txt_filter_empno.Text + "%'";
                    adapter = new iDB2DataAdapter(sql, conn);

                    dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    listBox1.Items.Clear();
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        //this is a comment
                        listBox1.Items.Add(row[1] + " " + row[2] + " " + row[3] + " " + row[5]);
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

                finally
                {
                    listBox1.Items.Add("Process has completed.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
