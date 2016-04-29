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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.Database1ConnectionString);
            string project_id = projectID.Text;
            //string project_id = projIdBox.Text;
            string event_date = eventDate.Text;
            string event_name = eventName.Text;
            string event_location = eventLocation.Text;
            string event_cost = eventCost.Text;
            try
            {
                string sqlCommand = "INSERT INTO events(proj_id, e_date, event_name, location, event_cost) values(@proj_id,@e_date,@event_name,@location,@event_cost)";
                SqlCommand execute = new SqlCommand(sqlCommand, connect);
                execute.Parameters.AddWithValue("@proj_id", project_id);
                //execute.Parameters.AddWithValue("@e_date", event_date);
                execute.Parameters.Add("@e_date", SqlDbType.Date).Value = eventDate.Value.Date;
                execute.Parameters.AddWithValue("@event_name", event_name);
                execute.Parameters.AddWithValue("@location", event_location);
                execute.Parameters.AddWithValue("@event_cost", event_cost);
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

        private void AddEvent_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                projectID.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
