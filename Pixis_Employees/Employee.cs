using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace Pixis_Employees
{
    //delete this line

    public partial class Employee : Form
    {
        private PyxisairFlightReservationSystem pfrs;
        private BindingSource bindingSource = new BindingSource();
        private iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
        DataTable table;

        public Employee(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //going to send a name for the title
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeNumber employeeNumber = new EmployeeNumber(this);
            employeeNumber.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

            //try catch block to populate combobox
            string sql = "SELECT COLUMN0 FROM EMPLOYEE";

            try
            {
                string connectionString = "DataSource=deathstar.gtc.edu";
                comboBoxRegion.DataSource = bindingSource;

                dataAdapter = new iDB2DataAdapter(sql, connectionString);
                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(dataAdapter);
                table = new DataTable();

                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
            }
            catch (Exception ex) { }
            //end combobox population

            display();
        }

        private void display()
        {
            string connectionString = "DataSource=deathstar.gtc.edu";
            string sql = "SELECT * FROM EMPLOYEE";

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
            //+ dataGridView1.Columns[1].HeaderText.ToString() + " LIKE '%" + txt_filter_empno.Text + "%'"
            //+ dataGridView1.Columns[2].HeaderText.ToString() + " LIKE '%" + txt_filter_efname.Text + "%'"
            //+ dataGridView1.Columns[3].HeaderText.ToString() + " LIKE '%" + txt_filter_elname.Text + "%'"
            //+ dataGridView1.Columns[4].HeaderText.ToString() + " LIKE '%" + txt_filter_eaddr.Text + "%'"
            //+ dataGridView1.Columns[5].HeaderText.ToString() + " LIKE '%" + txt_filter_ecity.Text + "%'"
            //+ dataGridView1.Columns[6].HeaderText.ToString() + " LIKE '%" + txt_filter_estate.Text + "%'"
            //+ dataGridView1.Columns[7].HeaderText.ToString() + " LIKE '%" + txt_filter_ezip.Text + "%'";



            //credit to https://stackoverflow.com/questions/21845016/how-can-i-filter-a-datagridview
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[0].HeaderText.ToString() + " LIKE '%" + txt_filter_regionid.Text + "%'";
            dataGridView1.DataSource = bs;


        }

        private void txt_filter_empno_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[1].HeaderText.ToString() + " LIKE '%" + txt_filter_empno.Text + "%'";
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

    }
}
