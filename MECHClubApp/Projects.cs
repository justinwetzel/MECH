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

        }
    }
}
