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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);
            string project_Name = projectName.Text;
            string project_Version = projectVersion.Text;
            string pContributor = contributor.Text;
            string pDescription = description.Text;
            string image_Url = imageUrl.Text;
            try
            {
                string sqlCommand = "INSERT INTO projects(proj_name,version,contributors,image_url,description) values('" + project_Name + "','" + project_Version + "','" + pContributor + "','" + image_Url + "','" + pDescription + "')";
                SqlCommand execute = new SqlCommand(sqlCommand, connect);
                connect.Open();
                execute.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            this.Dispose();
        }

        private void partQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 99; i++)
            {
                projectVersion.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
