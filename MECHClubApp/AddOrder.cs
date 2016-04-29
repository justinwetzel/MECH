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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int order;
            SqlConnection connect = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString);
            if (Int32.TryParse(orderNumber.Text, out order))
            {
                bool valid = true;
                string orderNumber = order.ToString();
                string part_Id = partId.Text;
                string status = orderStatus.Text;
                string orderQuantity = quantity.Text;
                if (orderNumber == "")
                {
                    valid = false;
                }

                if (valid == true)
                {


                    try
                    {
                        string query = "select price from parts where parts.part_id = @partId";
                        SqlCommand da = new SqlCommand(query, connect);
                        da.Parameters.AddWithValue("@partId", part_Id);
                        connect.Open();
                        var cost = da.ExecuteScalar();
                        cost = Convert.ToInt32(cost) * Int32.Parse(orderQuantity);
                        string sqlCommand = "INSERT INTO orders(order_number,part_id,status,costs,quantity,o_date) values(@orderNumber,@partId,@status,@costs,@orderQuantity,@orderDate)";
                        SqlCommand execute = new SqlCommand(sqlCommand, connect);
                        execute.Parameters.AddWithValue("@orderNumber", orderNumber);
                        execute.Parameters.AddWithValue("@partId", part_Id);
                        execute.Parameters.AddWithValue("@status", status);
                        execute.Parameters.AddWithValue("@costs", cost);
                        execute.Parameters.AddWithValue("@orderQuantity", orderQuantity);
                        execute.Parameters.Add("@orderDate", SqlDbType.Date).Value = orderDate.Value.Date;
                        execute.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error has occured.");
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {

                    }

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Must enter an Order Number.");
                }
            }
            else
            {
                MessageBox.Show("Must enter an Order number, and it must be an integer.");
            }

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            orderStatus.Items.Add("Delivered");
            orderStatus.Items.Add("Ordered");
            orderStatus.Items.Add("Back-Order");

            for (int i = 1; i < 99; i++)
            {
                quantity.Items.Add(i.ToString());
            }

            using (SqlConnection conn = new SqlConnection(global::MECHClubApp.Properties.Settings.Default.MECHDatabaseConnectionString))
            {
                try
                {
                    string query = "select part_id from parts";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PartId");
                    partId.DisplayMember = "part_id";
                    partId.ValueMember = "PartId";
                    partId.DataSource = ds.Tables["PartId"];
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
    }
}
