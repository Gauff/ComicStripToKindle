using System;
using System.Threading.Tasks;

namespace ComicStripToKindle
{
    public static class DegreeOfParallelism
    {

        static ParallelOptions Build(int processorCount)
        {
            return new ParallelOptions
            {
                MaxDegreeOfParallelism = processorCount
            };
        }


        public static ParallelOptions AllProcessorsButOne
        {
            get
            {
                if (Environment.ProcessorCount == 1)
                    return Min;

                return Build(Environment.ProcessorCount - 1);
            }

        }
        public static ParallelOptions GetByPercentage(int percentage)
        {
            return Build(Convert.ToInt32(Math.Ceiling((Environment.ProcessorCount * ((double)percentage / 100)) * 1.0)));
        }
        public static ParallelOptions Max
        {
            get
            {
                return Build(Environment.ProcessorCount);
            }
        }
        public static ParallelOptions Min
        {
            get
            {
                return Build(1);
            }
        }
    }
}
