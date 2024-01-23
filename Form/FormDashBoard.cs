using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemeGestionHoteliere
{
    public partial class FormDashBoard : Form
    {
        public string Username;
       

        public FormDashBoard()
        {
            InitializeComponent();
        }
        
        private void MovePanel(Control btn)
        {
            
        }
        
        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Are you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
                FormLogin f = new FormLogin();
                f.Show();
            }
            
                
            
        }

       
        private void pictureBoxMini_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMini, "Minimize");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
            userControlSetting1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
           
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControlSetting1.Hide();
            
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.clear();
            userControlDashboard1.Show();

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            userControlSetting1.Hide();
            userControlClient1.clear();
            userControlClient1.Show();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();

        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.clear();
            userControlRoom1.Show();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();

        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.clear();
            userControlReservation1.Show();
            userControlDashboard1.Hide();

        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSetting);
            userControlSetting1.clear();
            userControlSetting1.Show();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();


        }

        private void userControlClient1_Load(object sender, EventArgs e)
        {

        }

        private void userControlSetting1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
