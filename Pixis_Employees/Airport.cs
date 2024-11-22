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
    public partial class Airport : Form
    {
        private string connectionString = "DataSource=deathstar.gtc.edu";
        private PyxisairFlightReservationSystem pfrs;
        private BindingSource bindingSource = new BindingSource();
        private DataSet airportDataSet = new DataSet();

        public Airport(PyxisairFlightReservationSystem form)
        {
            InitializeComponent();
            pfrs = form;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pfrs.Show();
            this.Close();
        }

        private void Airport_Load(object sender, EventArgs e)
        {
            LoadAirportData();
            this.aIRPORTTableAdapter.Fill(this.dataSet2.AIRPORT);

        }

        private void LoadAirportData()
        {
            try
            {
                using(iDB2Connection conn = new iDB2Connection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM AIRPORT";
                    iDB2DataAdapter adapter = new iDB2DataAdapter(sql, conn);
                    airportDataSet.Clear();
                    adapter.Fill(airportDataSet, "AIRPORT");

                    bindingSource.DataSource = airportDataSet.Tables["AIRPORT"];
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
                        //if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        //{
                        //    MessageBox.Show($"Row {row.Index + 1} has empty fields. Please complete all fields before updating.");
                        //    return;
                        //}
                    }
                }

                bindingSource.EndEdit();

                using(iDB2Connection conn = new iDB2Connection(connectionString))
                {

                    string updateQuery = @"UPDATE AIRPORT SET
                            ARNM = @ARNM, ARCITYNM = @ARCITYNM, ARCNCD = @ARCNCD,
                            ARFAACD = @ARFAACD, ARICAOCD = @ARICAOCD, ARTIMEZNM = @ARTIMEZNM,
                            ARLATITUDE = @ARLATITUDE, ARLNGITUDE = @ARLNGITUDE,
                            ARTIMEZOF = @ARTIMEZOF, ARALTITUDE = @ARALTITUDE
                            WHERE ARCD = @ARCD";

                    foreach(DataRow row in airportDataSet.Tables["AIRPORT"].Rows)
                    {
                        if(row.RowState == DataRowState.Modified)
                        {
                            iDB2Command cmd = new iDB2Command(updateQuery, conn);
                            cmd.Parameters.Add(new iDB2Parameter("@ARCD", iDB2DbType.iDB2Char) { Value = row["ARCD"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@ARNM", iDB2DbType.iDB2Char) { Value = row["ARNM"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@ARCITYNM", iDB2DbType.iDB2Char) { Value = row["ARCITYNM"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@ARCNCD", iDB2DbType.iDB2Char) { Value = row["ARCNCD"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@ARFAACD", iDB2DbType.iDB2Char) { Value = row["ARFAACD"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@ARICAOCD", iDB2DbType.iDB2Char) { Value = row["ARICAOCD"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@ARTIMEZNM", iDB2DbType.iDB2Char) { Value = row["ARTIMEZNM"].ToString() });
                            cmd.Parameters.Add(new iDB2Parameter("@ARLATITUDE", iDB2DbType.iDB2Decimal) { Value = Convert.ToDecimal(row["ARLATITUDE"]) });
                            cmd.Parameters.Add(new iDB2Parameter("@ARLNGITUDE", iDB2DbType.iDB2Decimal) { Value = Convert.ToDecimal(row["ARLNGITUDE"]) });
                            cmd.Parameters.Add(new iDB2Parameter("@ARTIMEZOF", iDB2DbType.iDB2Decimal) { Value = Convert.ToDecimal(row["ARTIMEZOF"]) });
                            cmd.Parameters.Add(new iDB2Parameter("@ARALTITUDE", iDB2DbType.iDB2Binary) { Value = Convert.ToInt32(row["ARALTITUDE"]) });
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (FormatException fex)
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
            LoadAirportData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = airportDataSet.Tables["AIRPORT"].NewRow();
                airportDataSet.Tables["AIRPORT"].Rows.Add(newRow);
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding new row: " + ex.Message);
            }
        }
    }
}
