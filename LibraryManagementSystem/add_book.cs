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
    public partial class add_book : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN5RJF\\SQLEXPRESS12; Initial Catalog = library_management; Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapt;


        public add_book()
        {
            InitializeComponent();
        }

        private void save_click(object sender, EventArgs e)
        {
            if(name_text.Text != "" && price_text.Text != "" && publisher_text.Text != "" && dateTimePicker1.Value.ToShortDateString() != "" && quantity_text.Text != "" && author_text.Text != ""  )
            {

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "addBook";

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name_text.Text;
                cmd.Parameters.Add("@author", SqlDbType.VarChar).Value = author_text.Text;
                cmd.Parameters.Add("@publisher", SqlDbType.VarChar).Value = publisher_text.Text;
                cmd.Parameters.Add("@purchase_date", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToShortDateString();
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price_text.Text;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity_text.Text;
                cmd.Parameters.Add("@available_quantity", SqlDbType.Int).Value = quantity_text.Text;


               // cmd = new SqlCommand("insert into book_info(name,author,publisher,purchase_date,price,quantity,available_quantity) values('"+name_text.Text+ "', '" + author_text.Text + "','" + publisher_text.Text + "', '" + dateTimePicker1.Value.ToShortDateString() + "', '" + price_text.Text + "', '" + quantity_text.Text + "', '" + quantity_text.Text + "'  )", con);
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Book details entered successfully.");
                clearData();
            }

            else
            {

                MessageBox.Show("Please fill all the details.");
            }

        }

        private void clearData()
        {
            name_text.Text = "";
            author_text.Text = "";
            publisher_text.Text = "";
            price_text.Text = "";
            quantity_text.Text = "";

        }
    }
}
