using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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


namespace LiveChartsPractice
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }



        private void TabControl_HomePage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl tabControl = (TabControl)e.Source;
            int tabIndex = tabControl.SelectedIndex;
            switch (tabIndex)
            {
                case 0:
                    //基本曲线图
                    SeriesCollection series_0 = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Title = "Mike",
                            Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
                        },
                    };

                    UserControl_Chart chart_0 = new UserControl_Chart();
                    chart_0.Description = "单线曲线图，值类型为double，只设置了Title和Values属性，鼠标悬停显示Title";
                    chart_0.Series = series_0;
                    TabItem_Linechart.Content = chart_0;

                    break;

                case 1:
                    //基本柱状图
                    SeriesCollection series_1 = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Title = "Mike",
                            Values = new ChartValues<double> { 4, 6, 5, 2, 4 }
                        }
                    };
                    UserControl_Chart chart_1 = new UserControl_Chart();
                    chart_1.Description = "单柱状图，值类型为double，只设置了Title和Values属性，鼠标悬停显示Title";
                    chart_1.Series = series_1;
                    TabItem_Columnchart.Content = chart_1;

                    break;
                case 2:
                    //基本行状图
                    SeriesCollection series_2 = new SeriesCollection
                    {
                        new RowSeries
                        {
                            Title = "Mike",
                            Values = new ChartValues<double> { 4, 6, 5, 2, 4 }
                        }
                    };
                    UserControl_Chart chart_2 = new UserControl_Chart();
                    chart_2.Description = "单行状图，值类型为double，只设置了Title和Values属性，鼠标悬停显示Title";
                    chart_2.Series = series_2;
                    TabItem_Rowchart.Content = chart_2;
                    break;

                case 3:
                    //高级柱状图
                    UserControl_Chart_Advanced chart_3 = new UserControl_Chart_Advanced();

                    SeriesCollection series_3 = new SeriesCollection();

                    //不同实体会自动适配不同的颜色
                    //实体1
                    ColumnSeries column1 = new ColumnSeries();
                    column1.Title = "Mike";
                    column1.Values = new ChartValues<double> { 4, 6, 5, 2, 4 };
                    series_3.Add(column1);
                    //实体2
                    ColumnSeries column2 = new ColumnSeries();
                    column2.Title = "Jane";
                    column2.Values = new ChartValues<double> { 5, 9, 4, 8, 5 };
                    series_3.Add(column2);
                    //实体3
                    ColumnSeries column3 = new ColumnSeries();
                    column3.Title = "Nico";
                    column3.Values = new ChartValues<double> { 2, 4, 6, 7, 8 };
                    series_3.Add(column3);

                    //y轴坐标，字符串格式化，“C”表示格式化成货币
                    chart_3.Axis_Y_LabelFormatter = value => value.ToString("C");
                    //图例说明的位置
                    chart_3._LegendLocation = LegendLocation.Right;
                    //x轴坐标
                    chart_3.Axis_X_Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
                    //坐标轴的Title
                    chart_3.Axis_X_Title = "X轴Title";
                    chart_3.Axis_Y_Title = "Y轴Title";

                    chart_3.Description = "三个实体，颜色自动，图例位置LegendLocation=Right，X轴坐标为自定义string[], " +
                    "Y轴坐标自动生成，但应用了字符串格式化，将double类型转换为货币";
                    chart_3.Series = series_3;
                    TabItem_Columnchart_1.Content = chart_3;
                    break;

                case 4:
                    //高级曲线图
                    UserControl_Chart_Advanced chart_4 = new UserControl_Chart_Advanced();
                    SeriesCollection series_4 = new SeriesCollection();

                    //Line1
                    LineSeries line1 = new LineSeries();
                    line1.Title = "Mike";
                    line1.Values = new ChartValues<double> { 4, 6, 5, 2, 4 };
                    series_4.Add(line1);

                    //Line2
                    LineSeries line2 = new LineSeries();
                    line2.Title = "Jane";
                    line2.Values = new ChartValues<double> { 5, 9, 4, 8, 5 };
                    //设置数据节点的图形为方块
                    line2.PointGeometry = DefaultGeometries.Square;
                    //设置数据节点图像的大小
                    line2.PointGeometrySize = 16;
                    series_4.Add(line2);

                    //Line3
                    LineSeries line3 = new LineSeries();
                    line3.Title = "Nico";
                    line3.Values = new ChartValues<double> { 2, 4, 6, 7, 8 };
                    //不显示数据结点
                    line3.PointGeometry = null;
                    series_4.Add(line3);

                    //Line4
                    LineSeries line4 = new LineSeries();
                    line4.Title = "Willa";
                    line4.Values = new ChartValues<double> { 9, 7, 6, 9, 2 };
                    //线条的平滑程度，0为直线，1为100%平滑的曲线。
                    line4.LineSmoothness = 0;
                    series_4.Add(line4);

                    //line5
                    LineSeries line5 = new LineSeries();
                    line5.Title = "David";
                    line5.Values = new ChartValues<double> { 1, 2, 3, 5, 1 };
                    //自定义数据节点的形状
                    line5.PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z");
                    //自定义数据节点的颜色(*莫名其妙，不起作用)
                    line5.PointForeground = Brushes.Yellow;
                    series_4.Add(line5);

                    //y轴坐标，字符串格式化，“C”表示格式化成货币
                    chart_4.Axis_Y_LabelFormatter = value => value.ToString("C");
                    //图例说明的位置
                    chart_4._LegendLocation = LegendLocation.Bottom;
                    //x轴坐标
                    chart_4.Axis_X_Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
                    //坐标轴的Title
                    chart_4.Axis_X_Title = "X轴Title";
                    chart_4.Axis_Y_Title = "Y轴Title";

                    chart_4.Description = "Mike线条是默认线条\n" + "Jane线条自定义节点形状和大小\n" +
                        "Nico线条不显示节点\n"+"Willa线条平滑度为0\n"+"David线条节点形状自定义";
                    chart_4.Series = series_4;
                    TabItem_Linechart_1.Content = chart_4;
                    break;
            }
        }





    }
}
