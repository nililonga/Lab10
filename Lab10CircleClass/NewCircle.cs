using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10CircleClass
{
    class NewCircle
    {
        //private string FormatNumber(double x);
      
        private double radius;

        public double Radius { get; set; }
        public double Radius1 { get => radius; set => radius = value; }


        public NewCircle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            double CalCirc = (2 * Math.PI * Radius);
            return Radius;
        }
        public double CalculateArea()
        {
            double CA = (Math.PI * (Radius * Radius));
            return CA ;
        }

        public double CalculateFormattedArea()
        {
            double CFA = Convert.ToDouble(CalculateArea().ToString("F"));
            return CFA;
        }
        public double CalculateFormattedCircumference()
        {
            double CFC = Convert.ToDouble(Math.PI * Radius * Radius);
            return CFC;


        }
        // private string FormatNumber(double x)

    }
}

