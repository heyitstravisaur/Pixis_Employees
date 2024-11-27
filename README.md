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
