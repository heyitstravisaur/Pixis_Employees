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
    public partial class JobType : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;
        private PyxisairFlightReservationSystem pfrs;

        public JobType(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Close();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                conn = new iDB2Connection("DataSource=10.250.0.30");
                sql = "SELECT JTNM, JTDESC FROM JOBTYPE";
                adapter = new iDB2DataAdapter(sql, conn);

                dataset = new DataSet();
                adapter.Fill(dataset);

                listBox1.Items.Clear();
                listBox1.Items.Add("--------------------------Job Name and Descriptions-----------------------------------");
                foreach (DataRow pRow in dataset.Tables[0].Rows)
                    listBox1.Items.Add(pRow[0] + " " + pRow[1]);
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------");
                conn.Close();

            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }
    }
}
