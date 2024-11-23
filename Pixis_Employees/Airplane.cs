using IBM.Data.DB2.iSeries;
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

        private string connectionString = "DataSource=deathstar.gtc.edu";
        private PyxisairFlightReservationSystem pfrs;
        private BindingSource bindingSource = new BindingSource();
        private DataSet airplaneDataSet = new DataSet();

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
                using (iDB2Connection conn = new iDB2Connection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM AIRPLANE";
                    iDB2DataAdapter adapter = new iDB2DataAdapter(sql, conn);
                    airplaneDataSet.Clear();
                    adapter.Fill(airplaneDataSet, "AIRPLANE");

                    bindingSource.DataSource = airplaneDataSet.Tables["AIRPLANE"];
                    dataGridView1.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data failed to load: " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        {
                            MessageBox.Show($"Row {row.Index + 1} has empty fields. Please complete all fields before updating.");
                            return;
                        }
                    }
                }

                bindingSource.EndEdit();

                using (iDB2Connection conn = new iDB2Connection(connectionString))
                {
                    conn.Open();
                    string updateQuery = @"UPDATE AIRPLANE SET 
                                           MAXDIST = @MAXDIST, FCLASS = @FCLASS, 
                                           CCLASS = @CCLASS, PAVAIL = @PAVAIL, 
                                           MAINTMILES = @MAINTMILES, PLANEMODEL = @PLANEMODEL, 
                                           PMAKE = @PMAKE, APARCD = @APARCD, APIACTDT = @APIACTDT, 
                                           APACTDT = @APACTDT, STATUS = @STATUS, 
                                           DATEMAINT = @DATEMAINT 
                                           WHERE PLANENO = @PLANENO";

                    foreach (DataRow row in airplaneDataSet.Tables["AIRPLANE"].Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            iDB2Command cmd = new iDB2Command(updateQuery, conn);
                            cmd.Parameters.Add(new iDB2Parameter("@PLANENO", iDB2DbType.iDB2Char) { Value = row["PLANENO"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@MAXDIST", iDB2DbType.iDB2Integer) { Value = (int)row["MAXDIST"] });
                            cmd.Parameters.Add(new iDB2Parameter("@FCLASS", iDB2DbType.iDB2Integer) { Value = (int)row["FCLASS"] });
                            cmd.Parameters.Add(new iDB2Parameter("@CCLASS", iDB2DbType.iDB2Integer) { Value = (int)row["CCLASS"] });
                            cmd.Parameters.Add(new iDB2Parameter("@PAVAIL", iDB2DbType.iDB2Char) { Value = row["PAVAIL"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@MAINTMILES", iDB2DbType.iDB2Integer) { Value = (int)row["MAINTMILES"] });
                            cmd.Parameters.Add(new iDB2Parameter("@PLANEMODEL", iDB2DbType.iDB2Char) { Value = row["PLANEMODEL"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@PMAKE", iDB2DbType.iDB2Char) { Value = row["PMAKE"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@APARCD", iDB2DbType.iDB2Char) { Value = row["APARCD"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@APACTDT", iDB2DbType.iDB2Date) { Value = DateTime.Parse(row["APACTDT"].ToString()) });
                            cmd.Parameters.Add(new iDB2Parameter("@APIACTDT", iDB2DbType.iDB2Date) { Value = DateTime.Parse(row["APIACTDT"].ToString()) });
                            cmd.Parameters.Add(new iDB2Parameter("@STATUS", iDB2DbType.iDB2Char) { Value = row["STATUS"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@DATEMAINT", iDB2DbType.iDB2Date) { Value = DateTime.Parse(row["DATEMAINT"].ToString()) });
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Records updated successfully.");
            }
            catch(FormatException fex)
            {
                MessageBox.Show("data format error: " + fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating records: " + ex.Message);
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
                DataRow newRow = airplaneDataSet.Tables["AIRPLANE"].NewRow();
                airplaneDataSet.Tables["AIRPLANE"].Rows.Add(newRow);
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding new row: " + ex.Message);
            }
        }
    }
}
