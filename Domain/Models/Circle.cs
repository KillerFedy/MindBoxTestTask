using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Circle(double radius) : IMathFigure
    {
        public double GetSquare()
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
