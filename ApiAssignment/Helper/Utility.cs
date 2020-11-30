using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAssignment.Helper
{
    public class Utility
    {

        public int randomInt()
        {
            Random rnd = new Random();
            return rnd.Next(100);
        }

        public double randomDouble()
        {
            Random rnd = new Random();
            double flt = rnd.NextDouble();
            return Math.Truncate(flt * 100) / 100;
        }

        public char randomCharacter()
        {
            Random rnd = new Random();
            double flt = rnd.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            return  Convert.ToChar(shift + 65);
        }

    }
}
