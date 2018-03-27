using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice
{
    public class SqlServerDB
    {
        private List<Student> std;
        private const string dbConncection = "Data Source=db-mssql;Initial Catalog=s15182;Integrated Security=True";

        private static string showStudents = "select * from student;";
        private static string getNameOfTerm = "select nazwaSemestru from semestr;";

        public static void LoadData()
        {

            using (var con = new SqlConnection(dbConncection))
            {
                con.Open();
                var com = new SqlCommand();

                com.Connection = con;
                com.CommandText = showStudents;
                SqlDataAdapter sqd = new SqlDataAdapter(com);

                DataTable dt = new DataTable();
                sqd.Fill(dt);
             
                MainForm.StudentsDataGridView.DataSource = dt;


                com.Dispose();
            }

        }
        public static void LoadCurrentTerm()
        {
            using (var con = new SqlConnection(dbConncection))
            {
                con.Open();
                var com = new SqlCommand();

                com.Connection = con;
                com.CommandText = getNameOfTerm;

                using (var dr = com.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string s = dr["nazwaSemestru"].ToString();
                        MainForm.SemesterComboBox.Items.Add(s);
                    }
                }

                com.Dispose();
            }
        }

        public static void LoadTerm()
        {
            using (var con = new SqlConnection(dbConncection))
            {
                con.Open();

                if (MainForm.SemesterComboBox.Text == "semestr letni 2017/18")
                {

                    SqlDataAdapter sda = new SqlDataAdapter("select * from student inner join student_semestr on student.nrIndeksu = student_semestr.nrIndeksu where student_semestr.idSemestru = 1", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MainForm.StudentsDataGridView.DataSource = dt;

                }
                else if (MainForm.SemesterComboBox.Text.Contains("zimowy 2017/18"))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from student inner join student_semestr on student.nrIndeksu = student_semestr.nrIndeksu where student_semestr.idSemestru = 2", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MainForm.StudentsDataGridView.DataSource = dt;

                }
                else if (string.IsNullOrEmpty(MainForm.SemesterComboBox.Text))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from student", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MainForm.StudentsDataGridView.DataSource = dt;
                }
            }
        }

        public static void DeleteStudentFromServer()
        {
            using (var con = new SqlConnection(dbConncection))
            {
                con.Open();
                var com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "delete from student where nrIndeksu=@nrIndx";


                var index = Convert.ToInt32(MainForm.StudentsDataGridView.CurrentRow.Cells[0].Value);

                com.Parameters.Add("@nrIndx", SqlDbType.Int).Value = index;
                com.ExecuteNonQuery();
                com.Dispose();
            }
        }

        public static void SearchEngine()
        {
            using (var con = new SqlConnection(dbConncection))
            {
                con.Open();

                if (MainForm.StudentNumberCheckBox.Checked)
                {


                    SqlDataAdapter sda = new SqlDataAdapter("select * from student where nrIndeksu like '" + MainForm.textBox1.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MainForm.StudentsDataGridView.DataSource = dt;

                }
                else if (MainForm.LastNameCheckBox.Checked)
                {

                    SqlDataAdapter sda = new SqlDataAdapter("select * from student where nazwisko like '" + MainForm.textBox1.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MainForm.StudentsDataGridView.DataSource = dt;
                }


                if (string.IsNullOrWhiteSpace(MainForm.textBox1.Text))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from student", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MainForm.StudentsDataGridView.DataSource = dt;
                }

            }
        }
    }
}
