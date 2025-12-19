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

        public Analitic()
        {
            InitializeComponent();
        }

        private void buttonRes_EKP_Click(object sender, EventArgs e)
        {
            textBoxResP_EKP.Text = Convert.ToString(DataService.PopulationAnalyzer.GetPopulationAnalysisReport(population, countries));
        }

        private void buttonClose_EKP_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
