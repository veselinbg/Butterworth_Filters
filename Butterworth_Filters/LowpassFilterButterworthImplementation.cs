using System;

namespace Butterworth_Filters
{
    public class LowpassFilterButterworthImplementation
    {
        protected LowpassFilterButterworthSection[] section;

        public LowpassFilterButterworthImplementation(double cutoffFrequencyHz, int numSections, double Fs)
        {
            section = new LowpassFilterButterworthSection[numSections];
            for (int i = 0; i < numSections; i++)
            {
                section[i] = new LowpassFilterButterworthSection(cutoffFrequencyHz, i + 1, numSections * 2, Fs);
            }
        }
        public double Compute(double input)
        {
            double output = input;
            for (int i = 0; i < section.Length; i++)
            {
                output = section[i].Compute(output);
            }
            return output;
        }
    }

    public class LowpassFilterButterworthSection
    {
        protected FIRFilterImplementation firFilter = new FIRFilterImplementation(3);
        protected IIRFilterImplementation iirFilter = new IIRFilterImplementation(2);
        protected double[] a = new double[3];
        protected double[] b = new double[2];
        protected double gain;

        public LowpassFilterButterworthSection(double cutoffFrequencyHz, double k, double n, double Fs)
        {
            // compute the fixed filter coefficients
            double omegac = 2.0 * Fs * Math.Tan(Math.PI * cutoffFrequencyHz / Fs);
            double zeta = -Math.Cos(Math.PI * (2.0 * k + n - 1.0) / (2.0 * n));

            // fir section
            a[0] = omegac * omegac;
            a[1] = 2.0 * omegac * omegac;
            a[2] = omegac * omegac;

            //iir section
            //normalize coefficients so that b0 = 1, 
            //and higher-order coefficients are scaled and negated
            double b0 = (4.0 * Fs * Fs) + (4.0 * Fs * zeta * omegac) + (omegac * omegac);
            b[0] = ((2.0 * omegac * omegac) - (8.0 * Fs * Fs)) / (-b0);
            b[1] = ((4.0 * Fs * Fs) - (4.0 * Fs * zeta * omegac) + (omegac * omegac)) / (-b0);
            gain = 1.0 / b0;
        }

        public double Compute(double input)
        {
            // compute the result as the cascade of the fir and iir filters
            return iirFilter.Compute(firFilter.Compute(gain * input, a), b);
        }
    }
}




