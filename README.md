private void btnUpdate_Click(object sender, EventArgs e)
{
    try
    {
        // Validate for empty fields in the DataGridView
        foreach (DataGridViewRow gridRow in dataGridView1.Rows)
        {
            if (gridRow.IsNewRow) continue;
            foreach (DataGridViewCell cell in gridRow.Cells)
            {
                if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    MessageBox.Show($"Row {gridRow.Index + 1} has empty fields. Please complete all fields before updating.");
                    return;
                }
            }
        }

        bindingSource.EndEdit(); // Commit any pending changes to the DataSet.

        using (iDB2Connection conn = new iDB2Connection(connectionString))
        {
            conn.Open();

            // INSERT query for new rows
            string insertQuery = @"INSERT INTO AIRPLANE 
                                   (PLANENO, MAXDIST, FCLASS, CCLASS, PAVAIL, 
                                    MAINTMILES, PLANEMODEL, PMAKE, APARCD, 
                                    APACTDT, APIACTDT, STATUS, DATEMAINT) 
                                   VALUES 
                                   (@PLANENO, @MAXDIST, @FCLASS, @CCLASS, @PAVAIL, 
                                    @MAINTMILES, @PLANEMODEL, @PMAKE, @APARCD, 
                                    @APACTDT, @APIACTDT, @STATUS, @DATEMAINT)";

            // UPDATE query for modified rows
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
                if (row.RowState == DataRowState.Added)
                {
                    using (iDB2Command cmd = new iDB2Command(insertQuery, conn))
                    {
                        cmd.Parameters.Add(new iDB2Parameter("@PLANENO", iDB2DbType.iDB2Char) { Value = row["PLANENO"].ToString() });
                        cmd.Parameters.Add(new iDB2Parameter("@MAXDIST", iDB2DbType
