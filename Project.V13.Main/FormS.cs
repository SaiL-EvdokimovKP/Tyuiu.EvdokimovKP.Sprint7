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
    public partial class FormS : Form
    {
        public FormS()
        {
            InitializeComponent();
        }

        int a = 9640011;
        int b = 3287263;
        int c = 9372610;
        int d = 1904569;
        int E = 881913;
        int f = 923768;
        int g = 8515767;
        int h = 147570;
        int i = 17125191;
        int j = 1964375;
        int k = 377975;
        int l = 1104300;
        int m = 300000;
        int n = 1002450;
        int o = 331212;
        int p = 2344858;
        int q = 1648195;
        int r = 783356;
        int s = 357022;
        int t = 513120;

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
