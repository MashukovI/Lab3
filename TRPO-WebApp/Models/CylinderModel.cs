using System;
using System.ComponentModel.DataAnnotations;
using TRPO_Lab3.Lib;

namespace TRPO_WebApp.Models
{
    public class CylinderModel
    {
        [Range(0, double.MaxValue, ErrorMessage = "Радиус должен быть больше или равен 0")]
        public double Radius { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Высота должна быть больше или равна 0")]
        public double Height { get; set; }

        public double GetSurfaceArea()
        {
            Cylinder a = new Cylinder();
            return a.SurfArea(Radius, Height);
        }
    }
}
