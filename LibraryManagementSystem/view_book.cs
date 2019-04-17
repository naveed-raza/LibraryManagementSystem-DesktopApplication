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
    public partial class view_book : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN5RJF\\SQLEXPRESS12; Initial Catalog = library_management; Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        int count = 0;
        int id;
        


        public view_book()
        {
            InitializeComponent();
        }


        private void view_book_Load(object sender, EventArgs e)
        {
            displayData();
        }




        private void search_keyUp(object sender, KeyEventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from book_info where name like ( '%" + search_text.Text + "%') ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(cmd);

                adapt.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (count == 0)
            {
                MessageBox.Show("No record found.");
            }
        }

        

        private void displayData()
        {
            try
            {
                cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "allBookInfo";

                //cmd = new SqlCommand("select * from book_info", con);
                con.Open();
                adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
