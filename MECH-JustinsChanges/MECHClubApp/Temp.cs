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
    public partial class Temp : Form
    {
        public Temp()
        {
            InitializeComponent();
        }

        private void eventsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Temp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.database1DataSet.events);

        }

        private void eventsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
