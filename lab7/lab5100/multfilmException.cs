using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5100
{
    class multfilmException : Exception
    {
        public multfilmException(string message) : base(message)
        {
        }
        public multfilmException(string message, int average_number_of_film) : base(message)
        {
            Console.WriteLine($"this film(1-good,0-bad) {average_number_of_film}");
        }
    }
}
