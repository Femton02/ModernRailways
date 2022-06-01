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
    public partial class LoginForm : Form
    {
        Controller controllerObj;
        public LoginForm()
        {
            InitializeComponent();
            LogInPanel.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click_1(object sender, EventArgs e)
        {
            SignUpPanel.BringToFront();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LogInPanel.BringToFront();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            int x = controllerObj.CheckPasswordMatch(Email.Text, Password.Text);
            if (x == 0)
            {
                MessageBox.Show("InCorrect Email Or Password...", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable count, count2, count3, count4;
            count = controllerObj.CheckWhetherCustomerViewOrNot(Email.Text);
            count2 = controllerObj.CheckWhetherTicketOfficeViewOrNot(Email.Text);
            count3 = controllerObj.CheckWhetherServiceWorkerOrNot(Email.Text);
            count4 = controllerObj.CheckWhetherManagerOrNot(Email.Text);
                if (count.Rows[0][0].ToString() == "1")
            {
                CustomerView CV = new CustomerView(Email.Text);
                CV.Show();
                this.Close();
            }
            else
            {

                if (count2.Rows[0][0].ToString() == "1")
                {
                    TicketOfficeView TO = new TicketOfficeView(Email.Text);
                    TO.Show();
                    this.Close();
                }
                else
                {

                    if (count3.Rows[0][0].ToString() == "1")
                    {
                        ServiceWorkerView SW = new ServiceWorkerView(Email.Text);
                        SW.Show();
                        this.Close();
                    }
                    else
                    {

                        if (count4.Rows[0][0].ToString() == "1")
                        {
                            ManagerView MV = new ManagerView(Email.Text);
                            MV.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("InCorrect Email Or Password...", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Fname.Text == "" || Lname.Text == "" || ID.Text == "" || DoB.Text == "" || Sex.Text == "" || textBox1.Text == "" || Pass.Text == "") 
                return;
            int result = controllerObj.SubmitUser(Fname.Text, Lname.Text, Int32.Parse(ID.Text), DoB.Value, Sex.Text, textBox1.Text, Pass.Text);
            if (result == 0)
            {
                MessageBox.Show("Submission failed");
            }
            else
            {
                MessageBox.Show("Successfull, Welcome");
            }
            LogInPanel.BringToFront();
        }
    }
}
