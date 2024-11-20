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
                conn.Close();

            }
            catch (Exception ex)
            {
                listBoxZipCodeTable.Items.Add(ex.Message);
            }
        }
    }
}
