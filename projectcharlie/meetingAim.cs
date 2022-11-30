using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectcharlie
{
    public partial class meetingAimForm : Form
    {
        //Creates new form for meetingAim
        public meetingAimForm()
        {
            InitializeComponent();
        }

        //Selection of meetingAim referenced and sent to main form to change text on meetingAimBtn
        private void mtgAimOkBtn_Click(object sender, EventArgs e)
        {
            if (meetingRBtn.Checked)
            {
                visitorRegForm.whenFormDoes.meetingAim_Btn.Text = meetingRBtn.Text;
            }

            else if (salesApRBtn.Checked)
            {
                visitorRegForm.whenFormDoes.meetingAim_Btn.Text = salesApRBtn.Text;
            }

            else if (siteVisitRBtn.Checked)
            {
                visitorRegForm.whenFormDoes.meetingAim_Btn.Text = siteVisitRBtn.Text;
            }
            
            else if (studentIntRBtn.Checked)
            {
                visitorRegForm.whenFormDoes.meetingAim_Btn.Text = studentIntRBtn.Text;
            }

            this.Close();
        }   

        //If cancel button clicked - form is close with no changes to main form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Created Raidio buttons for meeting aims:
        private void siteVisitRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void studentIntRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void salesApRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
