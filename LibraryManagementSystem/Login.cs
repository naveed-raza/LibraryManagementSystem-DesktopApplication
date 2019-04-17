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

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN5RJF\\SQLEXPRESS12; Initial Catalog = library_management; Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapt;

        public Login()
        {
            InitializeComponent();
        }

      

        private void login_click(object sender, EventArgs e)
        {


            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loginCheck";

            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = user_text.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = pass_text.Text;
          
            // cmd = new SqlCommand("select * from user_info where username = '"+ user_text.Text +"'and password = '"+ pass_text.Text +"' ", con);
            con.Open();

            int Count = 0;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);

            Count = Convert.ToInt32(dt.Rows.Count.ToString());

            if(Count == 1)
            {
                this.Hide();
                MDIParent1 mu = new MDIParent1();
                mu.Show();
            }
            else
            {
                MessageBox.Show("Please enter correct username and password.");
            }

            con.Close();

        }

        private void exit_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
