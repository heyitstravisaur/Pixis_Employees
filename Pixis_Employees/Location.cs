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
    public partial class Location : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;
        private PyxisairFlightReservationSystem pfrs;

        public Location(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Close();
        }

        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                conn = new iDB2Connection("DataSource=10.250.0.30");
                sql = "SELECT ZIP, CITY, STATE FROM ZIPCODE";
                adapter = new iDB2DataAdapter(sql, conn);

                dataset = new DataSet();
                adapter.Fill(dataset);

                listBoxZipCodeTable.Items.Clear();
                listBoxZipCodeTable.Items.Add("-------------------------------------Zip Code, City, State--------------------------------------------");
                foreach (DataRow pRow in dataset.Tables[0].Rows)
                    listBoxZipCodeTable.Items.Add(pRow[0] + "         " + pRow[1] + "        " + pRow[2]);
                listBoxZipCodeTable.Items.Add("---------------------------------------------------------------------------------------------------------");
                //conn.Close(); moved this to the finally

            }
            catch (Exception ex)
            {
                listBoxZipCodeTable.Items.Add(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void buttonAddUpdate_Click(object sender, EventArgs e)
        {
            {
                string zipCode = textBoxZip.Text;
                string city = textBoxCity.Text;
                string state = textBoxState.Text;

                try
                {
                    conn = new iDB2Connection("DataSource=10.250.0.30");
                    conn.Open();

                    string selectCmdText = "SELECT COUNT(*) FROM ZIPCODE WHERE ZIP = @ZIP";
                    iDB2Command selectCmd = new iDB2Command(selectCmdText, conn);
                    selectCmd.Parameters.AddWithValue("@ZIP", zipCode);

                    int count = Convert.ToInt32(selectCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        string updateCmdText = "UPDATE ZIPCODE SET CITY = @CITY, STATE = @STATE WHERE ZIP = @ZIP";
                        iDB2Command updateCmd = new iDB2Command(updateCmdText, conn);
                        updateCmd.Parameters.AddWithValue("@ZIP", zipCode);
                        updateCmd.Parameters.AddWithValue("@CITY", city);
                        updateCmd.Parameters.AddWithValue("@STATE", state);
                        updateCmd.ExecuteNonQuery();

                        labelMessage.Text = "Zip code updated successfully.";
                       
                    }
                    else
                    {
                        string insertCmdText = "INSERT INTO ZIPCODE (ZIP, CITY, STATE) VALUES (@ZIP, @CITY, @STATE)";
                        iDB2Command insertCmd = new iDB2Command(insertCmdText, conn);
                        insertCmd.Parameters.AddWithValue("@ZIP", zipCode);
                        insertCmd.Parameters.AddWithValue("@CITY", city);
                        insertCmd.Parameters.AddWithValue("@STATE", state);
                        insertCmd.ExecuteNonQuery();

                        labelMessage.Text = "New zip code added successfully.";
                    }
                }
                catch (Exception ex)
                {
                    labelMessage.Text = "Error: " + ex.Message;
                }
                finally { conn.Close();}
            }
        }
    }
}
