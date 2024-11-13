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
    public partial class EmployeeNumber : Form
    {
        private Employee employee;

        public EmployeeNumber(Employee form)
        {
            InitializeComponent();
            employee = form;
            txtEmployeeNumber.Focus();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int empNum = Convert.ToInt32(txtEmployeeNumber.Text);

            // Pass the reference of Form2 when creating Form4 (AddUpdate)
            AddUpdate addUpdate = new AddUpdate(employee);
            string title = "Update Employee";
            addUpdate.title = title;
            addUpdate.empNum = empNum;
            addUpdate.Show();

            employee.Hide(); // Hide Form2 (Employee)
            this.Close();    // Close Form3 (EmployeeNumber)
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            employee.Show();
            this.Close();
        }

        private void EmployeeNumber_Load(object sender, EventArgs e)
        {
            
        }
    }
}
