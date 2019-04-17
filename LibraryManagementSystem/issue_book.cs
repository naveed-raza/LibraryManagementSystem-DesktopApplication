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
    public partial class issue_book : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN5RJF\\SQLEXPRESS12; Initial Catalog = library_management; Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        int i = 0;
        int count = 0;
        int book = 0;


        public issue_book()
        {
            InitializeComponent();
        }

        private void search_click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "particularStudentdInfo";

                cmd.Parameters.Add("@enrolment", SqlDbType.VarChar).Value = enrolment_text.Text;


                //  cmd = new SqlCommand("select * from student_info where enrolment_no = '"+ enrolment_text.Text+"'", con);

                con.Open();

            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);

            count = Convert.ToInt32(dt.Rows.Count.ToString());

            if(count == 0)
                {
                    MessageBox.Show("No record found.");
                    std_name_text.Text = "";
                    department_text.Text = "";
                    semester_text.Text = "";
                    email_text.Text = "";
                    contact_text.Text = "";

                }

            else
                {

                foreach(DataRow dr in dt.Rows)
                     {
                        std_name_text.Text = dr["name"].ToString();
                        department_text.Text = dr["department"].ToString();
                        semester_text.Text = dr["semester"].ToString();
                        email_text.Text = dr["email"].ToString();
                        contact_text.Text = dr["contact_no"].ToString();

                      }
                }
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

        private void book_name_text_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {


                if (e.KeyCode != Keys.Enter)
                {
                    listBox1.Items.Clear();

                    cmd = new SqlCommand("select * from book_info where name like ('%" + book_name_text.Text + "%')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);

                    i = Convert.ToInt32(dt.Rows.Count.ToString());

                  //  MessageBox.Show(i.ToString());

                    if (i > 0)
                    {
                        listBox1.Visible = true;

                        foreach (DataRow dr in dt.Rows)
                        {
                            listBox1.Items.Add(dr["name"].ToString());
                        }
                    }


                }
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

        private void book_name_text_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            book_name_text.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                book_name_text.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
        }

        private void issue_click(object sender, EventArgs e)
        {

            check_quantity();

         
        }



        private void decrease_quantity()
        {
           SqlCommand cmd1 = new SqlCommand("update book_info set available_quantity= available_quantity - 1 where name = '"+book_name_text.Text +"'", con);
            cmd1.ExecuteNonQuery();
           
        }

        private void check_quantity()
        {
           // SqlCommand cmd2 = new SqlCommand("Select *from book_info where name = '" + book_name_text.Text + "'", con);

            SqlCommand cmd2 = new SqlCommand();

            cmd2.Connection = con;
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "checkQuantity";

            cmd2.Parameters.Add("@book_name", SqlDbType.VarChar).Value = book_name_text.Text;


            con.Open();
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter adapt2 = new SqlDataAdapter(cmd2);
            adapt2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                book = Convert.ToInt32(dr["available_quantity"].ToString());
            }

            if (book > 0)

            {
                try
                {

                    cmd = new SqlCommand();

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "addIssueDetails";

                    cmd.Parameters.Add("@std_name", SqlDbType.VarChar).Value = std_name_text.Text;
                    cmd.Parameters.Add("@std_enrolment", SqlDbType.VarChar).Value = enrolment_text.Text;
                    cmd.Parameters.Add("@std_department", SqlDbType.VarChar).Value = department_text.Text;
                    cmd.Parameters.Add("@std_semester", SqlDbType.VarChar).Value = semester_text.Text;
                    cmd.Parameters.Add("@std_email", SqlDbType.VarChar).Value = email_text.Text;
                    cmd.Parameters.Add("@std_contact", SqlDbType.VarChar).Value = contact_text.Text;
                    cmd.Parameters.Add("@book_name", SqlDbType.VarChar).Value = book_name_text.Text;
                    cmd.Parameters.Add("@issue_date", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToShortDateString();
                    cmd.Parameters.Add("@return_date", SqlDbType.VarChar).Value ="";
                   


                   // cmd = new SqlCommand("insert into book_issue_detail values ('" + std_name_text.Text + "','" + enrolment_text.Text + "','" + department_text.Text + "', '" + semester_text.Text + "','" + email_text.Text + "','" + contact_text.Text + "','" + book_name_text.Text + "', '" + dateTimePicker1.Value.ToShortDateString() + "', '')", con);
                    

                    cmd.ExecuteNonQuery();

                    decrease_quantity();

                    MessageBox.Show("Record entered successfully.");

                    std_name_text.Text = "";
                    department_text.Text = "";
                    semester_text.Text = "";
                    email_text.Text = "";
                    contact_text.Text = "";
                    book_name_text.Text = "";
                    enrolment_text.Text = "";


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

            else
            {

                MessageBox.Show("Book is not available.");
            }

        }
    }
}
