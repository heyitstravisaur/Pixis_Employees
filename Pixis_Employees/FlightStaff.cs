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
        // connection string details to connect to the db2 database
        // variable reference to navigate back to the main form when user exits this form
        string connectionString = "Data Source=deathstar.gtc.edu;User ID=itpa641;Initial Catalog=S101FF5C";
        private PyxisairFlightReservationSystem pfrs;

        // constructor
        public FlightStaff(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        // exit button to close this form, and to show the main form when closed
        private void btnExit_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Close();
        }

        // load event handler
        private void FlightStaff_Load(object sender, EventArgs e)
        {
            // calls this method to populate the listbox with distinct flight numbers from 
            // the STAFFSCHED table
            PopulateListBox(lboxStaff, "SELECT DISTINCT FLIGHTNO FROM STAFFSCHED");
        }

        // listbox selection on click
        private void lboxStaff_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // when an item is selected in the listbox, calls the method and passes
            // the selected item to the method
            if (lboxStaff.SelectedItem is string selectedFlightNo)
            {
                LoadEmployeeDetails(selectedFlightNo);
            }
        }

        // reset button, when clicked repopulates the listbox by calling the 
        // populatelistbox method again
        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateListBox(lboxStaff, "SELECT DISTINCT FLIGHTNO FROM STAFFSCHED");
        }

        // populatelistbox method which does an sql query to then populate the provided listbox
        private void PopulateListBox(ListBox listBox, string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                // clears the listbox
                listBox.Items.Clear();

                // creates a connection to the database
                // the reason i went with using instead was i read a bit about how
                // using will automatically close the connection when the block ended.
                // but it im not sure if the extra code is all that worth it
                using (var connection = new iDB2Connection(connectionString))
                {
                    // opens db connection
                    connection.Open();

                    // creates a command object to execute the sql query
                    using (var command = new iDB2Command(query, connection))
                    {
                        // checks that param is not null, then loops thru each key-value pair
                        // in the parameters dict, then adds the key-value pair to the command object
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                command.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        // executes the sql, reads the results row by row, Read() called in a loop to advance the reader
                        // as long as it returns true, then converts from object to string and adds to listbox
                        // a lot of this is really confusing and took a lot of time to get right. i think my
                        // python class helped fill in a lot of blanks but def didnt know a lot of this 
                        // might not remember a lot of it either
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listBox.Items.Add(reader[0].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // error handling in case theres issues populating the list
                MessageBox.Show("Error populating list: " + ex.Message);
            }
        }

        // loademployeedetails method which is to load the employee details
        private void LoadEmployeeDetails(string flightNo)
        {
            // sql query that joins both STAFFSCHED and EMPLOYEE tables
            // to reduce on code needed, which took forever to figure out
            // || ' ' || combines first and last name into a single string as fullname
            // @ makes the sql search more specific
            string query = @"SELECT E.EFNAME || ' ' || E.ELNAME AS FullName
                            FROM STAFFSCHED S
                            JOIN EMPLOYEE E ON S.EMPNO = E.EMPNO
                            WHERE S.FLIGHTNO = @FlightNo";

            // parameter dictionary for passing in flexible way as dictionaries are immutable
            var parameters = new Dictionary<string, object>
            {
                { "@FlightNo", flightNo }
            };

            PopulateListBox(lboxStaff, query, parameters);

            if (lboxStaff.Items.Count == 0)
            {
                lboxStaff.Items.Add("No employess found for this flight");
            }
        }
            
     
            private void btnFlightStaff_Click(object sender, EventArgs e)
            {

            }
        

        }
    } 
