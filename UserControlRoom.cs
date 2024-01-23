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
    public partial class UserControlRoom : UserControl
    {
        DbConnector db;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PP06F1U\SQLEXPRESS;Initial Catalog=Systeme_Gestion_Hoteliere;Integrated Security=True");


        SqlCommand cmd = new SqlCommand();
        public void populate()
        {
            con.Open();
            string Myquery = "select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewRoom.DataSource = ds.Tables[0];
            con.Close();
        }
        public UserControlRoom()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void clear()
        { }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            clear();
        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
         
        }

        private void Updateanddeleteroom_Leave(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Room_tbl values('" + comboBoxType.SelectedItem + "','" + textBoxPhN.Text + "','"+comboBoxYesNo.SelectedItem+"')", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Room successfully added");

                con.Close();
                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Room not successfully added");
            }

        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxtype.Text = dataGridViewRoom[1, dataGridViewRoom.CurrentRow.Index].Value.ToString();
            textBoxphoneNo1.Text = dataGridViewRoom[2, dataGridViewRoom.CurrentRow.Index].Value.ToString();
            textBoxroomnb.Text = dataGridViewRoom[0, dataGridViewRoom.CurrentRow.Index].Value.ToString();
            textBoxfree.Text = dataGridViewRoom[3, dataGridViewRoom.CurrentRow.Index].Value.ToString();
        }

        private void buttonupdateroom_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string myquery = "update Room_tbl set Room_phone='" + textBoxphoneNo1.Text + "',Room_free ='" + textBoxfree.Text + "',Room_type ='" + textBoxtype.Text + "'  where Room_number='" + textBoxroomnb.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Room successfully updated");
                con.Close();
                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Room not successfully updated");
            }
        }

        private void buttondeleteroom_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = String.Format("delete from Room_tbl where Room_number='" + textBoxroomnb.Text + "'");
                int r = cmd.ExecuteNonQuery();
                if (r != 0)

                    MessageBox.Show("Room deleted", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Room not successfully deleted");
            }
        }
    }
}
