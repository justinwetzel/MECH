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
    public partial class FilterEvents : Form
    {
        DataTable filterData = new DataTable();
        public FilterEvents(DataTable filter)
        {
            InitializeComponent();
            filterData = filter;
        }

        public DataTable getFilteredData()
        {
            return filterData;
        }
    }
}
