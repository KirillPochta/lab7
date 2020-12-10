using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab5100
{
    class film:Exception
    {
        public film()
        {

        }
        public string name;
        public int release;
        #region lb7
        public double Times_of_film
        {
            get { return strct.times_of_film; }
            set
            {
                if (value > 4.5 || value < 1)
                {
                    throw new filmException("time of film con not be lower then 30 min and hiegher then 4.5h");
                }
                else
                {
                    strct.times_of_film = value;
                }
            }
        }
        #endregion
        public filmslb6 strct = new filmslb6(); 
        
        public film(string name_of_film, int year_of_release, double Times_of_film,int count_of_adverts)
        {
            
                
                strct.name_of_film = name_of_film;
                strct.year_of_release = year_of_release;
                this.Times_of_film = Times_of_film;
                strct.count_of_adverts = count_of_adverts;
            

           
           
        }
        //public film(string name, int release, int times_of_film,int count_of_adverts, int a)
        //{
        //    this.name = name;
        //    this.release = release;
        //    this.times_of_film = times_of_film;
        //    strct.count_of_adverts = count_of_adverts;
        //}
             public override string ToString()
        {
            return $"name  {name}, release {release}, release{release}";
        }

        
        
    }
}
