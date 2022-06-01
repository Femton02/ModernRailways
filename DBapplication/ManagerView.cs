using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ManagerView : Form
    {
        string Email;
        Controller controllerObj;
        public ManagerView(string SentEmail)
        {
            Email = SentEmail;
            InitializeComponent();
            NewsPanel.BringToFront();
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'railWayStationDataSet10.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.railWayStationDataSet10.Manager);
            controllerObj = new Controller();
        }

        private void TimetableVeiw_Click(object sender, EventArgs e)
        {
            NewsPanel.BringToFront();
        }

        private void AddTrains_Click(object sender, EventArgs e)
        {
            AddTrainPanel.BringToFront();
        }

        private void ManageTrips_Click(object sender, EventArgs e)
        {
            AddTripPanel.BringToFront();
        }

        private void RescheduleTrains_Click(object sender, EventArgs e)
        {
            RescheduleTrainPanel.BringToFront();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            HomeForm HF = new HomeForm();
            HF.Show();
            this.Close();
        }

        private void AddNews_Click(object sender, EventArgs e)
        {
            if (NewsTextBox.Text == "")
                return;
            controllerObj.SetUpdatesandNews(Email, NewsTextBox.Text);
        }
    }
}
