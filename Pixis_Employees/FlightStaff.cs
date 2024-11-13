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
    public partial class FlightStaff : Form
    {
        string connectionString = "Data Source=deathstar.gtc.edu;User ID=itpa641;Initial Catalog=S101FF5C";
        private BindingSource bindingSource = new BindingSource();
        private iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
        DataTable table;
        private PyxisairFlightReservationSystem pfrs;

        public FlightStaff(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Close();
        }

        private void FlightStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnFlightStaff_Click(object sender, EventArgs e)
        {
            string flightNum = txtboxFlightNum.Text;
            if (string.IsNullOrEmpty(flightNum) )
            {
                MessageBox.Show("Please enter a flight number.");
                return;
            }

            
            string sqlStaffSched = "SELECT EMPNO FROM STAFFSCHED WHERE FLIGHTNO = @FlightNum";

            List<string> empNoList = new List<string>();

            iDB2Connection connection = null;
            iDB2Command command = null;
            iDB2DataReader reader = null;
            try
            {
                connection = new iDB2Connection(connectionString);
                connection.Open();

                //retrieves EMPNO from STAFFSCHED for the given flight number
                command = new iDB2Command(sqlStaffSched, connection);
                command.Parameters.AddWithValue("@FlightNum", flightNum);
                reader = command.ExecuteReader();

                //collects EMPNO's
                while (reader.Read())
                {
                    empNoList.Add(reader["EMPNO"].ToString());
                }

                reader.Close();
                command.Dispose();

                if(empNoList.Count == 0)
                {
                    lboxStaff.Items.Add("No employees found for the given flight number.");
                    return;
                }

                string sqlEmployee = "SELECT EFNAME, ELNAME FROM EMPLOYEE WHERE EMPNO = @EmpNo";
                List<string> employeeNames = new List<string>();

                foreach(var empNo in empNoList)
                {
                    command = new iDB2Command(sqlEmployee, connection);
                    command.Parameters.AddWithValue("@EmpNo", empNo);
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string fullName = $"{reader["EFNAME"]} {reader["ELNAME"]}";
                        employeeNames.Add(fullName);
                    }

                    reader.Close();
                    command.Dispose();
                }

                foreach(var name in employeeNames)
                {
                    lboxStaff.Items.Add($"{name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (command != null) command.Dispose();
                if (connection != null) connection.Close();
            }
        }
    }
}
