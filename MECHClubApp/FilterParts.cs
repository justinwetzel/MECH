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
    public partial class FilterParts : Form
    {
        DataTable filterData = new DataTable();
        public FilterParts(DataTable filter)
        {
            InitializeComponent();
            filterData = filter;
        }
         
        private void label1_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);
            string sqlCommand = "";

            if (typeFilter.Checked)
            {
                string typeSelect = typeCombo.SelectedValue.ToString();
                sqlCommand = "SELECT * FROM parts WHERE parts.type LIKE '" + typeSelect + "'";
            }
            else if (vendorFilter.Checked)
            {
                string vendorSelect = vendorCombo.SelectedValue.ToString();
                sqlCommand = "SELECT *  FROM parts WHERE parts.vendor LIKE '" + vendorSelect + "'";
            }
            else if (expensiveFilter.Checked)
            {
                sqlCommand = "SELECT * FROM parts ORDER BY parts.price DESC";
            }
            else if (leastExpFilter.Checked)
            {
                sqlCommand = "SELECT * FROM parts ORDER BY parts.price ASC";
            }
            else if (highestQuantity.Checked)
            {
                sqlCommand = "SELECT * FROM parts ORDER BY parts.quantity DESC";
            }
            else if (lowestQuantity.Checked)
            {
                sqlCommand = "SELECT * FROM parts ORDER BY parts.quantity ASC";
            }
            else
            {
                MessageBox.Show("Error occured!");
            }

            SqlDataAdapter execute = new SqlDataAdapter(sqlCommand, connect);
            DataTable data = new DataTable();
            connect.Open();
            execute.Fill(filterData);
            this.Dispose();
            
        }
        
        public DataTable getFilteredData()
        {
            return filterData;
        }

        private void FilterParts_Load(object sender, EventArgs e)
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
            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select vendor from parts";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Vendor");
                    vendorCombo.DisplayMember = "vendor";
                    vendorCombo.ValueMember = "Vendor";
                    vendorCombo.DataSource = ds.Tables["Vendor"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                    this.Dispose();
                }
            }
        }
    }
}
