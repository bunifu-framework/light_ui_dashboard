using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awesome_light_ui_dashbard
{
    public partial class ctrl1 : UserControl
    {
        public ctrl1()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
                bunifuCharts2.colorSet.Add(Color.DeepPink);

            }
        }

        void refreshChart1()
        {

            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
            Bunifu.DataViz.WinForms.DataPoint data = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);
            Random r = new Random();

            data.addLabely("12am", r.Next(0, 1000).ToString());
            data.addLabely("2am", r.Next(0, 1000).ToString());
            data.addLabely("4am", r.Next(0, 1000).ToString());
            data.addLabely("6am", r.Next(0, 1000).ToString());
            data.addLabely("8am", r.Next(0, 1000).ToString());
            data.addLabely("10am", r.Next(0, 1000).ToString());
            data.addLabely("12pm", r.Next(0, 1000).ToString());

            canvas.addData(data);
            bunifuCharts1.Render(canvas);
        }

        void refreshChart2()
        {

            bunifuCharts2.colorSet.Add(Color.DeepPink);

            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
            Bunifu.DataViz.WinForms.DataPoint data = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_column);
            Random r = new Random();

            data.addLabely("12am", r.Next(0, 1000).ToString());
            data.addLabely("2am", r.Next(0, 1000).ToString());
            data.addLabely("4am", r.Next(0, 1000).ToString());
            data.addLabely("6am", r.Next(0, 1000).ToString());
            data.addLabely("8am", r.Next(0, 1000).ToString());
            data.addLabely("10am", r.Next(0, 1000).ToString());
            data.addLabely("12pm", r.Next(0, 1000).ToString());

            canvas.addData(data);
            bunifuCharts2.Render(canvas);
        }

        void refreshChart3()
        {

            bunifuCharts2.colorSet.Add(Color.DeepPink);

            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
            Bunifu.DataViz.WinForms.DataPoint data = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_doughnut);
            Random r = new Random();

            data.addLabely("United States", r.Next(0, 1000).ToString());
            data.addLabely("Kenya", r.Next(0, 1000).ToString());
            data.addLabely("Mexico", r.Next(0, 1000).ToString());
            data.addLabely("Brazil", r.Next(0, 1000).ToString());
            data.addLabely("China", r.Next(0, 1000).ToString());
            data.addLabely("Others", r.Next(0, 1000).ToString());
            data.addLabely("unknown", r.Next(0, 1000).ToString());

            canvas.addData(data);
            bunifuCharts3.Render(canvas);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            refreshChart1();
            refreshChart2();
            refreshChart3();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            refreshChart1();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            refreshChart2();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            refreshChart3();
        }
    }
}
