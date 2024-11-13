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
    public partial class Airport : Form
    {
        private PyxisairFlightReservationSystem pfrs;

        public Airport(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Close();
        }

        private void Airport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.AIRPORT' table. You can move, or remove it, as needed.
            this.aIRPORTTableAdapter.Fill(this.dataSet2.AIRPORT);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
