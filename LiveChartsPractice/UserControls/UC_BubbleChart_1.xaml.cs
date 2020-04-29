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
    /// UC_BubbleChart_1.xaml 的交互逻辑
    /// </summary>
    public partial class UC_BubbleChart_1 : UserControl
    {
        //窗口下面的描述文字
        public string Description { get; set; }
        //图表
        public SeriesCollection Series { get; set; }
        //图表的名称
        public string ChartName { get; set; }
        //坐标轴的Title
        public string Axis_X_Title { get; set; }
        public string Axis_Y_Title { get; set; }
        //x轴坐标的标签
        public string[] Axis_X_Labels { get; set; }
        //y轴坐标刻度的字符串格式化工具
        public Func<double, string> Axis_Y_LabelFormatter { get; set; }
        //图例的位置
        public LegendLocation LegendLocation { get; set; }

        public UC_BubbleChart_1()
        {
            InitializeComponent();
            Series = new SeriesCollection();

            //Item1
            ScatterSeries item1 = new ScatterSeries();
            item1.Title = "Pork";
            ChartValues<ScatterPoint> item1Points = new ChartValues<ScatterPoint>();
            //三个向量的数据（x轴，y轴，泡泡大小）(一月份，单价5，销售额)
            item1Points.Add(new ScatterPoint(1, 5, 20));
            item1Points.Add(new ScatterPoint(2, 6, 24));
            item1Points.Add(new ScatterPoint(3, 7, 14));
            item1Points.Add(new ScatterPoint(4, 4, 24));
            item1Points.Add(new ScatterPoint(5, 8, 132));
            item1.Values = item1Points;
            Series.Add(item1);

            //Item2
            ScatterSeries item2 = new ScatterSeries();
            item2.Title = "Beef";
            ChartValues<ScatterPoint> item2Points = new ChartValues<ScatterPoint>();
            //三个向量的数据（x轴，y轴，泡泡大小）(一月份，单价5，销售额)
            item2Points.Add(new ScatterPoint(1, 9, 18));
            item2Points.Add(new ScatterPoint(2, 8, 40));
            item2Points.Add(new ScatterPoint(3, 9, 42));
            item2Points.Add(new ScatterPoint(4, 6, 180));
            item2Points.Add(new ScatterPoint(5, 6, 48));
            item2.Values = item2Points;
            //泡泡点的最小直径和最大直径（单位像素）
            item2.MinPointShapeDiameter = 5;
            item2.MaxPointShapeDiameter = 30;
            Series.Add(item2);

            //Item3
            ScatterSeries item3 = new ScatterSeries();
            item3.Title = "Lamb";
            ChartValues<ScatterPoint> item3Points = new ChartValues<ScatterPoint>();
            //三个向量的数据（x轴，y轴，泡泡大小）(一月份，单价5，销售额)
            item3Points.Add(new ScatterPoint(1, 3, 20));
            item3Points.Add(new ScatterPoint(2, 1, 24));
            item3Points.Add(new ScatterPoint(3, 4, 14));
            item3Points.Add(new ScatterPoint(4, 5, 24));
            item3Points.Add(new ScatterPoint(5, 2, 132));
            item3.Values = item3Points;
            //设置泡泡的形状为方形
            item3.PointGeometry = DefaultGeometries.Square;
            Series.Add(item3);

            //坐标轴的Title
            Axis_X_Title = "月份";
            Axis_Y_Title = "单价";
            //x轴坐标的标签（当数量大于当前数据的数量，多出的部分，图表中不显示）
            Axis_X_Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" };
            //y轴坐标，字符串格式化，“C”表示格式化成货币
            Axis_Y_LabelFormatter = value => value.ToString("C");
            //设置图例的位置在右侧
            LegendLocation = LegendLocation.Right;

            ChartName = "多实体泡泡图";
            Description = "多实体泡泡图，X轴坐标的Title=月份，Y轴坐标Title=单价，Bubble大小表示销售总额。" +
                "X轴坐标标签是一个字符串数组，y轴的刻度套用了字符串格式化成货币格式, legend图例的位置在右侧。" +
                "\n\nPork的点是全部默认值，Beef的点自定义了最小直径和最大直径，可见默认情况下点的大小区别很不明显。"+
                "\nLamb的泡泡形状自定义成了方形。"+
                "\n\nTooltip默认情况下是OnlySender，只显示一个泡泡的数据，当两个泡泡重叠的时候，后面的泡泡没法点选。" +
                "而且不显示泡泡大小对应的值。";

            DataContext = this;
        }
    }
}
