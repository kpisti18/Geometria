using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Kor
    {
        double sugar;
        double atmero;

        public double Sugar
        {
            get => sugar;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"{value}-val/vel nem szerkezthető a kör!!!"); //kívül esne az argumentumból, 0-nál kisebb értékkel nem tudjuk elvégezni a körrel a feladatokat
                }
                else
                {
                    sugar = value;
                }
            }
        }
   
        public double Atmero { get => sugar * 2; }

        public double Kerulet()
        {
            return sugar * 2 * Math.PI;
        }

        public double Terulet()
        {
            return sugar * sugar * Math.PI;
        }
    }
}
