using System.Diagnostics.Metrics;

namespace HungryGame
{
    public static class Counters
    {
        public static Meter HungryMeter = new Meter("HungryHippo.Api", "1.0.0");

        public static Counter<int> JoinCounter = HungryMeter.CreateCounter<int>("join_counter");
    }
}
