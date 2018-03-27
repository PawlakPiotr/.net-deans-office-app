using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeansOffice
{
    public partial class StudentDialog : Form
    {
        public StudentDialog()
        {
            InitializeComponent();
        }


        private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection("Data Source=db-mssql;Initial Catalog=s15182;Integrated Security=True"))
            {
                con.Open();

                var com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "insert into student (nrIndeksu, imie, nazwisko, mail, tel, pesel) " +
                    "values (" +
                    "@nrIndx, @imie, @nazwisko, @mail, @tel, @pesel)";

                var addedStud = new Student();
                addedStud.tel = long.Parse(TelephoneTextBox.Text);
                addedStud.pesel = long.Parse(PeselTextBox.Text);

                com.Parameters.Add("@nrIndx", SqlDbType.Int).Value = Int32.Parse(IndexNumberTextBox.Text);
                com.Parameters.Add("@imie", SqlDbType.NVarChar).Value = FirstNameTextBox.Text;
                com.Parameters.Add("@nazwisko", SqlDbType.NVarChar).Value = LastNameTextBox.Text;
                com.Parameters.Add("@mail", SqlDbType.NVarChar).Value = EmailTextBox.Text;
                com.Parameters.Add("@tel", SqlDbType.BigInt).Value = addedStud.tel;
                com.Parameters.Add("@pesel", SqlDbType.BigInt).Value = addedStud.pesel;
                

                com.ExecuteNonQuery();
                com.Dispose();

                con.Close();
            }

            using (var con = new SqlConnection("Data Source=db-mssql;Initial Catalog=s15182;Integrated Security=True"))
            {
                con.Open();
                var com = new SqlCommand();

                com.Connection = con;
                com.CommandText = "select * from student;";
                SqlDataAdapter sqd = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqd.Fill(dt);
                MainForm.StudentsDataGridView.DataSource = dt;

               
                com.Dispose();
            }

            this.Close();
        }
    }
}
