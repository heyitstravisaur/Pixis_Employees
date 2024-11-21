using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private BindingSource bindingSource = new BindingSource();

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
            LoadAirplaneData();
        }

        private void LoadAirplaneData()
        {
            try
            {
                this.dataSet2.AIRPLANE.Clear();
                this.aIRPLANETableAdapter.Fill(this.dataSet2.AIRPLANE);
                bindingSource.DataSource = this.dataSet2.AIRPLANE;
                dataGridView1.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data aint loading man: " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        if(cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        {
                            MessageBox.Show("I'm gonna need you to fill in all empty boxes, ok? " +
                                "{row.Index + 1} needs some data");
                            return;
                        }
                    }
                }
                bindingSource.EndEdit();

                this.aIRPLANETableAdapter.Update(this.dataSet2.AIRPLANE);

                MessageBox.Show("Great Success!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("That....didn't work: " + ex.Message );
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadAirplaneData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = this.dataSet2.AIRPLANE.NewRow();
                this.dataSet2.AIRPLANE.Rows.Add(newRow);
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Somethin done broke: " + ex.Message);
            }
        }
    }
}
