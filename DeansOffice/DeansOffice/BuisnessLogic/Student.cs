using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice
{
    public class Student
    {

        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string mail { get; set; }
        public string obywatelstwo { get; set; }
        public string miasto { get; set; }
        public string dataUr { get; set; }

        public int nrIndeksu { get; set; }
        public int nrPaszporu { get; set; }

        public long pesel { get; set; }
        public long tel { get; set; }

        public Student()
        {

            //default values 
            this.miasto = "Warszawa";
            this.obywatelstwo = "polskie";
        }

    }
}
