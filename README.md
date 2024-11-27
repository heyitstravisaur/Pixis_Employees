private void btnUpdate_Click(object sender, EventArgs e)
{
    try
    {
        bindingSource.EndEdit(); // Ensure any pending edits are committed to the DataSet.

        using (iDB2Connection conn = new iDB2Connection(connectionString))
        {
            conn.Open();

            // Handle new rows (DataRowState.Added)
            string insertQuery = @"INSERT INTO AIRPLANE 
                (PLANENO, MAXDIST, FCLASS, CCLASS, PAVAIL, MAINTMILES, PLANEMODEL, PMAKE, APARCD, APACTDT, STATUS, DATEMAINT)
                VALUES 
                (@PLANENO, @MAXDIST, @FCLASS, @CCLASS, @PAVAIL, @MAINTMILES, @PLANEMODEL, @PMAKE, @APARCD, @APACTDT, @STATUS, @DATEMAINT)";

            foreach (DataRow row in airplaneDataSet.Tables["AIRPLANE"].Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    using (iDB2Command cmd = new iDB2Command(insertQuery, conn))
                    {
                        cmd.Parameters.Add(new iDB2Parameter("@PLANENO", iDB2DbType.iDB2Char) { Value = row["PLANENO"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@MAXDIST", iDB2DbType.iDB2Integer) { Value = Convert.ToInt32(row["MAXDIST"]) });
                        cmd.Parameters.Add(new iDB2Parameter("@FCLASS", iDB2DbType.iDB2Integer) { Value = Convert.ToInt32(row["FCLASS"]) });
                        cmd.Parameters.Add(new iDB2Parameter("@CCLASS", iDB2DbType.iDB2Integer) { Value = Convert.ToInt32(row["CCLASS"]) });
                        cmd.Parameters.Add(new iDB2Parameter("@PAVAIL", iDB2DbType.iDB2Char) { Value = row["PAVAIL"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@MAINTMILES", iDB2DbType.iDB2Integer) { Value = Convert.ToInt32(row["MAINTMILES"]) });
                        cmd.Parameters.Add(new iDB2Parameter("@PLANEMODEL", iDB2DbType.iDB2Char) { Value = row["PLANEMODEL"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@PMAKE", iDB2DbType.iDB2Char) { Value = row["PMAKE"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@APARCD", iDB2DbType.iDB2Char) { Value = row["APARCD"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@APACTDT", iDB2DbType.iDB2Date) { Value = DateTime.Parse(row["APACTDT"].ToString()) });
                        cmd.Parameters.Add(new iDB2Parameter("@STATUS", iDB2DbType.iDB2Char) { Value = row["STATUS"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@DATEMAINT", iDB2DbType.iDB2Date) { Value = DateTime.Parse(row["DATEMAINT"].ToString()) });
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // Handle modified rows (DataRowState.Modified)
            string updateQuery = @"UPDATE AIRPLANE SET
                MAXDIST = @MAXDIST, FCLASS = @FCLASS, CCLASS = @CCLASS, PAVAIL = @PAVAIL,
                MAINTMILES = @MAINTMILES, PLANEMODEL = @PLANEMODEL, PMAKE = @PMAKE, 
                APARCD = @APARCD, APACTDT = @APACTDT, STATUS = @STATUS, DATEMAINT = @DATEMAINT
            WHERE PLANENO = @PLANENO";

            foreach (DataRow row in airplaneDataSet.Tables["AIRPLANE"].Rows)
            {
                if (row.RowState == DataRowState.Modified)
                {
                    using (iDB2Command cmd = new iDB2Command(updateQuery, conn))
                    {
                        cmd.Parameters.Add(new iDB2Parameter("@PLANENO", iDB2DbType.iDB2Char) { Value = row["PLANENO"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@MAXDIST", iDB2DbType.iDB2Integer) { Value = Convert.ToInt32(row["MAXDIST"]) });
                        cmd.Parameters.Add(new iDB2Parameter("@FCLASS", iDB2DbType.iDB2Integer) { Value = Convert.ToInt32(row["FCLASS"]) });
                        cmd.Parameters.Add(new iDB2Parameter("@CCLASS", iDB2DbType.iDB2Integer) { Value = Convert.ToInt32(row["CCLASS"]) });
                        cmd.Parameters.Add(new iDB2Parameter("@PAVAIL", iDB2DbType.iDB2Char) { Value = row["PAVAIL"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@MAINTMILES", iDB2DbType.iDB2Integer) { Value = Convert.ToInt32(row["MAINTMILES"]) });
                        cmd.Parameters.Add(new iDB2Parameter("@PLANEMODEL", iDB2DbType.iDB2Char) { Value = row["PLANEMODEL"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@PMAKE", iDB2DbType.iDB2Char) { Value = row["PMAKE"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@APARCD", iDB2DbType.iDB2Char) { Value = row["APARCD"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@APACTDT", iDB2DbType.iDB2Date) { Value = DateTime.Parse(row["APACTDT"].ToString()) });
                        cmd.Parameters.Add(new iDB2Parameter("@STATUS", iDB2DbType.iDB2Char) { Value = row["STATUS"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@DATEMAINT", iDB2DbType.iDB2Date) { Value = DateTime.Parse(row["DATEMAINT"].ToString()) });
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Data updated successfully.");
        }

        // Accept changes to reset the row states in the DataSet.
        airplaneDataSet.Tables["AIRPLANE"].AcceptChanges();

        // Reload the data to reflect changes in the DataGridView.
        LoadAirplaneData();
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
