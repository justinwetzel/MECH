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
    public partial class FilterEvents : Form
    {
        DataTable filterData = new DataTable();
        public FilterEvents(DataTable filter)
        {
            InitializeComponent();
            filterData = filter;
        }
        public DataTable getFilteredData()
        {
            return filterData;
        }

        private void FilterEvents_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select distinct cast(event_name as varchar(max)) as event from events";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Event");
                    eventName.DisplayMember = "event";
                    eventName.ValueMember = "Event";
                    eventName.DataSource = ds.Tables["Event"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show(ex.Message);
                    this.Dispose();
                }
            }
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select distinct proj_id from projects";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ProjectId");
                    idCombo.DisplayMember = "proj_id";
                    idCombo.ValueMember = "ProjectId";
                    idCombo.DataSource = ds.Tables["ProjectId"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show(ex.Message);
                    this.Dispose();
                }
            }
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select distinct cast(location as varchar(max)) as location from events";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Location");
                    locationCombo.DisplayMember = "location";
                    locationCombo.ValueMember = "Location";
                    locationCombo.DataSource = ds.Tables["Location"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show(ex.Message);
                    this.Dispose();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);
                string sqlCommand = "";

                if (nameFilter.Checked)
                {
                    string event_Name = eventName.Text;
                    sqlCommand = "SELECT * FROM events WHERE events.event_name LIKE '" + event_Name + "'";
                }
                else if (dateFilter.Checked)
                {
                    sqlCommand = "SELECT *  FROM events WHERE events.e_date <  '" + eventDate.Value.Date + "'";
                }
                else if (projectFilter.Checked)
                {
                    sqlCommand = "SELECT * FROM events WHERE events.proj_id =" + idCombo.Text;
                }
                else if (locationFilter.Checked)
                {
                    sqlCommand = "SELECT * FROM events WHERE events.location LIKE '" + locationCombo.Text + "'";
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
            catch (Exception ex)
            {
                MessageBox.Show("Please be sure to select a filter.");
            }
            finally
            {

            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void eventName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
