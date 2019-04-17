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
using System.IO;

namespace LibraryManagementSystem
{
    public partial class add_student : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=desktop-uqn5rjf\\sqlexpress12; Initial Catalog=library_management; Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapt;
        string imgLoc = "";

        public add_student()
        {
            InitializeComponent();
        }

        private void browse_click(object sender, EventArgs e)
        {
            try { 

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|BMP Files (*.bmp)|*.bmp|GIF Files (*.gif)|*.gif|All Files(*.*)|*.*";
            dlg.Title = "Select student picture.";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                pictureBox1.ImageLocation = imgLoc;
            }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(name_text.Text != "" && enrolment_text.Text != "" && department_text.Text != "" && semester_text.Text != "" && contact_text.Text != "" && email_text.Text != "" && imgLoc != "")
                { 
                byte[] img = null;
                FileStream  fs= new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();

                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "addStudent";

                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name_text.Text;
                    cmd.Parameters.Add("@enrolment", SqlDbType.VarChar).Value = enrolment_text.Text;
                    cmd.Parameters.Add("@department", SqlDbType.VarChar).Value = department_text.Text;
                    cmd.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester_text.Text;
                    cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = contact_text.Text;
                    cmd.Parameters.Add("@image", SqlDbType.Image).Value = img;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email_text.Text;

                   // cmd = new SqlCommand("insert into student_info (name, enrolment_no, department, semester, contact_no, email, image) Values('"+ name_text.Text+ "','" + enrolment_text.Text + "','" + department_text.Text + "','" + semester_text.Text + "','" + contact_text.Text + "','" + email_text.Text + "', @img)", conn);


                  

                    conn.Open();

                    cmd.ExecuteNonQuery();
                conn.Close();

                    MessageBox.Show("Record added succesfully."); 

                }

                else
                {
                    MessageBox.Show("Please fill all the details.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        private void add_student_Load(object sender, EventArgs e)
        {

        }
    }
}
