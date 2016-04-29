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
    public partial class DeletePart : Form
    {
        public DeletePart()
        {
            InitializeComponent();
        }

        private void DeletePart_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select part_id from parts";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PartId");
                    idCombo.DisplayMember = "part_id";
                    idCombo.ValueMember = "PartId";
                    idCombo.DataSource = ds.Tables["PartId"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                    this.Dispose();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);
            try
            {
                string sqlCommand = "DELETE FROM parts WHERE parts.part_id=" + idCombo.Text;
                SqlCommand execute = new SqlCommand(sqlCommand, connect);
                connect.Open();
                execute.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete part, make sure a Project or Project part doesn't depend on it before deleting.");
            }
            finally
            {

            }

            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
