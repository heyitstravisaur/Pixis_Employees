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
        private Employee employee;

        public string title { get; set; }
        public int empNum { get; set; }

        iDB2Connection conn;
        iDB2DataAdapter iDBAdapter;
        DataSet ds;

        public AddUpdate()
        {
            InitializeComponent();

            groups.Add(groupBox1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //this is to add a
        }

        private void AddUpdate_Load(object sender, EventArgs e)
        {
            string sql;
            string connName = "Data Source=deathstar.gtc.edu;User ID=itpa638;Initial Catalog=S101FF5C";

            this.Text = title;
            if (title == "Add")
            {
                btnAdd.Show();
                btnUpdate.Hide();
            }
            else
            {
                int eN = empNum;

                try
                {
                    conn = new iDB2Connection(connName);
                    conn.Open();

                    sql = "SELECT * FROM EMPLOYEE WHERE EMPNO = " + eN;

                    iDBAdapter = new iDB2DataAdapter(sql, conn);

                    ds = new DataSet();
                    iDBAdapter.Fill(ds);

                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];

                        foreach (GroupBox group in groups)
                        {

                            // Loop through each control inside the GroupBox
                            foreach (Control control in group.Controls)
                            {
                                if (control is TextBox textBox)
                                {
                                    // Use the TextBox Name property to identify which data to assign
                                    switch (textBox.Name)
                                    {
                                        case "txtEmpNum":
                                            textBox.Text = row["EMPNO"].ToString();
                                            break;
                                        case "txtEmpFName":
                                            textBox.Text = row["EFNAME"].ToString();
                                            break;
                                        case "txtEmpLName":
                                            textBox.Text = row["ELNAME"].ToString();
                                            break;
                                        case "txtEmpAddress":
                                            textBox.Text = row["EADDR"].ToString();
                                            break;
                                        case "txtEmpCity":
                                            textBox.Text = row["ECITY"].ToString();
                                            break;
                                        case "txtEmpState":
                                            textBox.Text = row["ESTATE"].ToString();
                                            break;
                                        case "txtEmpZip":
                                            textBox.Text = row["EZIP"].ToString();
                                            break;
                                        case "txtEmpPhoneNumber":
                                            textBox.Text = row["EPHONE"].ToString();
                                            break;
                                        case "txtEmpEmail":
                                            textBox.Text = row["EMAIL"].ToString();
                                            break;
                                        case "txtEmpDOB":
                                            textBox.Text = row["DOB"].ToString();
                                            break;
                                        case "txtEmpGender":
                                            textBox.Text = row["GENDER"].ToString();
                                            break;
                                        case "txtJobId":
                                            textBox.Text = row["JOBID"].ToString();
                                            break;
                                        case "txtWorkStatus":
                                            textBox.Text = row["WRKSTATUS"].ToString();
                                            break;
                                        case "txtHourlyRate":
                                            textBox.Text = row["HRLYRATE"].ToString();
                                            break;
                                        case "txtEmpHireDate":
                                            textBox.Text = row["EMHIREDT"].ToString();
                                            break;
                                        case "txtEmpStartDate":
                                            textBox.Text = row["EMSTARTDT"].ToString();
                                            break;
                                        case "txtEmpTermDate":
                                            textBox.Text = row["EMTERMDT"].ToString();
                                            break;
                                        case "txtRegionId":
                                            textBox.Text = row["REGIONID"].ToString();
                                            break;
                                            // Add more cases as needed for additional TextBoxes
                                    }

                                }
                            }
                        }
                    }

                }
                catch (Exception ex) { listBox1.Items.Add(ex); }

                //this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);

                btnUpdate.Show();
                btnAdd.Hide();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this will update the employee
            UpdateEmp.update(groups);
        }
    }
}
