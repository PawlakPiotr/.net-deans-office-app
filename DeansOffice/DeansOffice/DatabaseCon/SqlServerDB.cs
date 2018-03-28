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

        public static void LoadData()
        {

            using (var con = new SqlConnection(dbConncection))
            {
                con.Open();
                var com = new SqlCommand();

                com.Connection = con;
                com.CommandText = SqlQuery.showStudents;
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
                com.CommandText = SqlQuery.getNameOfTerm;

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

                    SqlDataAdapter sda = new SqlDataAdapter(SqlQuery.getFirstTermName, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MainForm.StudentsDataGridView.DataSource = dt;

                }
                else if (MainForm.SemesterComboBox.Text.Contains("zimowy 2017/18"))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(SqlQuery.getSecondTermName, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MainForm.StudentsDataGridView.DataSource = dt;

                }
                else if (string.IsNullOrEmpty(MainForm.SemesterComboBox.Text))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(SqlQuery.showStudents, con);
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
                com.CommandText = SqlQuery.deleteData + "nrIndeksu=@nrIndx";

                int firstCell = 0;
                var index = Convert.ToInt32(MainForm.StudentsDataGridView.CurrentRow.Cells[firstCell].Value);

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


                    SqlDataAdapter sda = new SqlDataAdapter(SqlQuery.nrIndeksu_search, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MainForm.StudentsDataGridView.DataSource = dt;

                }
                else if (MainForm.LastNameCheckBox.Checked)
                {

                    SqlDataAdapter sda = new SqlDataAdapter(SqlQuery.nazwisko_search, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MainForm.StudentsDataGridView.DataSource = dt;
                }


                if (string.IsNullOrWhiteSpace(MainForm.textBox1.Text))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(SqlQuery.showStudents, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MainForm.StudentsDataGridView.DataSource = dt;
                }

            }
        }

       

        private static string GetQuery(string qr)
        {
            return qr;
        }
        private static string GetSearchQuery(string from, string columnName, string value)
        {
            string select_qr = "select * from" + from;
            string where_condition = " where " + columnName + " like '";

            return select_qr + where_condition + MainForm.textBox1.Text + "';";
        }
    }
}
