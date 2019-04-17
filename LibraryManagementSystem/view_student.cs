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
    public partial class view_student : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQN5RJF\\SQLEXPRESS12; Initial Catalog = library_management; Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        int i = 0;
        int count = 0;

        public view_student()
        {
            InitializeComponent();
        }

        private void view_student_Load(object sender, EventArgs e)
        {
            try
            {
               // cmd = new SqlCommand("select * from student_info", con);

                cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "allStudents";



                con.Open();

                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);

                DataTable dt1 = dt.Copy();
                dt1.Columns.Remove("image");
                dataGridView1.DataSource = dt1;

                Bitmap img;

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

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
                


        }

        private void search_keyup(object sender, KeyEventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();


                cmd = new SqlCommand("select * from student_info where name like('%"+ search_text.Text +"%')", con);
                con.Open();

                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                DataTable dt1 = dt.Copy();
                dt1.Columns.Remove("image");
                dataGridView1.DataSource = dt1;

                Bitmap img;

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
                    i= i + 1;
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

            if (count == 0)
            {
                MessageBox.Show("No record found.");

            }

        }
    }
}
