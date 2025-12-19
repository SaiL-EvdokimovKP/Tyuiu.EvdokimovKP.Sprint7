namespace Project.V13.Lib
{
    public class DataService
    {
        public static class PopulationAnalyzer
        {
            public static (string maxCountry, int maxPopulation, string minCountry, int minPopulation)
                FindMinMaxPopulation(int[] population, string[] countries)
            {
                int maxPopulation = population[0];
                int minPopulation = population[0];
                string maxCountry = countries[0];
                string minCountry = countries[0];

                for (int i = 1; i < population.Length; i++)
                {
                    if (population[i] > maxPopulation)
                    {
                        maxPopulation = population[i];
                        maxCountry = countries[i];
                    }

                    if (population[i] < minPopulation)
                    {
                        minPopulation = population[i];
                        minCountry = countries[i];
                    }
                }

                return (maxCountry, maxPopulation, minCountry, minPopulation);
            }

            public static string GetPopulationAnalysisReport(int[] population, string[] countries)
            {
                var (maxCountry, maxPopulation, minCountry, minPopulation) =
                    FindMinMaxPopulation(population, countries);

                return $"Страна с максимальным населением: {maxCountry} - {maxPopulation} чел.\n" +
                       $"Страна с минимальным населением: {minCountry} - {minPopulation} чел.";
            }
        }

        public static class AnalyzerS
        {
            public static (string maxCountry, int maxS, string minCountry, int minS)
                FindMinMaxS(int[] s, string[] countries)
            {
                int maxS = s[0];
                int minS = s[0];
                string maxCountry = countries[0];
                string minCountry = countries[0];

                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] > maxS)
                    {
                        maxS = s[i];
                        maxCountry = countries[i];
                    }

                    if (s[i] < minS)
                    {
                        minS = s[i];
                        minCountry = countries[i];
                    }
                }

                return (maxCountry, maxS, minCountry, minS);
            }

            public static string GetSAnalysisReport(int[] s, string[] countries)
            {
                var (maxCountry, maxS, minCountry, minS) =
                    FindMinMaxS(s, countries);

                return $"Страна с максимальной площадью: {maxCountry} - {maxS} км²\n" +
                       $"Страна с минимальной площадью: {minCountry} - {minS} км²";
            }
        }
    }
}
        





