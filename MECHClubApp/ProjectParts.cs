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
    public partial class ProjectParts : Form
    {
        public ProjectParts()
        {
            InitializeComponent();
        }

        private void ProjectParts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mECHDatabaseDataSet.project_parts' table. You can move, or remove it, as needed.
            this.project_partsTableAdapter.Fill(this.mECHDatabaseDataSet.project_parts);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProjectPart addProjectPart = new AddProjectPart();
            addProjectPart.ShowDialog(this);
            this.project_partsTableAdapter.Fill(this.mECHDatabaseDataSet.project_parts);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteProjectPart deleteProjectPart = new DeleteProjectPart();
            deleteProjectPart.ShowDialog(this);
            this.project_partsTableAdapter.Fill(this.mECHDatabaseDataSet.project_parts);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable filtered = new DataTable();
            FilterProjectParts filterProjectParts = new FilterProjectParts(filtered);
            filterProjectParts.ShowDialog(this);
            filtered = filterProjectParts.getFilteredData();
            projectPartsGrid.DataSource = filtered;
        }
    }
}
