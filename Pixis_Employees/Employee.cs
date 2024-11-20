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
    }
}
