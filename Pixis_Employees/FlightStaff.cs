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
    
    public partial class FlightStaff : Form
    {
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

        private void btnCheckStaff_Click(object sender, EventArgs e)
        {
            //string flightNum;
            //flightNum = txtboxFlightNum.Text;
            //txtboxFlightNum
            //btnCheckStaff

            //this.cREWTableAdapter1.Fill(this.dataSet2.CREW);

            //if(flightNum == FLIGHTNO)
            //string connectionString = "DataSource=deathstar.gtc.edu";
            //string sql = "SELECT * FROM CREW";

            //try
            //{
            //    dataAdapter = new iDB2DataAdapter(sql, connectionString);
            //    iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(dataAdapter);
            //    table = new DataTable();

            //    dataAdapter.Fill(table);
            //    bindingSource.DataSource = table;
            //}
            //catch (Exception ex) { }
        }
    }
}
