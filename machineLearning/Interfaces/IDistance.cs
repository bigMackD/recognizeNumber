using System;
using System.Collections.Generic;
using System.Text;

namespace machineLearning.Interfaces
{
    interface IDistance
    {
        double Between(int[] a, int[] b);
    }

    public class Distance : IDistance
    {
        public double Between(int[] a, int[] b)
        {
            double distance = 0;
            if (a.Length != b.Length)
            {
                throw new Exception("Wrong image size!");
            }
            else
            {
                distance = Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2));
            }
            return distance;
        }
    }
}
