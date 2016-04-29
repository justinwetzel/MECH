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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter1.Fill(this.database1DataSet.events);
            // TODO: This line of code loads data into the 'mECHDatabaseDataSet.events' table. You can move, or remove it, as needed.
            //this.eventsTableAdapter.Fill(this.mECHDatabaseDataSet.events);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent();
            addEvent.ShowDialog(this);
            //this.eventsTableAdapter.Fill(this.mECHDatabaseDataSet.events);
            this.eventsTableAdapter1.Fill(this.database1DataSet.events);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteEvent deleteEvent = new DeleteEvent();
            deleteEvent.ShowDialog(this);
            //this.eventsTableAdapter.Fill(this.mECHDatabaseDataSet.events);
            this.eventsTableAdapter1.Fill(this.database1DataSet.events);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable filtered = new DataTable();
            FilterEvents filterEvents = new FilterEvents(filtered);
            filterEvents.ShowDialog(this);
            filtered = filterEvents.getFilteredData();
            //projectsGrid.DataSource = filtered;
            eventsDataGridView.DataSource = filtered;
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

        private void eventsForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events eventForm = new Events();
            eventForm.Closed += (s, args) => this.Close();
            eventForm.Show();
        }

        private void ordersForm_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Orders orderForm = new Orders();
            orderForm.Closed += (s, args) => this.Close();
            orderForm.Show();*/
        }
    }
}
