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
    public partial class Population : Form
    {
        public Population()
        {
            InitializeComponent();
        }

        int a = 1412000000; // Китай
        int b = 1380000000; // Индия
        int c = 335000000;  // США
        int d = 277000000;  // Индонезия
        int E = 238000000;  // Пакистан
        int f = 227000000;  // Нигерия
        int g = 217000000;  // Бразилия
        int h = 173000000;  // Бангладеш
        int i = 147000000;  // Россия
        int j = 128000000;  // Мексика
        int k = 126000000;  // Япония
        int l = 114000000;  // Эфиопия
        int m = 102000000;  // Филиппины
        int n = 102000000;  // Египет
        int o = 89000000;   // Вьетнам
        int p = 85000000;   // ДР Конго
        int q = 82000000;   // Иран
        int r = 76000000;   // Турция
        int s = 68000000;   // Германия
        int t = 67000000;   // Таиланд



        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void chart1_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Add(a);
            this.chart1.Series[0].Points.Add(b);
            this.chart1.Series[0].Points.Add(c);
            this.chart1.Series[0].Points.Add(d);
            this.chart1.Series[0].Points.Add(E);
            this.chart1.Series[0].Points.Add(f);
            this.chart1.Series[0].Points.Add(g);
            this.chart1.Series[0].Points.Add(h);
            this.chart1.Series[0].Points.Add(i);
            this.chart1.Series[0].Points.Add(j);
            this.chart1.Series[0].Points.Add(k);
            this.chart1.Series[0].Points.Add(l);
            this.chart1.Series[0].Points.Add(m);
            this.chart1.Series[0].Points.Add(n);
            this.chart1.Series[0].Points.Add(o);
            this.chart1.Series[0].Points.Add(p);
            this.chart1.Series[0].Points.Add(q);
            this.chart1.Series[0].Points.Add(r);
            this.chart1.Series[0].Points.Add(s);
            this.chart1.Series[0].Points.Add(t);
        }
    }
}
