namespace Butterworth_Filters
{
    public class BandpassFilterButterworthImplementation
    {
        protected LowpassFilterButterworthImplementation lowpassFilter;
        protected HighpassFilterButterworthImplementation highpassFilter;

        public BandpassFilterButterworthImplementation(double bottomFrequencyHz, double topFrequencyHz, int numSections, double Fs)
        {
            lowpassFilter = new LowpassFilterButterworthImplementation(topFrequencyHz, numSections, Fs);
            highpassFilter = new HighpassFilterButterworthImplementation(bottomFrequencyHz, numSections, Fs);
        }

        public double Compute(double input)
        {
            // compute the result as the cascade of the highpass and lowpass filters
            return highpassFilter.Compute(lowpassFilter.Compute(input));
        }
    }
}
