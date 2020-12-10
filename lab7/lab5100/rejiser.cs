using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lab5100
{
    abstract class rejiser
    {
        public string name;
        public string Laname;
        public int borns_year;
        public string name_of_sphere;

        public virtual void info()
        {
            Console.WriteLine("1");
        }
        public  void name_of_reader()
        {
            Console.WriteLine("Выводим имя ведущего");
        }

        public void Analyze()
        {
            Console.WriteLine("уже реализованный метод");
        }
       
        public void New()
        {
            Console.WriteLine("уже реализованный метод");

        }
        public void GetInfo()
        {
            Console.WriteLine("уже реализованный метод");

        }
        public override string ToString()
        {
            return $"name  {name}, Laname {Laname}, borns_year{borns_year},  name_of_sphere {name_of_sphere}";
        }

    }
}
