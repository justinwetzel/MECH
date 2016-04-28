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

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            //SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);

            ////Need to validate to prevent SQL injection
            //string proj_id = partQuantity.Text;
            //string type = partType.Text;
            //string name = partName.Text;
            //string partPrice = price.Text;
            //string partVendor = vendor.Text;
            //string vendor_Url = vendorUrl.Text;
            //try
            //{
            //    string sqlCommand = "INSERT INTO parts(part_name,price,quantity,type,vendor, vendor_url) values('" + name + "','" + partPrice + "','" + quantity + "','" + type + "','" + partVendor + "','" + vendor_Url + "')";
            //    SqlCommand execute = new SqlCommand(sqlCommand, connect);
            //    connect.Open();
            //    execute.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{

            //}
            //finally
            //{

            //}

            //this.Dispose();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
