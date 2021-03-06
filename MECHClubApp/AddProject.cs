﻿using System;
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
            bool valid = true;
            int fake;
            if (Int32.TryParse(projectName.Text, out fake))
            {
                valid = false;
            }
            bool containsInt;
            if(containsInt = contributor.Text.Any(char.IsDigit))
            {
                valid = false;
            }
            string project_Name = projectName.Text;
            string project_Version = projectVersion.Text;
            string pContributor = contributor.Text;
            string pDescription = description.Text;
            string image_Url = imageUrl.Text;
            if (projectName.Text == "" || projectVersion.Text == "" || contributor.Text == "" || description.Text == "" || imageUrl.Text == "")
            {
                valid = false;
            }
            if (valid == true)
            {
                try
                {
                    string sqlCommand = "INSERT INTO projects(proj_name,version,contributors,image_url,description) values(@project_Name,@project_Version,@pContributor,@image_Url,@pDescription)";
                    SqlCommand execute = new SqlCommand(sqlCommand, connect);
                    execute.Parameters.AddWithValue("@project_Name", project_Name);
                    execute.Parameters.AddWithValue("@project_Version", project_Version);
                    execute.Parameters.AddWithValue("@pContributor", pContributor);
                    execute.Parameters.AddWithValue("@image_Url", image_Url);
                    execute.Parameters.AddWithValue("@pDescription", pDescription);
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
                MessageBox.Show("Please check the format of your input. Project Name must contain a character, and Contributor must not contain any digits. All fields are required.");
            }
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
