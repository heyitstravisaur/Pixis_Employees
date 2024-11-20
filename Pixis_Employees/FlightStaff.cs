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
        //private iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
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
            LoadFlightNumbers();
        }

        private void LoadFlightNumbers()
        {
            string sqlFlightNumbers = "SELECT DISTINCT FLIGHTNO FROM STAFFSCHED";

            using(iDB2Connection connection = new iDB2Connection(connectionString))
            {
                try
                {
                    connection.Open();
                    using(iDB2Command command = new iDB2Command(sqlFlightNumbers, connection))
                    using(iDB2DataReader reader = command.ExecuteReader())
                    {
                        lboxStaff.Items.Clear();

                        while(reader.Read())
                        {
                            lboxStaff.Items.Add(reader["FLIGHTNO"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading flight number: " +  ex.Message);
                }
            }
        }
        private void lboxStaff_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lboxStaff.SelectedIndex == null) return;

            string selectedFlightNo = lboxStaff.SelectedItem.ToString();
            LoadEmployeeDetails(selectedFlightNo);
        }
        private void lboxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LoadEmployeeDetails(string flightNo)
        {
            string sqlStaffSched = "SELECT EMPNO FROM STAFFSCHED WHERE FLIGHTNO = @FlightNo";
            string sqlEmployee = "SELECT EFNAME, ELNAME FROM EMPLOYEE WHERE EMPNO = @EmpNo";

            List<string> empNoList = new List<string>();
            List<string> employeeNames = new List<string>();

            using(iDB2Connection connection = new iDB2Connection(connectionString))
            {
                try
                {
                    connection.Open();

                    using(iDB2Command command = new iDB2Command(sqlStaffSched, connection))
                    {
                        command.Parameters.AddWithValue("@FlightNo", flightNo);

                        using(iDB2DataReader  reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                empNoList.Add(reader["EMPNO"].ToString());
                            }
                        }
                    }

                    foreach(var empNo in empNoList)
                    {
                        using(iDB2Command command = new iDB2Command(sqlEmployee, connection))
                        {
                            command.Parameters.AddWithValue("@EmpNo", empNo);

                            using(iDB2DataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string fullName = $"{reader["EFNAME"]} {reader["ELNAME"]}";
                                    employeeNames.Add(fullName);
                                }
                            }
                        }
                    }

                    lboxStaff.Items.Clear();
                    if(employeeNames.Count > 0)
                    {
                        foreach(var name in employeeNames)
                        {
                            lboxStaff.Items.Add(name);
                        }
                    }
                    else
                    {
                        lboxStaff.Items.Add("No employees found for the selected flight.");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error loading employee details: " +  ex.Message);
                }
            }
        }

        private void btnFlightStaff_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                lboxStaff.Items.Clear();

                LoadFlightNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting listbox: " + ex.Message);
            }
        }
    }
}
