using IBM.Data.DB2.iSeries;
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
        List<GroupBox> groups = new List<GroupBox>();

        private PyxisairFlightReservationSystem pfrs;
        private BindingSource bindingSource = new BindingSource();
        private iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
        DataTable table = new DataTable();

        public string title { get; set; }
        public int empNum { get; set; }

        public AddUpdate()
        {
            InitializeComponent();

            groups.Add(groupBox1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //this is to add a
            UpdateEmp.update(groups);
        }

        private void AddUpdate_Load(object sender, EventArgs e)
        {
            this.Text = title;
            if (title == "Add")
            {
                btnAdd.Show();
                btnUpdate.Hide();

                string connectionString = "DataSource=deathstar.gtc.edu";
                string sql = "SELECT * FROM EMPLOYEE WHERE EMPNO = @empNum";

                try
                {
                    iDB2Connection connection = new iDB2Connection(connectionString);
                    connection.Open();

                    dataAdapter = new iDB2DataAdapter(sql, connection);
                    table = new DataTable();

                    dataAdapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];

                        txtEmpNum.Text = row["EMPNO"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add(ex.ToString());
                }
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
