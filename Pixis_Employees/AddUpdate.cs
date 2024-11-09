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
    public partial class AddUpdate : Form
    {
        public string title { get; set; }

        public AddUpdate()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //this is to add a

        }

        private void AddUpdate_Load(object sender, EventArgs e)
        {
            this.Text = title;
            if (title == "Add")
            {
                btnAdd.Show();
                btnUpdate.Hide();
            }
            else
            {
                btnAdd.Hide();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this will update the employee
        }
    }
}
