using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;


namespace LiveChartsPractice.UserControls
{
    /// <summary>
    /// UC_ScatterPlot.xaml 的交互逻辑
    /// </summary>
    public partial class UC_ScatterPlot_1 : UserControl
    {
        //窗口下面的描述文字
        public string Description { get; set; }
        //图表的名称
        public string ChartName { get; set; }
        //图表
        public SeriesCollection Series { get; set; }

        public UC_ScatterPlot_1()
        {
            InitializeComponent();
            Series = new SeriesCollection();

            //Item1
            ScatterSeries scatter1 = new ScatterSeries();
            scatter1.Title = "Pork";
            //不带Weight
            ChartValues<ObservablePoint> values1 = new ChartValues<ObservablePoint>
            {
                new ObservablePoint(1.5,2.5),
                new ObservablePoint(3.5,2.5),
                new ObservablePoint(4.5,1.5),
            };
            scatter1.Values = values1;
            Series.Add(scatter1);

            //Item2
            ScatterSeries scatter2 = new ScatterSeries();
            scatter2.Title = "Beef";
            //带Weight
            ChartValues<ScatterPoint> values2 = new ChartValues<ScatterPoint>
            {
                new ScatterPoint(2.5,3,10),
                new ScatterPoint(4.5,1,15),
                new ScatterPoint(5,3.5,30),
            };
            scatter2.Values = values2;
            Series.Add(scatter2);

            //Item3
            ScatterSeries scatter3 = new ScatterSeries();
            scatter3.Title = "Lamb";
            ChartValues<ScatterPoint> values3 = new ChartValues<ScatterPoint>
            {
                new ScatterPoint(1,3,40),
                new ScatterPoint(3.5,1,15),
                new ScatterPoint(4,3.5,30),
            };
            scatter3.Values = values3;
            //自定义LabelPoint，在Tooltip中显示Weight值。
            scatter3.LabelPoint = point => "单价Weight:"+point.Weight;
            Series.Add(scatter3);


            ChartName = "ScatterPlot";
            Description = "散点图，除了x/y坐标外，可以带weight。\n"+
                "当前示例中，Pork使用的是ObservablePoint，不带weight；Beef使用的是ScatterPoint，带weight。\n"+
                "虽然Beef带weight，但是Tooltip中并不显示，只是通过点的大小来表示。\n"+
                "在Lamb中，通过自定义LablePoint，让其在Tooltip中显示Weight。";
            DataContext = this;
        }
    }
}
