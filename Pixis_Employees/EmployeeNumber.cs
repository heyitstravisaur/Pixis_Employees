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
        public EmployeeNumber()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int empNum = Convert.ToInt32(txbEmployeeNumber.Text);
            AddUpdate addUpdate = new AddUpdate();
            string title = "Add";
            addUpdate.title = title;
            addUpdate.empNum = empNum;
            addUpdate.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
