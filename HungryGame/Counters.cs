using System.Diagnostics.Metrics;

namespace HungryGame
{
    public static class Counters
    {
        public static Meter meter = new Meter("HungryHippo.Api", "1.0.0");

        public static Counter<int> FirstCounter = meter.CreateCounter<int>("first-counter");
    }
}
