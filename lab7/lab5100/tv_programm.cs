using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5100
{
    class tv_programm: film
    {
        public string name_of_programm;
        public string name_of_reader;
        public tv_programm(string name_of_film, int year_of_release, int times_of_film, int count_of_adverts)
        {
            strct.name_of_film = name_of_film;
            strct.year_of_release = year_of_release;
            strct.times_of_film = times_of_film;
            strct.count_of_adverts = count_of_adverts;

        }
        public tv_programm(string name_of_programm, string name_of_reader)
        {
            this.name_of_programm = name_of_programm;
            this.name_of_reader = name_of_reader;            
        }
        public override string ToString()
        {
            return $"name_of_programm  {name_of_programm}, name_of_reader {name_of_reader}";
        }
    }
}
