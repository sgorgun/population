using System;

namespace PopulationTask
{
    public static class Population
    {
        /// <summary>
        /// Calculates the count of years which the town need to see its population greater or equal to currentPopulation inhabitants.
        /// </summary>
        /// <param name="initialPopulation">The population at the beginning of a year.</param>
        /// <param name="percent">The percentage of growth per year.</param>
        /// <param name="visitors">The visitors (new inhabitants per year) who come to live in the town.</param>
        /// <param name="currentPopulation">The population at present.</param>
        /// <returns>The count of years which the town need to see its population greater or equal to currentPopulation inhabitants.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when initial population is less or equals 0
        /// - or -
        /// the count of visitors cannot be less 0
        /// - or -
        /// the current population is less or equals 0
        /// - or -
        /// the current population is less than initial population.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">Throw if the value of percents is less then 0% or more then 100%.</exception>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int result = 0;

            if (currentPopulation <= 0)
            {
                throw new ArgumentException(null);
            }

            if (visitors < 0)
            {
                throw new ArgumentException(null);
            }

            if (initialPopulation <= 0)
            {
                throw new ArgumentException(null);
            }

            if (currentPopulation < initialPopulation)
            {
                throw new ArgumentException(null);
            }

            switch (percent)
            {
                case < 0:
                    throw new ArgumentException(null);
                case > 100:
                    throw new ArgumentException(null);
            }

            while (initialPopulation <= currentPopulation)
            {
                initialPopulation = (int)(initialPopulation + (initialPopulation * percent / 100)) + visitors;
                result++;
            }

            return result;
        }
    }
}
