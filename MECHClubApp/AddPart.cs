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
            bool valid = true;
            int fake;
            if (Int32.TryParse(partName.Text, out fake))
            {
                valid = false;
            }
            bool containsInt = false;
            if (containsInt = price.Text.Any(Char.IsLetter))
            {
                valid = false;
            }
            string quantity = partQuantity.Text;
            string type = partType.Text;
            string name = partName.Text;
            string partPrice = price.Text;
            string partVendor = vendor.Text;
            string vendor_Url = vendorUrl.Text;
            if (valid == true)
            {
                try
                {
                    string sqlCommand = "INSERT INTO parts(part_name,price,quantity,type,vendor, vendor_url) values(@name,@partPrice,@quantity,@type,@partVendor,@vendor_url)";
                    SqlCommand execute = new SqlCommand(sqlCommand, connect);
                    execute.Parameters.AddWithValue("@name", name);
                    execute.Parameters.AddWithValue("@partPrice", partPrice);
                    execute.Parameters.AddWithValue("@quantity", quantity);
                    execute.Parameters.AddWithValue("@type", type);
                    execute.Parameters.AddWithValue("@partVendor", partVendor);
                    execute.Parameters.AddWithValue("@vendor_url", vendor_Url);
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
                MessageBox.Show("Please check the format of your input. Part Name must contain a character, and price as an integer without any characters.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 99; i++)
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
