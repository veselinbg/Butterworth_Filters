namespace Butterworth_Filters
{
    public class FIRFilterImplementation
    {
        protected double[] z;
        public FIRFilterImplementation(int order)
        {
            z = new double[order];
        }

        public double Compute(double input, double[] a)
        {
            // computes y(t) = a0*x(t) + a1*x(t-1) + a2*x(t-2) + ... an*x(t-n)
            double result = 0;

            for (int t = a.Length - 1; t >= 0; t--)
            {
                if (t > 0) z[t] = z[t - 1];
                else z[t] = input;
                result += a[t] * z[t];
            }
            return result;
        }
    }
}
