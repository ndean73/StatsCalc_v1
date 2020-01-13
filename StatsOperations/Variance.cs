using System;
using System.Collections.Generic;
using System.Text;
using Helper;

namespace StatsOperations
{
    public class Variance
    {
     
        public static double variance(double[] ArrayValues)
        {

            double  meanvalue=Mean.mean(ArrayValues);
            //int Sum = Addition.SumArrayValues(ArrayValues);

            double diff = 0;
            double varvalue = 0;

            foreach (double i in ArrayValues)
            {
                diff = meanvalue - i;
                diff = Math.Pow(diff,2);
                varvalue = varvalue + diff;
            }


            int ValueCount = HelperClass.ArrayLenth(ArrayValues);
            varvalue = varvalue/ ValueCount;
            return varvalue;

        }

    }
}
