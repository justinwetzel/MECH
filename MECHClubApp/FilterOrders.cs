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
    public partial class FilterOrders : Form
    {
        DataTable filterData = new DataTable();
        public FilterOrders(DataTable filter)
        {
            InitializeComponent();
            filterData = filter;
        }

        private void FilterOrders_Load(object sender, EventArgs e)
        {
            orderStatus.Items.Add("Delivered");
            orderStatus.Items.Add("Ordered");
            orderStatus.Items.Add("Back-Order");
        }

        public DataTable getFilteredData()
        {
            return filterData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);
                string sqlCommand = "";

                if (statusFilter.Checked)
                {
                    string status = orderStatus.Text;
                    sqlCommand = "SELECT * FROM orders WHERE orders.status LIKE '" + status + "'";
                }
                else if (dateFilter.Checked)
                {
                    sqlCommand = "SELECT *  FROM orders WHERE orders.o_date <  '" + orderDate.Value.Date + "'";
                }
                else if (expensiveFilter.Checked)
                {
                    sqlCommand = "SELECT orders.order_number, SUM(orders.costs) as costs FROM orders GROUP BY orders.order_number ORDER BY costs DESC";
                }
                else if (leastExpFilter.Checked)
                {
                    sqlCommand = "SELECT orders.order_number, SUM(orders.costs) as costs FROM orders GROUP BY orders.order_number ORDER BY costs ASC";
                }
                else if (highestQuantity.Checked)
                {
                    sqlCommand = "SELECT * FROM orders ORDER BY orders.quantity DESC";
                }
                else if (lowestQuantity.Checked)
                {
                    sqlCommand = "SELECT * FROM orders ORDER BY orders.quantity ASC";
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
            catch(Exception ex)
            {
                MessageBox.Show("Please be sure to select a filter.");
            }
            finally
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
    }
}
