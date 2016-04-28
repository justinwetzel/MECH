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
                    string query = "select type from parts";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Type");
                    projectId.DisplayMember = "type";
                    projectId.ValueMember = "Type";
                    projectId.DataSource = ds.Tables["Type"];
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
                    string query = "select type from parts";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Type");
                    typeCombo.DisplayMember = "type";
                    typeCombo.ValueMember = "Type";
                    typeCombo.DataSource = ds.Tables["Type"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                    this.Dispose();
                }
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);

            //Need to validate to prevent SQL injection
            string project_Id = projectId.Text;
            string part_Id = partId.Text;
            string quantity = quantityNeeded.Text;
            try
            {
                string sqlCommand = "INSERT INTO project_parts(proj_id,part_id,quantity_need) values('" + project_Id + "','" + part_Id + "','" + quantity + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
