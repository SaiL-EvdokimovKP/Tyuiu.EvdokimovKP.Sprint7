using System;
using Project.V13.Lib;

class Program
{
    static void Main(string[] args)
    {
        // Пример данных: страны и их население (в тысячах человек)
        string[] countries =
        {
                "Россия", "Китай", "США", "Индия",
                "Бразилия", "Германия", "Япония", "Канада"
            };

        int[] population =
        {
                146_748_590, 1_411_750_000, 333_287_557,
                1_428_627_663, 215_313_498, 84_270_625,
                125_124_989, 38_781_291
            };

        Console.WriteLine("Анализ населения стран\n");

        // Использование метода из библиотеки
        var analysisReport = DataService.PopulationAnalyzer.GetPopulationAnalysisReport(population, countries);


        Console.WriteLine(new string('-', 40));
        Console.WriteLine(analysisReport);

        // Дополнительный анализ с использованием второго метода
        var (maxCountry, maxPopulation, minCountry, minPopulation) =
            DataService.PopulationAnalyzer.FindMinMaxPopulation(population, countries);

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("\nДополнительная статистика:");
        Console.WriteLine($"Разница в населении: {(maxPopulation - minPopulation)} чел.");
        Console.WriteLine($"Максимальное население больше минимального в " +
            $"{(double)maxPopulation / minPopulation:F1} раз");

        // Находим среднее население
        long totalPopulation = 0;
        foreach (int pop in population)
        {
            totalPopulation += pop;
        }
        double averagePopulation = (double)totalPopulation / population.Length;

        Console.WriteLine($"Среднее население: {averagePopulation} чел.");
        Console.WriteLine(new string('-', 40));

        // Анализ стран с населением выше среднего
        Console.WriteLine("\nСтраны с населением выше среднего:");
        for (int i = 0; i < countries.Length; i++)
        {
            if (population[i] > averagePopulation)
            {
                Console.WriteLine($"- {countries[i]}: {population[i]} чел.");
            }
        }

        Console.ReadKey();
    }
}