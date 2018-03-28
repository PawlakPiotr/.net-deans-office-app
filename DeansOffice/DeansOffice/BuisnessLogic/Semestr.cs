using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.BuisnessLogic
{
    class Semestr
    {
        public int idSemestru { get; set; }
        public string nazwaSemestru { get; set; }

        public Semestr(int id)
        {
            idSemestru = id;

            if (idSemestru == 1)
            {
                var currentYear = DateTime.Now.Year;
                nazwaSemestru = GetTermName("zimowy", year: currentYear);
            }
        }


        private static string GetTermName(string s, int year)
        {
            int nextYear = year + 1;
            string yr = nextYear.ToString();

            return "semestr " + s + " " + year + "/" + yr.Substring(1);
        }

    }
}
