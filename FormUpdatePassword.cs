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

namespace SystemeGestionHoteliere
{
    public partial class FormUpdatePassword : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PP06F1U\SQLEXPRESS;Initial Catalog=Systeme_Gestion_Hoteliere;Integrated Security=True");
        public FormUpdatePassword()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string myquery = "update User_tbl set User_password='" + textBoxPassword.Text + "' where User_name='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show(" Successfully Reset");
                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Retype Username or Password");
            }
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMini_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMini, "Minimize");
        }

        private void pictureBoxMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "show password");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
