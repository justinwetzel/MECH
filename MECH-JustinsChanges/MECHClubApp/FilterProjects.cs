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
    public partial class FilterProjects : Form
    {
        DataTable filterData = new DataTable();
        public FilterProjects(DataTable filter)
        {
            InitializeComponent();
            filterData = filter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);
            string sqlCommand = "";

            if (projectFilter.Checked)
            {
                string projectSelect = projectCombo.Text;
                MessageBox.Show(projectSelect);
                sqlCommand = "SELECT * FROM projects WHERE projects.proj_name LIKE '" + projectSelect + "'";
            }
            else if (contributorFilter.Checked)
            {
                string contributorSelect = contributorCombo.Text;
                sqlCommand = "SELECT *  FROM projects WHERE projects.contributors LIKE '" + contributorSelect + "'";
            }
            else if (versionFilter.Checked)
            {
                string versionSelect = versionCombo.Text;
                sqlCommand = "SELECT * FROM projects WHERE projects.version LIKE '" + versionSelect + "'";
            }
            else
            {
                MessageBox.Show("Error occured! Checking filters");
            }

            SqlDataAdapter execute = new SqlDataAdapter(sqlCommand, connect);
            DataTable data = new DataTable();
            connect.Open();
            execute.Fill(filterData);
            this.Dispose();
        }
        public DataTable getFilteredData()
        {
            return filterData;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FilterProjects_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select proj_name from projects";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ProjectName");
                    projectCombo.DisplayMember = "proj_name";
                    projectCombo.ValueMember = "ProjectName";
                    projectCombo.DataSource = ds.Tables["ProjectName"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured! Loading projects");
                    this.Dispose();
                }
            }
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select contributors from projects";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Contributors");
                    contributorCombo.DisplayMember = "contributors";
                    contributorCombo.ValueMember = "Contributors";
                    contributorCombo.DataSource = ds.Tables["Contributors"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured! Loading contributors");
                    this.Dispose();
                }
            }
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select version from projects";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Version");
                    versionCombo.DisplayMember = "version";
                    versionCombo.ValueMember = "Version";
                    versionCombo.DataSource = ds.Tables["Version"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured! Loading versions.");
                    this.Dispose();
                }
            }
        }
    }
}
