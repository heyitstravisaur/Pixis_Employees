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
    public partial class PyxisairFlightReservationSystem : Form
    {
        public PyxisairFlightReservationSystem()
        {
            InitializeComponent();
        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {
            Employee();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee();
        }

        private void Employee()
        {
            Employee employee = new Employee(this);
            employee.Show();
            this.Hide();
        }

        private void menuJobType_Click(object sender, EventArgs e)
        {
            JobType();
        }

        private void btnJobType_Click(object sender, EventArgs e)
        {
            JobType();
        }

        private void JobType()
        {
            JobType jobeType = new JobType(this);
            jobeType.Show();
            this.Hide();
        }

        private void menuStaffSchedule_Click(object sender, EventArgs e)
        {
            StaffSchedule();
        }

        private void btnStaffSchedule_Click(object sender, EventArgs e)
        {
            StaffSchedule();
        }

        private void StaffSchedule()
        {
            StaffSchedule staffSchedule = new StaffSchedule(this);
            staffSchedule.Show();
            this.Hide();
        }
        private void menuFlightStaff_Click(object sender, EventArgs e)
        {
            FlightStaff();
        }

        private void btnFlightStaff_Click(object sender, EventArgs e)
        {
            FlightStaff();
        }

        private void FlightStaff()
        {
            FlightStaff flightStaff = new FlightStaff(this);
            flightStaff.Show();
            this.Hide();
        }
        private void menuLocation_Click(object sender, EventArgs e)
        {
            Location();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            Location();
        }

        private void Location()
        {
            Location location = new Location(this);
            location.Show();
            this.Hide();
        }

        private void menuCustomer_Click(object sender, EventArgs e)
        {
            Customer();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer();
        }

        private void Customer()
        {
            Customer customer = new Customer(this);
            customer.Show();
            this.Hide();
        }

        private void menuAirplane_Click(object sender, EventArgs e)
        {
            Airplane();
        }

        private void btnAirplane_Click(object sender, EventArgs e)
        {
            Airplane();
        }

        private void Airplane()
        {
            Airplane airplane = new Airplane(this);
            airplane.Show();
            this.Hide();
        }

        private void menuAirport_Click(object sender, EventArgs e)
        {
            Airport();
        }

        private void btnAirport_Click(object sender, EventArgs e)
        {
            Airport();
        }

        private void Airport()
        {
            Airport airport = new Airport(this);
            airport.Show();
            this.Hide();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            this.Close();
        }
    }
}
