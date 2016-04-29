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
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mECHDatabaseDataSet.projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.mECHDatabaseDataSet.projects);
            // TODO: This line of code loads data into the 'mECHDatabaseDataSet.orders' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject();
            addProject.ShowDialog(this);
            this.projectsTableAdapter.Fill(this.mECHDatabaseDataSet.projects);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteProject deleteProject = new DeleteProject();
            deleteProject.ShowDialog(this);
            this.projectsTableAdapter.Fill(this.mECHDatabaseDataSet.projects);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable filtered = new DataTable();
            FilterProjects filterProjects = new FilterProjects(filtered);
            filterProjects.ShowDialog(this);
            filtered = filterProjects.getFilteredData();
            if (filtered != null)
            {
                if (filtered.Rows.Count > 0)
                {
                    projectsGrid.DataSource = filtered;
                }
            }
            
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
            /*this.Hide();
            Events eventForm = new Events();
            eventForm.Closed += (s, args) => this.Close();
            eventForm.Show();*/
        }

        private void ordersForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders orderForm = new Orders();
            orderForm.Closed += (s, args) => this.Close();
            orderForm.Show();
        }
    }
}
