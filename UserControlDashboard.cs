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
    public partial class UserControlDashboard : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PP06F1U\SQLEXPRESS;Initial Catalog=Systeme_Gestion_Hoteliere;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public UserControlDashboard()
        {
            InitializeComponent();
        }
        public void clear() { }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
              
            
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from User_tbl", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            labeluser.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter da1 = new SqlDataAdapter("select count(*) from client_tbl", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            labelClient.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter da2 = new SqlDataAdapter("select count(*) from Room_tbl", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            labelRoom.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter da3 = new SqlDataAdapter("select count(*) from Reservation_tbl", con);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            labelReservation.Text = dt3.Rows[0][0].ToString();
            con.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
