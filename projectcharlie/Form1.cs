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

namespace projectcharlie
{
    public partial class visitorRegForm : Form
    {
        public static visitorRegForm whenFormDoes;

        public object mtgAimOkBtn { get; internal set; }
        public object salesApRBtn { get; internal set; }


        //Granting access between MeetingAim form and meetingAimBtn (button) on main VisitorRegForm
        public visitorRegForm()
        
        {
            InitializeComponent();
            whenFormDoes = this;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //Allows Meeting date to be changed / chosen
        {

        }

        //Show secondary form to select meeting topic
        private void meetingAim_Btn_Click(object sender, EventArgs e)
        {
            meetingAimForm aim = new meetingAimForm();
            aim.Show();
        }

        private void TB_nameLabel_TextChanged(object sender, EventArgs e)
        {
            //To allow user to enter text
        }

        //Gathering inputted data to complie into List for ListViewBox
        private void signIn_Btn_Click(object sender, EventArgs e)
        {
            string name = TB_nameLabel.Text;
            string surname = TB_surname.Text;
            string mobileNumber = TB_mobileNumber.Text;
            string email = TB_emailAddress.Text;
            string date = dateTimePicker1.Text;
            string time = hour.Text + minutes.Text;
            string meeting = staffMemberCBX.Text;
            string aim = meetingAim_Btn.Text;
            int mobPhNumber = 0;

            InitializeComponent();
            string ConnectVisitor = @"Data Source=ANNETTEBIGBY\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
  
            // Creating instance of SqlConnection 

            SqlConnection ConnectV = new SqlConnection(ConnectVisitor);

            // set the sql command ( Statement )  
            string sql_Query = "select Visitor.VisitorID, Visitor.FirstName, Visitor.Surname, Visitor.Mobile, Visitor.Email, Visitor.Meetingdate, Visitor.MeetingTime, Visitor.MeetingAim, Where Visitor.StaffID = Staff.StaffID";

            // Creating instance of SqlCommand and set the connection and query to instance of SqlCommand
            SqlCommand cmd = new SqlCommand(sql_Query, ConnectV);
            cmd.Parameters.Clear();

            //Open connection
            ConnectV.Open();

            // Creating instance of SqlDataReader 

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //populate data in Listbox from Reader
                visitorsOnsiteListLB.Items.Add(reader["name"] + " -" + reader["mobileNumber"] + " " + reader["email"] + " " + reader["date"] + " " + reader["time"] + " "+ reader["meeting"] + " "+ reader["meeting"] + " "+ reader["aim"]);

                //Close Database reader
                reader.Close();

            }

            //Close connection
                ConnectV.Close();





            //Validation (lines 66 to 94: if no text has been entered into text boxes - show message "xxxx is amsandatory"
            if (name == "")
            {
                TB_nameLabel.Focus();
                MessageBox.Show("First name is mandatory. ");
            }

            else if (surname == "")
            {
                TB_surname.Focus();
                MessageBox.Show("Surname is mandatory. ");
            }

            else if (mobileNumber == "")
            {
                TB_mobileNumber.Focus();
                MessageBox.Show("Mobile Number is mandatory. ");
            }
            else if (int.TryParse(mobileNumber, out mobPhNumber) == false) 
            {
                TB_mobileNumber.Focus();
                MessageBox.Show("Mobile Number must be numeric: maximum of 10 digits. ");
            }

            else if (email == "")
            {
                TB_emailAddress.Focus();
                MessageBox.Show("Email is mandatory. ");
            }

            else if (email.Contains("@") ==false)
            {
                TB_emailAddress.Focus();
                MessageBox.Show("Email address must include an @ symbol. ");
            }

            else if (time == "00")
            {
                hour.Focus();
                MessageBox.Show("What is the time of your meeting? ");
            }

            else if (meeting == "")
            {
                staffMemberCBX.Focus();
                MessageBox.Show("meeting with is manadatory. ");
            }

            else if (aim == "Meeting Aim")
            {
                meetingAim_Btn.Focus();
                MessageBox.Show("Please select Meeting Aim. ");
            }

            else //Creates list of entered information in ListviewBox/visitorsOnsiteListLB
            {

                visitorsOnsiteListLB.Items.Add(text: "Visitor: " + name + " " + surname);
                visitorsOnsiteListLB.Items.Add(text: "Mobile: " + mobileNumber);
                visitorsOnsiteListLB.Items.Add(text: "Email: " + email);
                visitorsOnsiteListLB.Items.Add(text: "Date & time: " + date + " " + hour.Value + ":" + minutes.Value);
                visitorsOnsiteListLB.Items.Add(text: "Meeting with: " + meeting);
                visitorsOnsiteListLB.Items.Add(text: "Aim: " + aim);
                visitorsOnsiteListLB.Items.Add(text: " --------------------------------");

                clearForm();

                testIsFormCleared(); //Method for whitebox testing. See lne 126 - 167.

            }

        }
        // Whitebox Testing - has form's inputted data been cleared? 
        private void testIsFormCleared()
        {
            if (TB_nameLabel.Text != "")
            {
                MessageBox.Show("test failed. Firstname was not cleared. ");
            }

            if (TB_surname.Text != "")
            {
                MessageBox.Show("test failed. Surname was not cleared. ");
            }

            if (TB_mobileNumber.Text != "")
            {
                MessageBox.Show("test failed. Mobile Number was not cleared. ");
            }

            if (TB_emailAddress.Text != "")
            {
                MessageBox.Show("test failed. Email Addresss was not cleared. ");
            }

            if (hour.Value != 0)
            {
                MessageBox.Show("test failed. Hour was not cleared. ");
            }

            if (minutes.Value != 0)
            {
                MessageBox.Show("test failed. Minutes was not cleared. ");
            }

            if (staffMemberCBX.Text != "")
            {
                MessageBox.Show("test failed. Staff member was not cleared. ");
            }

            if (meetingAim_Btn.Text != "Meeting Aim")
                {
                MessageBox.Show("test failed. Meeting Aim Text Button was not cleared. ");
                }
        } 

      
        //Clears form back to defaults once Sign in Button has been clicked and list compiled in visitorsOnsiteListLB
        private void clearForm()
        {
            TB_nameLabel.Text = "";
            TB_surname.Text = "";
            TB_mobileNumber.Text = "";
            TB_emailAddress.Text = "";
            hour.Value = 0;
            minutes.Value = 0;
            staffMemberCBX.Text = "";
            meetingAim_Btn.Text = "Meeting Aim"; //commented out for testing purposes
        }


        private void TB_surname_TextChanged(object sender, EventArgs e)
        {
            //Allows for surname to be entered in Text Box
        }

        //Visitor listbox no longer used: changed to ListViewBox to allow for listing of entered data
        private void visitorsOnsiteListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string visitorsOnsite; //visitorsOnsiteListLB;
        }

        //Choose meeting start time - 24 hour clock: hense max hour = 24
        private void hour_ValueChanged(object sender, EventArgs e)
        {
            hour.Maximum = 24;
        }

        //Choose meeting start time: 00,15,30,45;
        private void minutes_ValueChanged(object sender, EventArgs e)
        {

        }

        //Action to delete multiple lines in ListViewBox using delete key
        private void visitorsOnsiteListLB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {

                foreach (ListViewItem item in visitorsOnsiteListLB.SelectedItems)
                {
                    visitorsOnsiteListLB.Items.Remove(item);

                }

            }
        }
    }
}
    