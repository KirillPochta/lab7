using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5100
{
    class newsException : Exception
    {
        public newsException(string message) : base(message)
        {
        }

        public newsException(string message, int broadCastTime) : base(message)
        {
            Console.WriteLine($"you entered  time of translation {broadCastTime}");
        }
    }
}
