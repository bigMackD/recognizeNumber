using System;
using System.Collections.Generic;
using System.Text;

namespace machineLearning.Interfaces
{
    interface IDistance
    {
        Result Between(Record a, Record b);
    }

    public class Distance : IDistance
    {
        public Result Between(Record a, Record b)
        {
            double distance = 0;
            var number = a.Number;
            if (a.Pixels.Length != b.Pixels.Length)
            {
                throw new Exception("Wrong image size!");
            }
            else
            {
                for(int i = 1; i < a.Pixels.Length; i++)
                {
                    distance = +Math.Pow(a.Pixels[i] - b.Pixels[i], 2);
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
