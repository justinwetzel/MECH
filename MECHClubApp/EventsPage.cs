﻿using System;
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
    public partial class EventsPage : Form
    {
        public EventsPage()
        {
            InitializeComponent();
        }

        private void add_part_button_Click(object sender, EventArgs e)
        {
            AddEvent
        }

        private void delete_event_button_Click(object sender, EventArgs e)
        {

        }

        private void filter_event_button_Click(object sender, EventArgs e)
        {

        }

        private void EventsPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mECHDatabaseDataSet.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.mECHDatabaseDataSet.events);

        }

        /*
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
        */
    }
}