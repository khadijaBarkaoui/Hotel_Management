using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;
using System.Data.SqlClient;

namespace SystemeGestionHoteliere
{
    public partial class FormLogin : Form
    {
       
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PP06F1U\SQLEXPRESS;Initial Catalog=Systeme_Gestion_Hoteliere;Integrated Security=True");
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void pictureBoxMini_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMini,"Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormUpdatePassword f = new FormUpdatePassword();
            f.Show();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
          
             con.Open();
             SqlDataAdapter da = new SqlDataAdapter("select count(*) from User_tbl where User_name='" + textBoxUsername.Text + "' and User_password='" + textBoxPassword.Text + "' ", con);
             DataTable dt = new DataTable();
             da.Fill(dt);
             if (dt.Rows[0][0].ToString() == "1")
             {
                 FormDashBoard fd= new FormDashBoard();
                fd.Username = textBoxUsername.Text;
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                fd.Show();
                 this.Hide();
             }

             else
                 MessageBox.Show("wrong Username or Password");
           
                con.Close();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow,"show password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "hide password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aboutus u = new Aboutus();
            u.Show();
        }
    }
}
