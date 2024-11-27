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
        }

        private void LoadAirportData()
        {
            try
            {
                using (iDB2Connection conn = new iDB2Connection(connectionString))
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
                bindingSource.EndEdit(); // Ensure any pending edits are committed to the DataSet.

                using (iDB2Connection conn = new iDB2Connection(connectionString))
                {
                    conn.Open();

                    // Handle new rows (DataRowState.Added)
                    string insertQuery = @"INSERT INTO AIRPORT 
                (ARCD, ARNM, ARCITYNM, ARCNCD, ARFAACD, ARICAOCD, ARLATITUDE, ARLNGITUDE, ARALTITUDE, ARTIMEZNM, ARTIMEZOF)
                VALUES 
                (@ARCD, @ARNM, @ARCITYNM, @ARCNCD, @ARFAACD, @ARICAOCD, @ARLATITUDE, @ARLNGITUDE, @ARALTITUDE, @ARTIMEZNM, @ARTIMEZOF)";

                    foreach (DataRow row in airportDataSet.Tables["AIRPORT"].Rows)
                    {
                        if (row.RowState == DataRowState.Added)
                        {
                            using (iDB2Command cmd = new iDB2Command(insertQuery, conn))
                            {
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
                                cmd.Parameters.Add(new iDB2Parameter("@ARALTITUDE", iDB2DbType.iDB2Integer) { Value = (int)row["ARALTITUDE"] });
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Handle modified rows (DataRowState.Modified)
                    string updateQuery = @"UPDATE AIRPORT SET
                ARNM = @ARNM, 
                ARCITYNM = @ARCITYNM, 
                ARCNCD = @ARCNCD,
                ARFAACD = @ARFAACD, 
                ARICAOCD = @ARICAOCD, 
                ARLATITUDE = @ARLATITUDE,
                ARLNGITUDE = @ARLNGITUDE, 
                ARALTITUDE = @ARALTITUDE, 
                ARTIMEZNM = @ARTIMEZNM, 
                ARTIMEZOF = @ARTIMEZOF                     
            WHERE ARCD = @ARCD";

                    foreach (DataRow row in airportDataSet.Tables["AIRPORT"].Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            using (iDB2Command cmd = new iDB2Command(updateQuery, conn))
                            {
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
                                cmd.Parameters.Add(new iDB2Parameter("@ARALTITUDE", iDB2DbType.iDB2Integer) { Value = (int)row["ARALTITUDE"] });
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }

                // Accept changes to reset the row states in the DataSet.
                airportDataSet.Tables["AIRPORT"].AcceptChanges();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Data format error: " + fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating records: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Add a new empty row
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
