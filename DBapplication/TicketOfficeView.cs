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
    public partial class TicketOfficeView : Form
    {
        string Email;
        Controller controllerObj;
        public TicketOfficeView(string SentEmail)
        {
            Email = SentEmail;
            InitializeComponent();
            TimeTablePanel.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'railWayStationDataSet17.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter5.Fill(this.railWayStationDataSet17.Station);
            // TODO: This line of code loads data into the 'railWayStationDataSet16.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter4.Fill(this.railWayStationDataSet16.Station);
            // TODO: This line of code loads data into the 'railWayStationDataSet15.Trip' table. You can move, or remove it, as needed.
            this.tripTableAdapter.Fill(this.railWayStationDataSet15.Trip);
            // TODO: This line of code loads data into the 'railWayStationDataSet14.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter3.Fill(this.railWayStationDataSet14.Station);
            // TODO: This line of code loads data into the 'railWayStationDataSet13.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter2.Fill(this.railWayStationDataSet13.Station);
            // TODO: This line of code loads data into the 'railWayStationDataSet12.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter1.Fill(this.railWayStationDataSet12.Station);
            // TODO: This line of code loads data into the 'railWayStationDataSet11.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter.Fill(this.railWayStationDataSet11.Station);
            // TODO: This line of code loads data into the 'railWayStationDataSet8.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.railWayStationDataSet8.Manager);
            controllerObj = new Controller();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimetableVeiw_Click(object sender, EventArgs e)
        {
            TimeTablePanel.BringToFront();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            BookingPanel.BringToFront();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            RetExPanel.BringToFront();
        }

        private void IssueFine_Click(object sender, EventArgs e)
        {
            IssueFinePanel.BringToFront();
        }

        private void ManageCoaches_Click(object sender, EventArgs e)
        {
            ManageCoachPanel.BringToFront();
        }

        private void PassIDWarn_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ConfirmPassIDWarn_Click(object sender, EventArgs e)
        {
            DataTable t1 = controllerObj.GetWarn(Int32.Parse(PassIDWarn.Text));
            WarningsTable.DataSource = t1;
        }

        private void WarningsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IssueFinePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ArrivalSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectTripsTimeTable(comboBox3.Text, comboBox2.Text, dateTimePicker1.Value.ToString());
            AvailableTrains.DataSource = dt;
        }

        private void DepartureSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectTripsTimeTable(comboBox3.Text, comboBox2.Text, dateTimePicker1.Value.ToString());
            dataGridView1.DataSource = dt;

        }

        private void BookingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfirmTripID_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Getcoach(Int32.Parse(TripIDCombo.Text));
            CoachesTable.DataSource = dt;
        }

        private void TripIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TicketsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
