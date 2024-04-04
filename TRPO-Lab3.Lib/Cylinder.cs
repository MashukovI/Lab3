using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Lab3.Lib
{
    public class Cylinder
    {
        const double pi = Math.PI;
        public double SurfArea(double r, double h)
        {
            if (r < 0 || h < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return 2 * pi * r * (h + r);
            }
            
        }
    }
}
