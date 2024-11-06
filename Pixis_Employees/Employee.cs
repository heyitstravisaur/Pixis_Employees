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

        private void button1_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)https://github.com/heyitstravisaur/Pixis_Employees
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdate addUpdate = new AddUpdate();
            addUpdate.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddUpdate addUpdate = new AddUpdate();
            addUpdate.ShowDialog();
            //going to send a name for the title
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
