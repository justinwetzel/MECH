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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.Database1ConnectionString);
            string sqlCommand = "";

            if (eventNameFilter.Checked)
            {
                string eventSelect = nameCombo.Text;
                MessageBox.Show(eventSelect);
                sqlCommand = "SELECT * FROM events WHERE events.event_name LIKE '" + eventSelect + "'";
            }
            else if (locationFilter.Checked)
            {
                string locationSelect = locationCombo.Text;
                sqlCommand = "SELECT *  FROM events WHERE events.location LIKE '" + locationSelect + "'";
            }
            else if (startDateFilter.Checked)
            {
                string startDateSelect = startingDate.Text;
                sqlCommand = "SELECT * FROM events WHERE events.e_date LIKE '" + startingDate + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FilterProjects_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.Database1ConnectionString))
            {
                try
                {
                    string query = "select event_name from events";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "EventName");
                    nameCombo.DisplayMember = "event_name";
                    nameCombo.ValueMember = "EventName";
                    nameCombo.DataSource = ds.Tables["EventName"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured! Loading projects");
                    this.Dispose();
                }
            }
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.Database1ConnectionString))
            {
                try
                {
                    string query = "select location from events";
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
                    MessageBox.Show("Error occured! Loading contributors");
                    this.Dispose();
                }
            }
            //using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.Database1ConnectionString))
            //{
            //    try
            //    {
            //        string query = "select e_date from events where e_date ";
            //        SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //        conn.Open();
            //        DataSet ds = new DataSet();
            //        da.Fill(ds, "Version");
            //        startingDate.DisplayMember = "version";
            //        startingDate.ValueMember = "Version";
            //        startingDate.DataSource = ds.Tables["Version"];
            //    }
            //    catch (Exception ex)
            //    {
            //        // write exception info to log or anything else
            //        MessageBox.Show("Error occured! Loading versions.");
            //        this.Dispose();
            //    }
            //}
        }
    }
}
