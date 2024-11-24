using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;//this is added with the ddl file from ibm folder
//Izac Ordonez
//The design of this code was mostly based on the CRUD lab. 
//Instead of having seperate buttons for add and update, i wanted to make it one button
//and use and if else to check if the Zip code was already in use. Zip code being the primary 
//key for the table, should only produce one result. So if that zipcode wasnt in use the 
//else would add the data to the table

namespace Pixis_Employees
{
    public partial class Location : Form
    {
        //the connection adapter and dataset are going to be used to fill the listbox
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;

        private PyxisairFlightReservationSystem pfrs;//Code set up by Alex

        public Location(PyxisairFlightReservationSystem form)//Code set up by Alex
        {
            InitializeComponent();
            pfrs = form;
        }

        private void btnExit_Click(object sender, EventArgs e)//Code set up by Alex
        {
            pfrs.Show();
            this.Close();
        }

        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When starting the project I was thinking about having a listbox for zip, city and state.
            //After seeing it i felt differently.
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            string sql;//This is going to be the statement used to run on the db2
            try
            {
                conn = new iDB2Connection("DataSource=10.250.0.30");//connecting to deathstar using the IP address
                sql = "SELECT ZIP, CITY, STATE FROM ZIPCODE";//Selecting the fields from the zipcode table. Select * from Zipcode
                                                             //would work too, since that table only has the three columns
                adapter = new iDB2DataAdapter(sql, conn);//The adapter works as a connection from the db to the dataset.
                dataset = new DataSet();                //the dataset is where the data from the adapter is going to go
                adapter.Fill(dataset);                  //use the Fill.(ds) to then fill the ds with the data from the adapter which comes from the (sql, conn) parameters
                listBoxZipCodeTable.Items.Clear();      //clear the table of old data before repopulating it with new data.
                listBoxZipCodeTable.Items.Add("-------------------------------------Zip Code, City, State--------------------------------------------");//listbox heading
                foreach (DataRow pRow in dataset.Tables[0].Rows)
                    listBoxZipCodeTable.Items.Add(pRow[0] + "         " + pRow[1] + "        " + pRow[2]);
                listBoxZipCodeTable.Items.Add("---------------------------------------------------------------------------------------------------------");//listbox footer
                //conn.Close(); moved this to the finally

            }
            catch (Exception ex)
            {
                listBoxZipCodeTable.Items.Add(ex.Message);//if an error display this in the listbox.
            }
            finally { conn.Close(); }//close the connection
        }

        private void buttonAddUpdate_Click(object sender, EventArgs e)
        {
            {
                //Variables for the content from the textboxes, and toUpper() the ones needed to match the database
                string zipCode = textBoxZip.Text;
                string city = textBoxCity.Text.ToUpper();
                string state = textBoxState.Text.ToUpper();

                try
                {
                    conn = new iDB2Connection("DataSource=10.250.0.30");//connecting to deathstar using the IP address
                    conn.Open();//Open the connection that was just made to the db
                    string selectCmdText = "SELECT COUNT(*) FROM ZIPCODE WHERE ZIP = @ZIP";//the count(*) that counts all that match the where statement
                                                                                           //Since the zipcode is unique, there should never be more than 1
                    iDB2Command selectCmd = new iDB2Command(selectCmdText, conn);//this is going run the sql statement to the database
                    selectCmd.Parameters.AddWithValue("@ZIP", zipCode);//this assigns the zipCode variable to @ZIP 
                    int count = Convert.ToInt32(selectCmd.ExecuteScalar());//This int is going to be the determing thing to decide if the button is going to add or
                                                                           //update data. executeScalar() brings back a single value from the query which is then converted
                                                                           //to int and added to the count. 
                    if (count > 0)//If the query found a zipcode, then this if statement will execute
                    {
                        string updateCmdText = "UPDATE ZIPCODE SET CITY = @CITY, STATE = @STATE WHERE ZIP = @ZIP";//an update query
                        iDB2Command updateCmd = new iDB2Command(updateCmdText, conn);//runs the query to the db
                        updateCmd.Parameters.AddWithValue("@ZIP", zipCode);//links the variables from the form to the placeholder of the query
                        updateCmd.Parameters.AddWithValue("@CITY", city);//links the variables from the form to the placeholder of the query
                        updateCmd.Parameters.AddWithValue("@STATE", state);//links the variables from the form to the placeholder of the query
                        updateCmd.ExecuteNonQuery();//since the query is not returning a value ExecuteNonQuery() is used

                        labelMessage.Text = "Zip code updated successfully.";//I figured the listbox might be already filled, so instead of having the user  
                                                                             //scroll to the bottom, i added a lable that would display this on the bottom of the form
                    }
                    else//if the count remains 0, then no zipcodes where found and the else statement will execute
                    {
                        string insertCmdText = "INSERT INTO ZIPCODE (ZIP, CITY, STATE) VALUES (@ZIP, @CITY, @STATE)";//an insert query
                        iDB2Command insertCmd = new iDB2Command(insertCmdText, conn);//runs the query to the db
                        insertCmd.Parameters.AddWithValue("@ZIP", zipCode);//links the variables from the form to the placeholder of the query
                        insertCmd.Parameters.AddWithValue("@CITY", city);//links the variables from the form to the placeholder of the query
                        insertCmd.Parameters.AddWithValue("@STATE", state);//links the variables from the form to the placeholder of the query
                        insertCmd.ExecuteNonQuery();//since the query is not returning a value ExecuteNonQuery() is used

                        labelMessage.Text = "New zip code added successfully.";//I figured the listbox might be already filled, so instead of having the user  
                                                                               //scroll to the bottom, i added a lable that would display this on the bottom of the form
                    }
                }
                catch (Exception ex)
                {
                    labelMessage.Text = "Error: " + ex.Message;//I figured the listbox might be already filled, so instead of having the user  
                                                               //scroll to the bottom, i added a lable that would display this on the bottom of the form
                }
                finally { conn.Close();}//close the connection
            }
        }

        private void Location_Load(object sender, EventArgs e)
        {

        }
    }
}
