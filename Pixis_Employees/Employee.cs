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
    public partial class Employee : Form
    {
        private PyxisairFlightReservationSystem pfrs;

        public Employee(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Close();
        }
    }
}
