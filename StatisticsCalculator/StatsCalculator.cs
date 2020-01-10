using System;
using IBasicCalculator;
using StatisticsCalculator;

namespace StatisticsCalculator
{
    public interface IStatsCalculator
    {

        public double Mean(double[] values);
    }
    public class StatsCalculator: ImeanValues
    {
        MeanValues mv = new MeanValues();
        public double Mean(double[] values) {

           return mv.meanv(values);
        }

        double ImeanValues.meanv(double[] a)
        {
            throw new NotImplementedException();
        }
    }
}
