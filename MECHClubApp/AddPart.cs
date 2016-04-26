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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);

            //Need to validate to prevent SQL injection
            string quantity = partQuantity.Text;
            string type = partType.Text;
            string name = partName.Text;
            string partPrice = price.Text;
            string partVendor = vendor.Text;
            string vendor_Url = vendorUrl.Text; 
            try
            {
                string sqlCommand = "INSERT INTO parts(part_name,price,quantity,type,vendor, vendor_url) values('"+ name + "','" + partPrice + "','" + quantity + "','" + type + "','" + partVendor + "','" + vendor_Url + "')";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 99; i++)
            {
                partQuantity.Items.Add(i.ToString());
            }

            partType.Items.Add("Power");
            partType.Items.Add("Switch");
            partType.Items.Add("Sensor");
            partType.Items.Add("Microcontroller");
            partType.Items.Add("Connector");
            partType.Items.Add("Screws");
            partType.Items.Add("IC");
            partType.Items.Add("Tools");
            partType.Items.Add("Other");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
