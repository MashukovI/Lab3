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
            return (2 * pi * r * (h + r));
        }
    }
}
