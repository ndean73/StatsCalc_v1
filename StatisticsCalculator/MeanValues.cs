using System;
using System.Collections.Generic;
using System.Text;
using StatsOperations;

namespace StatisticsCalculator
{
    public interface ImeanValues 
    {

        public double meanv(double[] a);
    }
    public class MeanValues:ImeanValues
    {

        public double meanv(double[] a) {

           return Mean.mean(a);


        }
    }
}
