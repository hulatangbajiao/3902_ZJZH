using System;

namespace Team4_LegendOfZelda.Random_Number_Generator
{
    public class RandomIntGenerator
    {
        private Random rand;
        private int seed;

        private static RandomIntGenerator instance = new RandomIntGenerator();

        public static RandomIntGenerator Instance
        {
            get
            {
                return instance;
            }
        }

        private RandomIntGenerator()
        {
            seed = 0;
            rand = new Random(seed);
        }

        public void Seed(int newSeed)
        {
            seed = newSeed;
        }

        public int Next(int minValue, int maxValue)
        {
            return rand.Next(minValue, maxValue + 1);
        }

        public void Reset()
        {
            rand = new Random(seed);
        }
    }
}