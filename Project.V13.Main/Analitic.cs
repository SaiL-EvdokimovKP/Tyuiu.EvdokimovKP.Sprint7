using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.V13.Lib;

namespace Project.V13.Main
{
    public partial class Analitic : Form
    {
        // Данные о странах и населении
        private string[] countries =
        {
            "Китай", "Индия", "США", "Индонезия", "Пакистан",
            "Нигерия", "Бразилия", "Бангладеш", "Россия", "Мексика",
            "Япония", "Эфиопия", "Филиппины", "Египет", "Вьетнам",
            "ДР Конго", "Иран", "Турция", "Германия", "Таиланд"
        };

        private int[] population =
        {
             1412000000, 1380000000, 335000000, 277000000, 238000000,
            227000000, 217000000, 173000000, 147000000, 128000000,
            126000000, 114000000, 102000000, 102000000, 89000000,
            85000000, 82000000, 76000000, 68000000, 67000000
        };

        public Analitic()
        {
            InitializeComponent();
        }

        private void buttonRes_EKP_Click(object sender, EventArgs e)
        {
            // Используем метод из библиотеки
            var analysisReport = DataService.PopulationAnalyzer.GetPopulationAnalysisReport(population, countries);

            textBoxResP_EKP.AppendText(new string('-', 40) + "\r\n");
            textBoxResP_EKP.AppendText(analysisReport + "\r\n");

            // Второй метод
            var (maxCountry, maxPopulation, minCountry, minPopulation) =
                DataService.PopulationAnalyzer.FindMinMaxPopulation(population, countries);

            textBoxResP_EKP.AppendText(new string('-', 40) + "\r\n");
            textBoxResP_EKP.AppendText("\r\nДополнительная статистика:\r\n");
            textBoxResP_EKP.AppendText($"Разница в населении: {(maxPopulation - minPopulation)} чел.\r\n");
            textBoxResP_EKP.AppendText($"Максимальное население больше минимального в " +
                $"{(double)maxPopulation / minPopulation:F1} раз\r\n");

            // Среднее население
            long totalPopulation = 0;
            foreach (int pop in population)
            {
                totalPopulation += pop;
            }
            double averagePopulation = (double)totalPopulation / population.Length;

            textBoxResP_EKP.AppendText($"Среднее население: {averagePopulation} чел.\r\n");
            textBoxResP_EKP.AppendText(new string('-', 40) + "\r\n");

            // Страны с населением выше среднего
            textBoxResP_EKP.AppendText("\r\nСтраны с населением выше среднего:\r\n");
            for (int i = 0; i < countries.Length; i++)
            {
                if (population[i] > averagePopulation)
                {
                    textBoxResP_EKP.AppendText($"- {countries[i]}: {population[i]} чел.\r\n");
                }
            }

            textBoxResP_EKP.AppendText(new string('-', 40) + "\r\n");
            textBoxResP_EKP.AppendText("\r\nАнализ завершен!");
        }

        private void buttonClose_EKP_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
