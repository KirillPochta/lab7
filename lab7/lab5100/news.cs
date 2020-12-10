using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5100
{
    class news: Exception
    {
        public string name_of_programm;
        #region lb7
        public string nameOfReader;
        public int broadCastTime;

        public int BroadCastTime
        {
            get { return broadCastTime; }
            set
            {
                if (value > 2000 || value < 900)
                {
                    throw new newsException("time of translation cannot be lower then 9:00 and hiegher then 20:00");
                }
                else broadCastTime = value;
            }
        }
        #endregion
        public news()
        {
        }

        public news(string name_of_programm, int BroadCastTime, string nameOfReader)
        {
            this.name_of_programm = name_of_programm;
            this.BroadCastTime =BroadCastTime;
            this.nameOfReader = nameOfReader;
           
        }

        public void info()
        {
            throw new NotImplementedException();
        }

        public void name_of_spere()
        {
            throw new NotImplementedException();
        }

        //public override string ToString()
        //{
        //    return $"name_of_programm  {name_of_programm}, name_of_reader {name_of_reader}";
        //}
        #region lb7

        #endregion
        


    }
}
