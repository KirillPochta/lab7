using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5100
{
    class Class1:rejiser,Iadvert
    {
        public string name;
        public string main_cherecter;
        public string antogonist;

        public Class1(string name, string main_cherecter, string antogonist)
        {
            this.name = name;
            this.main_cherecter = main_cherecter;
            this.antogonist = antogonist;
        }
         void Iadvert.info()
        {
            Console.WriteLine("1");
        }
        public override void info()
        {
            Console.WriteLine("0");
        }

        public void name_of_spere()
        {
            throw new NotImplementedException();
        }
    }
}
