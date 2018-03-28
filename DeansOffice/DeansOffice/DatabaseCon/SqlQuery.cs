using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice
{
    public class SqlQuery
    {
        public static string showStudents = GetQuery("select * from student;");
        public static string getNameOfTerm = GetQuery("select nazwaSemestru from semestr;");
        public static string getFirstTermName = GetQuery("select * from student inner join student_semestr on student.nrIndeksu = student_semestr.nrIndeksu where student_semestr.idSemestru = 1");
        public static string getSecondTermName = GetQuery("select * from student inner join student_semestr on student.nrIndeksu = student_semestr.nrIndeksu where student_semestr.idSemestru = 2");
        public static string deleteData = GetQuery("delete from student where");

        public static string nrIndeksu_search = GetSearchQuery("student", "nrIndeksu", MainForm.textBox1.Text);
        public static string nazwisko_search = GetSearchQuery("student", "nazwisko", MainForm.textBox1.Text);


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
