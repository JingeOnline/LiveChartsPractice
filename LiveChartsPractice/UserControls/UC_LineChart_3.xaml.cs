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
    /// UC_LineChart_3.xaml 的交互逻辑
    /// </summary>
    public partial class UC_LineChart_3 : UserControl
    {
        //窗口下面的描述文字
        public string Description { get; set; }
        //图表
        public SeriesCollection Series { get; set; }
        //图表的名称
        public string ChartName { get; set; }
        //图例的位置
        public LegendLocation LegendLocation { get; set; }

        public UC_LineChart_3()
        {
            InitializeComponent();
            Series = new SeriesCollection();

            //Line1
            LineSeries line1 = new LineSeries();
            line1.Title = "Mike";
            line1.Values = new ChartValues<double> { 11, 13, 11, 16, 10 };
            Series.Add(line1);

            //Line2
            LineSeries line2 = new LineSeries();
            line2.Title = "Willa";
            line2.Values = new ChartValues<double> { 9, 7, 6, 9, 2 };
            //线条的平滑程度，0为直线，1为100%平滑的曲线。
            line2.LineSmoothness = 0;
            Series.Add(line2);

            //Line3
            LineSeries line_3 = new LineSeries();
            line_3.Title = "Nico";
            line_3.Values = new ChartValues<double> { 4, 6, 5, 2, 4 };
            //设置线条为点状线，2是点的长度
            line_3.StrokeDashArray = new DoubleCollection { 2 };
            Series.Add(line_3);

            //Line4
            LineSeries line_4 = new LineSeries();
            line_4.Title = "Jane";
            line_4.Values = new ChartValues<double> { 1, 2, 3, 1, 2 };
            ////设置线条在坐标轴内的面积填充色
            //line_4.Fill = Brushes.Gray;
            //设置线条的颜色（legend图例中线条颜色也会跟着变化）
            line_4.Stroke = Brushes.LightGreen;
            //设置线条粗细（legend图例中线条粗细也会跟着变化）
            line_4.StrokeThickness = 10;
            Series.Add(line_4);

            //设置图例的位置在右侧
            LegendLocation = LegendLocation.Right;
            ChartName = "自定义线条";
            Description = "Mike线条是默认线条\n" + "Willa线条平滑度为0\n" +
                           "Nico线条为虚线，虚线长度为2\n" + "Jane线条颜色自定义，粗细自定义";
            DataContext = this;
        }
    }
}
