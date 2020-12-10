using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5100
{
    class multfilm: Exception, Iadvert
    {
        public string name;
        public string main_cherecter;
        public string antogonist;
        public int average_number_of_film;
        public string screenwriter;
        public int badZeroGoodOne;
        #region lb 7
        public int Average_number_of_film
        {
            get { return average_number_of_film; }
            set
            {
                if (value<7 )
                {
                    throw new multfilmException($"multfilm cannot be bad {value}<7:( ");
                }
                else average_number_of_film = value;
            }
        }
        #endregion
        public multfilm(string name,string main_cherecter,string antogonist,int Average_number_of_film)
        {
            this.name = name;
            this.main_cherecter = main_cherecter;
            this.antogonist = antogonist;
            this.Average_number_of_film = Average_number_of_film;
        }
        public  void name_of_reader()
        {
            Console.WriteLine("Этот метод теперь делает что-то дургое");
        }

        public void name_of_spere()
        {
            Console.WriteLine("реализованный метод интерфейса");
        }
        
        public void info()
        {
            Console.WriteLine($"name{name},main_cherecter{main_cherecter},antogonist{antogonist},averege_number_of_film{average_number_of_film},screenwrtier{screenwriter}");
        }
        public override string ToString()
        {
            return $"name  {name}, main_cherecter {main_cherecter}, antogonist{antogonist},  average_number_of_film {average_number_of_film}";
        }
        #region lb7

        #endregion
    }
}
