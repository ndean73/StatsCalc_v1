using Helper;
using MathOperations;

namespace StatsOperations
{
    public class Mean
    {

        public static double mean(double[] ArrayValues)
        {


            //int Sum = Addition.SumArrayValues(ArrayValues);

            int Sum = 0;

            foreach (int i in ArrayValues)
            {
                Sum = Sum + i;
            }

            int ValueCount = HelperClass.ArrayLenth(ArrayValues);

            int Value = Sum / ValueCount;
            return Value;

        }

    }
}
