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
    
    public partial class UserControlReservation : UserControl
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PP06F1U\SQLEXPRESS;Initial Catalog=Systeme_Gestion_Hoteliere;Integrated Security=True");
        public static SqlTransaction Otr1;
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public static DataSet ds = new DataSet();
        public static SqlDataReader Odr1;
        DataTable dt = new DataTable();
       //public static DataSet Ods1 = new DataSet();
        public UserControlReservation()
        {
            InitializeComponent();
            
        }

        public void clear()
        { }
        int a;
        public void populate()
        {
            con.Open();
            string Myquery = "select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Reservation_tbl");
            dataGridViewReservation.DataSource = ds.Tables["Reservation_tbl"];
            con.Close();
        }

        //DateTime today;
        private void buttonADDReservation_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Otr1 = con.BeginTransaction();
                cmd.Connection = con;
                cmd.CommandText = "insert into Reservation_tbl values('"+comboBoxRType.SelectedItem+"','"+comboBoxRNo.SelectedItem+"','"+textBoxCID.Text+"','"+textBox1.Text+"','"+textBox2.Text+"')";
                cmd.Transaction = Otr1;
                cmd.ExecuteNonQuery();
                Otr1.Commit();

                MessageBox.Show("Reservation successfully added");
                
                con.Close();
                populate();
            }
            catch (Exception)
            {
                Otr1.Rollback();
                MessageBox.Show("Reservation  not successfully added");
            }


        }

        private void dataGridViewReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonUpdateReservation_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                Otr1 = con.BeginTransaction();
                cmd.Connection = con;
                cmd.CommandText = "update Reservation_tbl set Roomnbre='" + textBoxRnbre.Text + "',Roomtype='" + textBoxrtype.Text + "',clientid='" + textBoxcid1.Text + "', inhotel='" + textBox3.Text + "',outhotel='" + textBox4.Text + "' where Reservation_id='" + textBoxIDRESER.Text + "' ";
                cmd.Transaction = Otr1;
                cmd.ExecuteNonQuery();
                Otr1.Commit();

                MessageBox.Show("Reservation successfully updated");

                con.Close();
                populate();
            }
            catch (Exception)
            {
                Otr1.Rollback();
                MessageBox.Show("Reservation  not successfully updated");
            }


        }

        private void buttonDeleteReservation_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter P1 = new SqlParameter("@reservaID",
                SqlDbType.Int);
                
                P1.Value =textBoxIDRESER.Text;
                cmd.Parameters.Add(P1);
                
                cmd.CommandText = "PS_supp_Reservation1";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation deleted successfully");
                cmd2.Connection = con;
                cmd2.CommandText = ("Select * from Reservation_tbl");
                Odr1 = cmd2.ExecuteReader();
                DataTable Odt1 = new DataTable();
                Odt1.Load(Odr1);
                dataGridViewReservation.DataSource = Odt1;
                populate();
            }
            catch(Exception)
            {
                
            }
            
           
        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            populate();
          
        }

        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewReservation_Click(object sender, EventArgs e)
        {
            textBoxIDRESER.Text = dataGridViewReservation[0, dataGridViewReservation.CurrentRow.Index].Value.ToString();
            textBoxRnbre.Text = dataGridViewReservation[2, dataGridViewReservation.CurrentRow.Index].Value.ToString();
            textBoxrtype.Text = dataGridViewReservation[1, dataGridViewReservation.CurrentRow.Index].Value.ToString();
            textBoxcid1.Text = dataGridViewReservation[3, dataGridViewReservation.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridViewReservation[4, dataGridViewReservation.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridViewReservation[5, dataGridViewReservation.CurrentRow.Index].Value.ToString();
        }

        private void dateTimePickerIN_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePickerOUT_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
