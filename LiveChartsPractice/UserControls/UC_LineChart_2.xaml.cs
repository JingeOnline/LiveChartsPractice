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
using LiveCharts.Wpf;

namespace LiveChartsPractice.UserControls
{
    /// <summary>
    /// UC_LineChart_2.xaml 的交互逻辑
    /// </summary>
    public partial class UC_LineChart_2 : UserControl
    {
        //窗口下面的描述文字
        public string Description { get; set; }
        //图表
        public SeriesCollection Series { get; set; }
        //图表的名称
        public string ChartName { get; set; }
        //图例的位置
        public LegendLocation LegendLocation { get; set; }
        //坐标轴的Title
        public string Axis_X_Title { get; set; }
        public string Axis_Y_Title { get; set; }
        //x轴坐标的标签
        public string[] Axis_X_Labels { get; set; }
        //y轴坐标刻度的字符串格式化工具
        public Func<double, string> Axis_Y_LabelFormatter { get; set; }


        public UC_LineChart_2()
        {
            InitializeComponent();
            Series = new SeriesCollection();

            //Line1
            LineSeries line1 = new LineSeries();
            line1.Title = "Mike";
            line1.Values = new ChartValues<double> { 4, 6, 5, 2, 4 };
            Series.Add(line1);

            //Line2
            LineSeries line2 = new LineSeries();
            line2.Title = "Jane";
            line2.Values = new ChartValues<double> { 5, 9, 4, 8, 5 };
            //设置数据节点的图形为方块
            line2.PointGeometry = DefaultGeometries.Square;
            //设置数据节点图像的大小
            line2.PointGeometrySize = 16;
            Series.Add(line2);

            //Line3
            LineSeries line3 = new LineSeries();
            line3.Title = "Nico";
            line3.Values = new ChartValues<double> { 2, 4, 6, 7, 8 };
            //不显示数据结点
            line3.PointGeometry = null;
            Series.Add(line3);

            //line5
            LineSeries line5 = new LineSeries();
            line5.Title = "David";
            line5.Values = new ChartValues<double> { 1, 2, 3, 5, 1 };
            //自定义数据节点的形状
            line5.PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z");
            //自定义数据节点的颜色(*莫名其妙，不起作用)
            line5.PointForeground = Brushes.Yellow;
            Series.Add(line5);

            //坐标轴的Title
            Axis_X_Title = "月份";
            Axis_Y_Title = "单价";
            //x轴坐标的标签（当数量大于当前数据的数量，多出的部分，图表中不显示）
            Axis_X_Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" };
            //y轴坐标，字符串格式化，“C”表示格式化成货币
            Axis_Y_LabelFormatter = value => value.ToString("C");
            //设置图例的位置在右侧
            LegendLocation = LegendLocation.Right;

            ChartName = "自定义数据结点(图例)";
            Description = "Mike线条是默认线条\n" + "Jane线条自定义节点形状和大小\n" +
                           "Nico线条不显示节点\n"+"David线条节点形状自定义";

            DataContext = this;
        }
    }
}
