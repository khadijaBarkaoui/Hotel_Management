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
    public partial class UserControlSetting : UserControl
    {
        DbConnector db;

       // private string ID = "";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PP06F1U\SQLEXPRESS;Initial Catalog=Systeme_Gestion_Hoteliere;Integrated Security=True");
       
       
        SqlCommand cmd = new SqlCommand();
        public void populate()
        {
            con.Open();
            string Myquery = "select * from User_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery,con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewUser.DataSource = ds.Tables[0];
            con.Close();
        }
        
     
        public UserControlSetting()
        {
            InitializeComponent();
            db = new DbConnector();
        }
     
        public void clear()
        { }


        /* public void clear()
         {
             textBoxUsername1.Clear();
             textBoxPassword1.Clear();
             tabControlUser.SelectedTab = tabPageADDUser;
         }

         private void clear1()
         {
             textBoxUsername.Clear();
             textBoxPassword.Clear();
             ID = "";
         }*/
     
        private void tabPageADDUser_Leave(object sender, EventArgs e)
        {
            clear();
            
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
           // db.DisplayAndSearch("select * from User_tbl",dataGridViewUser);
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            
        }

        private void UpdateAndDeleteUser_Leave(object sender, EventArgs e)
        {
             clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
             try
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand("insert into User_tbl values('" + textBoxUsername.Text + "','" + textBoxPassword.Text + "')", con);

                 cmd.ExecuteNonQuery();
                 MessageBox.Show("User successfully added");
              
                 con.Close();
                populate();
            }
             catch (Exception)
             {
                 MessageBox.Show("User not successfully added");
             }

        }

        private void UserControlSetting_Load(object sender, EventArgs e)
        {

            populate();
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewUser[0,dataGridViewUser.CurrentRow.Index].Value.ToString();
            textBoxUsername1.Text = dataGridViewUser[1, dataGridViewUser.CurrentRow.Index].Value.ToString();
            textBoxPassword1.Text = dataGridViewUser[2, dataGridViewUser.CurrentRow.Index].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
             {
                 con.Open();

                string myquery = "update User_tbl set User_name ='" + textBoxUsername1.Text + "',User_password='" + textBoxPassword1.Text + "'  where User_id='" + textBoxID.Text + "'";
                 SqlCommand cmd = new SqlCommand(myquery, con);
                 cmd.ExecuteNonQuery();

                 MessageBox.Show("User successfully updated");
                 con.Close();
                 populate();
             }
             catch (Exception)
             {
                 MessageBox.Show("User not successfully updated");
             }
       

        }

        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void buttondelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = String.Format("delete from User_tbl where User_name='" + textBoxUsername1.Text + "'");
                int r = cmd.ExecuteNonQuery();
                if (r != 0)

                    MessageBox.Show("User deleted", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("User not successfully deleted");
            }
        }

      
    }
}


