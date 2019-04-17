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
    public partial class edit_student : Form
    {

        SqlConnection con = new SqlConnection("Data Source=desktop-uqn5rjf\\sqlexpress12; Initial Catalog=library_management; Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        string imgLoc = "";
        int i = 0;
        int id;
        Bitmap img;

        public edit_student()
        {
            InitializeComponent();
        }



        private void edit_student_Load(object sender, EventArgs e)
        {
           

            try
            {
                cmd = new SqlCommand();


                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "allStudents";

                //cmd = new SqlCommand("select * from student_info", con);

                con.Open();

                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);

                DataTable dt1 = dt.Copy();
                dt1.Columns.Remove("image");
                dataGridView1.DataSource = dt1;



                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();

                imageCol.HeaderText = "Image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dataGridView1.Columns.Add(imageCol);


                foreach (DataRow dr in dt.Rows)
                {

                    img = new Bitmap(new MemoryStream((byte[])dr["image"]));

                    //TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                    //img = (Bitmap)tc.ConvertFrom(dr["image"]);

                    dataGridView1.Rows[i].Cells[7].Value = img;
                    dataGridView1.Rows[i].Height = 100;
                    i = i + 1;
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

        private void dataGridView1_recordClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;

            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
          //  MessageBox.Show(id.ToString() + imgLoc);
            name_text.Text = dataGridView1.SelectedCells[1].Value.ToString();
            enrolment_text.Text = dataGridView1.SelectedCells[2].Value.ToString();
            department_text.Text = dataGridView1.SelectedCells[3].Value.ToString();
            semester_text.Text = dataGridView1.SelectedCells[4].Value.ToString();
            contact_text.Text = dataGridView1.SelectedCells[5].Value.ToString();
            email_text.Text = dataGridView1.SelectedCells[6].Value.ToString();
            // pictureBox1.Image = new Bitmap(new MemoryStream(dataGridView1.SelectedCells[7].Value)); 

        }



        private void browse_click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|BMP Files (*.bmp)|*.bmp|GIF Files (*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Select student picture.";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;
                }

                else
                {
                    MessageBox.Show("Please select any picture.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void update_click(object sender, EventArgs e)
        {
          
            try
            {
               

                if (name_text.Text != "" && enrolment_text.Text != "" && department_text.Text != "" && semester_text.Text != "" && contact_text.Text != "" && email_text.Text != "" && imgLoc != "")
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();


                    cmd = new SqlCommand();


                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "editStudent";


                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name_text.Text;
                    cmd.Parameters.Add("@enrolment", SqlDbType.VarChar).Value = enrolment_text.Text;
                    cmd.Parameters.Add("@department", SqlDbType.VarChar).Value = department_text.Text;
                    cmd.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester_text.Text;
                    cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = contact_text.Text;
                    cmd.Parameters.Add("@image", SqlDbType.Image).Value = img;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email_text.Text;



                 //   cmd = new SqlCommand("update student_info set name = '" + name_text.Text + "' , enrolment_no = '" + enrolment_text.Text + "', department = '" + department_text.Text + "', semester = '" + semester_text.Text + "', contact_no = '" + contact_text.Text + "', email = '" + email_text.Text + "', image = @img  where id ='"+ id +"' ", con);


                   

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record updated succesfully.");
                    panel1.Visible = false;
                    con.Close();

                    displayData();
                   

                }

                else
                {
                    MessageBox.Show("Please fill all the details.");
                }
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
                cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "allStudents";

                //cmd = new SqlCommand("select * from student_info", con);
                con.Open();

                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);

                DataTable dt1 = dt.Copy();
                dt1.Columns.Remove("image");
                dataGridView1.DataSource = dt1;



                //DataGridViewImageColumn imageCol = new DataGridViewImageColumn();

                //imageCol.HeaderText = "Image";
                //imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                //imageCol.Width = 100;
                //dataGridView1.Columns.Add(imageCol);


                foreach (DataRow dr in dt.Rows)
                {

                    img = new Bitmap(new MemoryStream((byte[])dr["image"]));

                    //TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                    //img = (Bitmap)tc.ConvertFrom(dr["image"]);

                    dataGridView1.Rows[i].Cells[7].Value = img;
                    dataGridView1.Rows[i].Height = 100;
                    i = i + 1;
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


    }
}
