using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Haromszog
    {
        double aOldal;
        double bOldal;
        double cOldal;

        public double AOldal
        {
            get => aOldal;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"'a' oldal értéke: {value}-val/vel nem szerkezthető a háromszög!!!");
                }
                else
                {
                    aOldal = value;
                }
            }
        }
        public double BOldal
        {
            get => bOldal;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"'b' oldal értéke: {value}-val/vel nem szerkezthető a háromszög!!!");
                }
                else
                {
                    bOldal = value;
                }
            }
        }
        public double COldal
        {
            get => cOldal;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"'c' oldal értéke: {value}-val/vel nem szerkezthető a háromszög!!!");
                }
                else
                {
                    cOldal = value;
                }
            }
        }

        public Haromszog(double aOldal, double bOldal, double cOldal)
        {
            AOldal = aOldal;
            BOldal = bOldal;
            COldal = cOldal;
        }

        public string SzerkeszthetoE()
        {
            if (aOldal + bOldal > cOldal && aOldal + cOldal > bOldal && bOldal + cOldal > aOldal)
            {
                return "A háromszög szerkeszthető";
            }
            else
            {
                return "A háromszög nem szerkeszthető";
            }
        }
    }
}
