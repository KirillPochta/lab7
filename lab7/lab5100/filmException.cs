using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab5100
{
    class filmException : Exception
    {
        public filmException(string message) : base(message)
        {
        }

        public filmException(string message,int times_of_film) : base(message)
        {
            Console.WriteLine($"you entered bad time of film");
        }
    }
}
