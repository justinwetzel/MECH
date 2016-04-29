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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mECHDatabaseDataSet.parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.mECHDatabaseDataSet.parts);

        }

        private void add_part_button_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.ShowDialog(this);
            this.partsTableAdapter.Fill(this.mECHDatabaseDataSet.parts);
        }

        private void delete_part_button_Click(object sender, EventArgs e)
        {
            DeletePart deletePart = new DeletePart();
            deletePart.ShowDialog(this);
            this.partsTableAdapter.Fill(this.mECHDatabaseDataSet.parts);
        }

        private void filter_part_button_Click(object sender, EventArgs e)
        {
            DataTable filtered = new DataTable();
            FilterParts filterParts = new FilterParts(filtered);
            filterParts.ShowDialog(this);
            filtered = filterParts.getFilteredData();
            if(filtered != null)
            {
                if(filtered.Rows.Count > 0)
                {
                    partsGrid.DataSource = filtered;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projects projectForm = new Projects();
            projectForm.Closed += (s, args) => this.Close();
            projectForm.Show();
        }

        private void projectPartsForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectParts projectPartsForm = new ProjectParts();
            projectPartsForm.Closed += (s, args) => this.Close();
            projectPartsForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Orders orderForm = new Orders();
            orderForm.Closed += (s, args) => this.Close();
            orderForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
