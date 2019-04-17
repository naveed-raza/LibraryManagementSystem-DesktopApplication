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
    public partial class return_book : Form
    {
        SqlConnection con = new SqlConnection("Data Source=desktop-uqn5rjf\\sqlexpress12; Initial Catalog=library_management; Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int id;

        public return_book()
        {
            InitializeComponent();
        }


        private void search_click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            displayData();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;

            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            name_text.Text = dataGridView1.SelectedCells[7].Value.ToString();
            issue_date_text.Text = Convert.ToString(dataGridView1.SelectedCells[8].Value.ToString());
        }



        private void return_btn_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateReturnDate";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@returnDate", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToShortDateString();





           // cmd = new SqlCommand("update book_issue_detail set return_date = '" + dateTimePicker1.Value.ToShortDateString() +"' where id = '"+id+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book has been returned successfully.");

            SqlCommand cmd1 = new SqlCommand("update book_info set available_quantity = available_quantity + 1 where name = '" + name_text.Text + "' ", con);
            cmd1.ExecuteNonQuery();

            con.Close();

            displayData();
          




        }




        private void displayData()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "returnDetails";

                cmd.Parameters.Add("@enrolment", SqlDbType.VarChar).Value = enrolment_text.Text;
                cmd.Parameters.Add("@returnDate", SqlDbType.VarChar).Value = "";

                // cmd = new SqlCommand("select * from book_issue_detail where student_enrolment_no = '" + enrolment_text.Text + "' and return_date = ''", con);

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




    }
}
