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
    public partial class UserControlClient : UserControl
    {
        DbConnector db;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PP06F1U\SQLEXPRESS;Initial Catalog=Systeme_Gestion_Hoteliere;Integrated Security=True");


        SqlCommand cmd = new SqlCommand();
        public void populate()
        {
            con.Open();
            string Myquery = "select * from client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewClient.DataSource = ds.Tables[0];
            con.Close();
        }

        public UserControlClient()
        {
            InitializeComponent();
            db = new DbConnector();
        }
        public void clear()
        { }
       /* public void clear()
        {
            textBoxFirstname.Clear();
            textBoxLastname.Clear();
            textBoxphone.Clear();
            textBoxAddress.Clear();
            tabControlClient.SelectedTab = tabPageAddClient;
        }
        private void clear1()
        {
            textBoxFirstname1.Clear();
            textBoxLastname1.Clear();
            textBoxPhone1.Clear();
            textBoxAddress1.Clear();
            
        }*/


        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string myquery = "update client_tbl set Client_Firstname='" + textBoxFirstname1.Text + "',Client_Lastname='" + textBoxLastname1.Text + "',Client_Adress='"+textBoxAddress1.Text+"', Client_Phone='" + textBoxPhone1.Text + "' where Client_id='"+textBoxIDClient.Text+"' ";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Client successfully updated");
                con.Close();
                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Client not successfully updated");
            }

        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into client_tbl values('" + textBoxFirstname.Text + "','" + textBoxLastname.Text + "','"+textBoxphone.Text+"','"+textBoxAddress.Text+"')", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Client successfully added");

                con.Close();
                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Client  not successfully added");
            }

        }

        private void UserControlClient_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UpdateandDeleteClient_Leave(object sender, EventArgs e)
        {
            //clear();
            //clear1();
        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
           
        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBoxSearchPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDClient.Text = dataGridViewClient[0, dataGridViewClient.CurrentRow.Index].Value.ToString();
            textBoxFirstname1.Text = dataGridViewClient[1, dataGridViewClient.CurrentRow.Index].Value.ToString();
            textBoxLastname1.Text = dataGridViewClient[2, dataGridViewClient.CurrentRow.Index].Value.ToString();
            textBoxPhone1.Text = dataGridViewClient[3, dataGridViewClient.CurrentRow.Index].Value.ToString();
            textBoxAddress1.Text = dataGridViewClient[4, dataGridViewClient.CurrentRow.Index].Value.ToString();
        }

        private void buttondeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = String.Format("delete from client_tbl where Client_Firstname='" + textBoxFirstname1.Text + "'");
                int r = cmd.ExecuteNonQuery();
                if (r != 0)

                    MessageBox.Show("Client deleted", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Client not successfully deleted");
            }
        }
    }
}
