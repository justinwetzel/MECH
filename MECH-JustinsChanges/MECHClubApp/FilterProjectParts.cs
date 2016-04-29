using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MECHClubApp
{
    public partial class FilterProjectParts : Form
    {
        DataTable filterData = new DataTable();
        public FilterProjectParts(DataTable filter)
        {
            InitializeComponent();
            filterData = filter;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);
            string sqlCommand = "";
            

            if (projectFilter.Checked)
            {
                string projectSelect = projectCombo.Text;
                sqlCommand = "SELECT * FROM project_parts WHERE project_parts.proj_id = '" + projectSelect + "'";
            }
            else if (partFilter.Checked)
            {
                string partSelect = partCombo.Text;
                sqlCommand = "SELECT *  FROM project_parts WHERE project_parts.part_id = '" + partSelect + "'";
            }
            else if (mostFilter.Checked)
            {
                sqlCommand = "SELECT * FROM project_parts ORDER BY project_parts.quantity_need DESC";
            }
            else if (leastFilter.Checked)
            {
                sqlCommand = "SELECT * FROM project_parts ORDER BY project_parts.quantity_need ASC";
            }
            else
            {
                MessageBox.Show("Error occured!");
            }

            SqlDataAdapter execute = new SqlDataAdapter(sqlCommand, connect);
            DataTable data = new DataTable();
            connect.Open();
            execute.Fill(filterData);
            this.Dispose();
        }

        private void FilterProjectParts_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select distinct proj_id from project_parts";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ProjId");
                    projectCombo.DisplayMember = "proj_id";
                    projectCombo.ValueMember = "ProjId";
                    projectCombo.DataSource = ds.Tables["ProjId"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                    this.Dispose();
                }
            }
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select distinct part_id from project_parts";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PartId");
                    partCombo.DisplayMember = "part_id";
                    partCombo.ValueMember = "PartId";
                    partCombo.DataSource = ds.Tables["PartId"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                    this.Dispose();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public DataTable getFilteredData()
        {
            return filterData;
        }
    }
}
