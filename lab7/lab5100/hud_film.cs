using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5100
{
    sealed class hud_film:film
    {
        public string name;
        public string main_cherecter;
        public string antogonist;
        public int average_number_of_film;
        public string screenwriter;
        public hud_film(string name_of_film, int year_of_release, int times_of_film, int count_of_adverts)
        {
            strct.name_of_film = name_of_film;
            strct.year_of_release = year_of_release;
            strct.times_of_film = times_of_film;
            strct.count_of_adverts = count_of_adverts;

        }
        public hud_film(string name, string main_cherecter, string antogonist, int average_number_of_film)
        {
            this.name = name;
            this.main_cherecter = main_cherecter;
            this.antogonist = antogonist;
            this.average_number_of_film = average_number_of_film;
            this.screenwriter = screenwriter;
        }
       
        public  override string ToString()
        {
            return $"name  {name}, main_cherecter {main_cherecter}  average_number_of_film {average_number_of_film}";
        }

    }
}
