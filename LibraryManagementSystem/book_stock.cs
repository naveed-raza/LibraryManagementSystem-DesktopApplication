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
using System.Net;
using System.Net.Mail;


namespace LibraryManagementSystem
{
    public partial class book_stock : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN5RJF\\SQLEXPRESS12; Initial Catalog = library_management; Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapt;
        string book = "";
        string email = "";


        public book_stock()
        {
            InitializeComponent();
        }

        private void book_stock_Load(object sender, EventArgs e)
        {
            try
            {

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "allBookInfo";

                //  cmd = new SqlCommand("select * from book_info",con);

                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt; 


            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            dataGridView2.Visible = true;
            book = dataGridView1.SelectedCells[1].Value.ToString();
          
            try
            {
                cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "particularBookDetails";
      
                cmd.Parameters.Add("@bookName", SqlDbType.VarChar).Value = book.ToString();
                cmd.Parameters.Add("@returnDate", SqlDbType.VarChar).Value = "";

                // cmd = new SqlCommand("select * from book_issue_detail where book_name = '" + book.ToString() + "' and return_date =''", con);

                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                dataGridView2.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void search_text_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
    
                cmd = new SqlCommand("select * from book_info where name like ('%"+ search_text.Text+"%')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            email = dataGridView2.SelectedCells[5].Value.ToString();
            email_text.Text = email.ToString();
        }

        private void email_click(object sender, EventArgs e)
        {
            try { 
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("naveedraza2907@gmail.com", "madanichannel");
            MailMessage mail = new MailMessage("naveeddraza2907@gmail.com", email_text.Text, "Reinder to return book", content_text.Text);
            mail.Priority = MailPriority.High;
            smtp.Send(mail);
            MessageBox.Show("Mail delivered succesfully.");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
