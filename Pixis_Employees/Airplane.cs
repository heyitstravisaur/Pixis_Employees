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
    public partial class Airplane : Form
    {
        string connectionString = "Data Source=deathstar.gtc.edu;User ID=itpa641;Initial Catalog=S101FF5C";
        private PyxisairFlightReservationSystem pfrs;

        public Airplane(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Close();
        }

        private void Airplane_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.AIRPLANE' table. You can move, or remove it, as needed.
            this.aIRPLANETableAdapter.Fill(this.dataSet2.AIRPLANE);

        }
    }
}
