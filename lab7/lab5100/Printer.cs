using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5100
{
    
    class Printer
    {
        virtual  public void IAmPrinting(object obj)
        {
            if(obj is multfilm) Console.WriteLine(obj.ToString());
            if(obj is hud_film) Console.WriteLine(obj.ToString());
            if(obj is film) Console.WriteLine(obj.ToString());
            if(obj is tv_programm) Console.WriteLine(obj.ToString());
            if(obj is news) Console.WriteLine(obj.ToString());
        }
    }
}
