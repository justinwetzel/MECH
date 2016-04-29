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
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select proj_id from projects";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ProjectId");
                    projectId.DisplayMember = "proj_id";
                    projectId.ValueMember = "ProjectId";
                    projectId.DataSource = ds.Tables["ProjectId"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                    this.Dispose();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);
            bool valid = true;
            string project_id = projectId.Text;
            string event_date = eventDate.Text;
            string event_name = eventName.Text;
            string event_location = eventLocation.Text;
            if(projectId.Text == "" || eventName.Text == "" || eventLocation.Text == "")
            {
                valid = false;
            }
            if (valid == true)
            {


                try
                {
                    string sqlCommand = "INSERT INTO events(proj_id, e_date, event_name, location) values(@proj_id,@e_date,@event_name,@location)";
                    SqlCommand execute = new SqlCommand(sqlCommand, connect);
                    execute.Parameters.AddWithValue("@proj_id", project_id);
                    execute.Parameters.Add("@e_date", SqlDbType.Date).Value = eventDate.Value.Date;
                    execute.Parameters.AddWithValue("@event_name", event_name);
                    execute.Parameters.AddWithValue("@location", event_location);
                    connect.Open();
                    execute.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Please check the format of your input. Part Name must contain a character, and price as an integer without any characters. All fields required");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
