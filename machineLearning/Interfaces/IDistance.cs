using System;
using System.Collections.Generic;
using System.Text;

namespace machineLearning.Interfaces
{
    interface IDistance
    {
        Result Between(int[] a, int[] b);
    }

    public class Distance : IDistance
    {
        public Result Between(int[] a, int[] b)
        {
            double distance = 0;
            var number = a[0];
            if (a.Length != b.Length)
            {
                throw new Exception("Wrong image size!");
            }
            else
            {
                for(int i = 1; i < a.Length; i++)
                {
                    distance = +Math.Pow(a[i] - b[i], 2);
                }
            }
            return new Result
            {
                Number = number,
                Distance = Math.Sqrt(distance)
            };
           
        }
    }
}
