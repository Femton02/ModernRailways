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
    public partial class CustomerView : Form
    {
        string Email;
        Controller controllerObj;
        public CustomerView(string SentEmail)
        {
            Email = SentEmail;
            InitializeComponent();
            HomePanel.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'railWayStationDataSet7.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter5.Fill(this.railWayStationDataSet7.Station);
            // TODO: This line of code loads data into the 'railWayStationDataSet6.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter4.Fill(this.railWayStationDataSet6.Station);
            // TODO: This line of code loads data into the 'railWayStationDataSet5.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter3.Fill(this.railWayStationDataSet5.Station);
            // TODO: This line of code loads data into the 'railWayStationDataSet4.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter2.Fill(this.railWayStationDataSet4.Station);
            // TODO: This line of code loads data into the 'railWayStationDataSet3.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter1.Fill(this.railWayStationDataSet3.Station);
            // TODO: This line of code loads data into the 'railWayStationDataSet2.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.railWayStationDataSet2.Manager);
            // TODO: This line of code loads data into the 'railWayStationDataSet1.Subscription' table. You can move, or remove it, as needed.
            this.subscriptionTableAdapter.Fill(this.railWayStationDataSet1.Subscription);
            // TODO: This line of code loads data into the 'railWayStationDataSet.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter.Fill(this.railWayStationDataSet.Station);
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectWarnings(Email);
            WarningGrid.DataSource = dt;
            DataTable dt2 = controllerObj.SelectReservedTrips(Email);
            ReservedGrid.DataSource = dt2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePanel.BringToFront();
        }

        private void AccountInfo_Click(object sender, EventArgs e)
        {
            AccountPanel.BringToFront();
            //DataTable t1 = controllerObj.GetUserData(Email);
            //DisplayFName.Text = t1.Rows[0][1].ToString();
            //DisplayLname.Text = t1.Rows[0][2].ToString();
            //DisplayMail.Text = Email;
            //string subtype = controllerObj.GetSubType(Int16.Parse(t1.Rows[0][5].ToString()));
            //DisplaySubType.Text = subtype;

        }

        private void Booking_Click(object sender, EventArgs e)
        {
            BookingPanel.BringToFront();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            RetExPanel.BringToFront();
        }

        private void TimetableVeiw_Click(object sender, EventArgs e)
        {
            TimeTablePanel.BringToFront();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReservedGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectTripsTimeTable(comboBox3.Text, comboBox2.Text, dateTimePicker1.Text);
            dataGridView1.DataSource = dt;
        }

        private void AccountPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DelAccount_Click(object sender, EventArgs e)
        {
            if (DelMail.Text == "" || DelPassword.Text == "")
                return;
            int x = controllerObj.CheckPasswordMatch(DelMail.Text, DelPassword.Text);
            if (x == 0)
                return;
            int y = controllerObj.DeleteAccount(DelMail.Text);
            return;
        }
    }
}
