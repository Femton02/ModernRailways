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
    public partial class ServiceWorkerView : Form
    {
        string Email;
        Controller controllerObj;
        public ServiceWorkerView(string SentEmail)
        {
            Email = SentEmail;
            InitializeComponent();
            RescheduleTrainsPanel.BringToFront();
        }

        private void RescheduleTrains_Click(object sender, EventArgs e)
        {
            RescheduleTrainsPanel.BringToFront();
        }

        private void ManageTracks_Click(object sender, EventArgs e)
        {
            ManageTracksPanel.BringToFront();
        }

        private void ManageCoach_Click(object sender, EventArgs e)
        {
            ManageCoachPanel.BringToFront();
        }

        private void WarnPassenger_Click(object sender, EventArgs e)
        {
            GiveWarningPanel.BringToFront();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiceWorkerView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'railWayStationDataSet19.Trip' table. You can move, or remove it, as needed.
            this.tripTableAdapter1.Fill(this.railWayStationDataSet19.Trip);
            // TODO: This line of code loads data into the 'railWayStationDataSet18.Trip' table. You can move, or remove it, as needed.
            this.tripTableAdapter.Fill(this.railWayStationDataSet18.Trip);
            // TODO: This line of code loads data into the 'railWayStationDataSet9.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.railWayStationDataSet9.Manager);
            controllerObj = new Controller();
        }

        private void ConfirmTripID_Click(object sender, EventArgs e)
        {

        }

        private void TripIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtt = controllerObj.Getcoach(Int32.Parse(TripIDCombo.Text));
            CoachesTable.DataSource = dtt;
        }

        private void WarningReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void WarnButton_Click(object sender, EventArgs e)
        {
            if (PassIDWarn.Text == "" || WarningReason.Text == "")
                return;
            controllerObj.setwarn(Email, Int32.Parse(PassIDWarn.Text), WarningReason.Text);
        }

        private void ManageTracksPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dttt = controllerObj.select2(Int32.Parse(TripIDCombo.Text));
            dataGridView1.DataSource = dttt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
