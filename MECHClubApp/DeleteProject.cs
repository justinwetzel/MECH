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
    public partial class DeleteProject : Form
    {
        public DeleteProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);
            try
            {
                string sqlCommand = "DELETE FROM projects WHERE projects.proj_id=" + projectId.Text;
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
