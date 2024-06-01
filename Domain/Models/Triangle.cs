using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Triangle(double a, double b, double c) : IMathFigure
    {
        public double GetSquare()
        {
            var halfPerimetr = (a + b + c) / 2;
            var area = Math.Sqrt(halfPerimetr * (halfPerimetr - a) * (halfPerimetr - b) * 
                (halfPerimetr - c));
            return area;
        }

        public bool IsTriangleRectangular()
        {
            List<double> sides = [a, b, c];
            sides.Sort();

            var side1 = sides[0];
            var side2 = sides[1];
            var hypotenuse = sides[2];
            return Math.Pow(hypotenuse, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2);
        }
    }
}
