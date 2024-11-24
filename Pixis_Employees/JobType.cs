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
//For this form I used the CRUD lab as a resource. I wanted to originally use a datagridview, but was having to
//many issues with adding a dataset and having code merging problems.
namespace Pixis_Employees
{
    public partial class JobType : Form
    {
        iDB2Connection conn;//declare connection variable
        iDB2DataAdapter adapter;//declare adapter variable
        DataSet dataset;//declare dataset variable
        private PyxisairFlightReservationSystem pfrs;

        public JobType(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        private void btnExit_Click(object sender, EventArgs e)//code from alex
        {
            pfrs.Show();
            this.Close();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            string sql;//declare string variable
            try
            {
                conn = new iDB2Connection("DataSource=10.250.0.30");//connect to deathstar with ip address
                sql = "SELECT JTNM, JTDESC FROM JOBTYPE";//sql statement for the job name and job descriptions from the jobtype table
                adapter = new iDB2DataAdapter(sql, conn);//adapter for the dataset and the db
                dataset = new DataSet();//the dataset is where the data from the adapter is going to go
                adapter.Fill(dataset);//use the Fill.(ds) to then fill the ds with the data from the adapter which comes from the (sql, conn) parameters
                listBox1.Items.Clear();//clear the table of old data before repopulating it with new data.
                listBox1.Items.Add("--------------------------Job Name and Descriptions-----------------------------------");//listbox heading
                foreach (DataRow pRow in dataset.Tables[0].Rows)
                    listBox1.Items.Add(pRow[0] + " " + pRow[1]);
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------");//listbox footer
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
            finally { conn.Close(); }//close the connection
        }
    }
}
