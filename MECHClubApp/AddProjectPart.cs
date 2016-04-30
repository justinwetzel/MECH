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
    public partial class AddProjectPart : Form
    {
        public AddProjectPart()
        {
            InitializeComponent();
        }

        private void AddProjectPart_Load(object sender, EventArgs e)
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
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select part_id from parts";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PartId");
                    partId.DisplayMember = "part_id";
                    partId.ValueMember = "PartId";
                    partId.DataSource = ds.Tables["PartId"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                    this.Dispose();
                }
            }

            for (int i = 0; i < 99; i++)
            {
                quantityNeeded.Items.Add(i.ToString());
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);
            bool valid = true;
            //Need to validate to prevent SQL injection
            string project_Id = projectId.Text;
            string part_Id = partId.Text;
            string quantity = quantityNeeded.Text;
            if (projectId.Text == "" || partId.Text == "" || quantityNeeded.Text == "")
            {
                valid = false;
            }
            if (valid == true)
            {


                try
                {
                    string sqlCommand = "INSERT INTO project_parts(proj_id,part_id,quantity_need) values(@project_Id,@part_Id,@quantity)";
                    SqlCommand execute = new SqlCommand(sqlCommand, connect);
                    execute.Parameters.AddWithValue("@project_Id", project_Id);
                    execute.Parameters.AddWithValue("@part_Id", part_Id);
                    execute.Parameters.AddWithValue("@quantity", quantity);
                    connect.Open();
                    execute.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured.");
                }
                finally
                {

                }

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Please select a number for each dropdown.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
