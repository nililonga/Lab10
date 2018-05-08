using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10CircleClass
{
    class Circle

    {
        private string FormatNumber (double x);

        private Member radius;

        public double Radius { get; set; }


        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            double CalCirc = (2 * Math.PI * Radius);
            return Radius;
        }
        public string CalculateFormattedArea()
        {
            string CFA = Convert.ToString(2 * Math.PI * Radius);
            return CFA;
        }
        public string CalculateArea()
        {
            string CFA = Convert.ToString(2 * Math.PI * Radius);
            return CFA;
        }
        public double CalculateFormattedCircumference()
        {
            return Math.PI * Radius * Radius;
        }
        private string FormatNumber (double x)
        {

        }
    }

    internal class Member
    {
    }
}
       
        








        




    

