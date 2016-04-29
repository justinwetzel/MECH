using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MECHClubApp
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mECHDatabaseDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.mECHDatabaseDataSet.orders);

        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            addOrder.ShowDialog(this);
            this.ordersTableAdapter.Fill(this.mECHDatabaseDataSet.orders);
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder deleteOrder = new DeleteOrder();
            deleteOrder.ShowDialog(this);
            this.ordersTableAdapter.Fill(this.mECHDatabaseDataSet.orders);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable filtered = new DataTable();
            FilterOrders filterOrders = new FilterOrders(filtered);
            filterOrders.ShowDialog(this);
            filtered = filterOrders.getFilteredData();
            if (filtered != null)
            {
                if (filtered.Rows.Count > 0)
                {
                    ordersGrid.DataSource = filtered;
                }
            }
        }

        private void eventsForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events eventForm = new Events();
            eventForm.Closed += (s, args) => this.Close();
            eventForm.Show();
        }

        private void projectsForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projects projectForm = new Projects();
            projectForm.Closed += (s, args) => this.Close();
            projectForm.Show();
        }

        private void partsForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 partForm = new Form1();
            partForm.Closed += (s, args) => this.Close();
            partForm.Show();
        }

        private void projectPartsForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectParts projectPartsForm = new ProjectParts();
            projectPartsForm.Closed += (s, args) => this.Close();
            projectPartsForm.Show();
        }
    }
}
