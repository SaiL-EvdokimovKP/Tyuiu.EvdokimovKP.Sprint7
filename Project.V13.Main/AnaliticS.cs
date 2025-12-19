using Project.V13.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V13.Main
{
    public partial class AnaliticS : Form
    {
        public AnaliticS()
        {
            InitializeComponent();
        }

        private string[] countries =
        {
            "Китай", "Индия", "США", "Индонезия", "Пакистан",
            "Нигерия", "Бразилия", "Бангладеш", "Россия", "Мексика",
            "Япония", "Эфиопия", "Филиппины", "Египет", "Вьетнам",
            "ДР Конго", "Иран", "Турция", "Германия", "Таиланд"
        };

        private int[] s = 
        {
            9640011, 3287263, 9372610, 1904569, 881913,
            923768, 8515767, 147570, 17125191, 1964375,
            377975, 1104300, 300000, 1002450, 331212,
            2344858, 1648195, 783356, 357022, 513120
        };


        private void buttonCloseA_EKP_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonResSA_EKP_Click(object sender, EventArgs e)
        {
            var analysisReport = DataService.AnalyzerS.GetSAnalysisReport(s, countries);

            textBoxS_EKP.AppendText(new string('-', 40) + "\r\n");
            textBoxS_EKP.AppendText(analysisReport + "\r\n");

            // Второй метод
            var (maxCountry, maxS, minCountry, minS) =
                DataService.AnalyzerS.FindMinMaxS(s, countries);

            textBoxS_EKP.AppendText(new string('-', 40) + "\r\n");
            textBoxS_EKP.AppendText("\r\nДополнительная статистика:\r\n");
            textBoxS_EKP.AppendText($"Разница в площедях: {(maxS - minS)} км²\r\n");
            textBoxS_EKP.AppendText($"Максимальная площадь больше минимальной в " +
                $"{(double)maxS / minS:F1} раз\r\n");

            // Среднее население
            long totalS = 0;
            foreach (int pop in s)
            {
                totalS += pop;
            }
            double averageS = (double)totalS / s.Length;

            textBoxS_EKP.AppendText($"Среднея площадь: {averageS} км²\r\n");
            textBoxS_EKP.AppendText(new string('-', 40) + "\r\n");

            // Страны с населением выше среднего
            textBoxS_EKP.AppendText("\r\nСтраны с площадью выше средней:\r\n");
            for (int i = 0; i < countries.Length; i++)
            {
                if (s[i] > averageS)
                {
                    textBoxS_EKP.AppendText($"- {countries[i]}: {s[i]} км²\r\n");
                }
            }

            textBoxS_EKP.AppendText(new string('-', 40) + "\r\n");
            textBoxS_EKP.AppendText("\r\nАнализ завершен!");
        }
    }
}
