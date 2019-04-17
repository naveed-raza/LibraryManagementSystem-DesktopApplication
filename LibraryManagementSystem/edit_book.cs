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
    public partial class edit_book : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN5RJF\\SQLEXPRESS12; Initial Catalog = library_management; Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        int count = 0;
        int id;



        public edit_book()
        {
            
            InitializeComponent();
        }


        private void edit_book_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void search_KeyUp(object sender, KeyEventArgs e)
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


        private void record_click(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;

            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            //name_text.Text = dataGridView1.SelectedCells[1].Value.ToString();               // can be updated by this version also
            try
            {
                cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "particularBookInfo";

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;




               // cmd = new SqlCommand("select * from book_info where id = '" + id + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    name_text.Text = dr["name"].ToString();
                    author_text.Text = dr["author"].ToString();
                    publisher_text.Text = dr["publisher"].ToString();
                    date_text.Text = dr["purchase_date"].ToString();
                    price_text.Text = dr["price"].ToString();
                    quantity_text.Text = dr["quantity"].ToString();
                }




                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void update_click(object sender, EventArgs e)
        {
            panel1.Visible = false;

            try
            {
                cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "editBook";

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name_text.Text;
                cmd.Parameters.Add("@author", SqlDbType.VarChar).Value = author_text.Text;
                cmd.Parameters.Add("@publisher", SqlDbType.VarChar).Value = publisher_text.Text;
                cmd.Parameters.Add("@purchase_date", SqlDbType.VarChar).Value = date_text.Text;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price_text.Text;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity_text.Text;
                cmd.Parameters.Add("@available_quantity", SqlDbType.Int).Value = quantity_text.Text;

                // cmd = new SqlCommand("update book_info set name='" + name_text.Text + "', author = '" + author_text.Text + "', publisher = '" + publisher_text.Text + "', purchase_date = '" + date_text.Text + "', price = '" + price_text.Text + "', quantity = '" + quantity_text.Text + "', available_quantity =  '" + quantity_text.Text + "' where id = '" + id + "' ", con);

                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);

                MessageBox.Show("Record has been updated.");
                con.Close();

                displayData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void displayData()
        {
            try
            {
                //cmd = new SqlCommand("select * from book_info", con);

                cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "allBookInfo";

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
