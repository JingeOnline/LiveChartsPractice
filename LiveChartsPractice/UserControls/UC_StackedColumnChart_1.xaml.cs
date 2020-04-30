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
    /// UC_StackedColumnChart_1.xaml 的交互逻辑
    /// </summary>
    public partial class UC_StackedColumnChart_1 : UserControl
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

        public UC_StackedColumnChart_1()
        {
            InitializeComponent();

            Series = new SeriesCollection();

            //Stack1
            StackedColumnSeries stack1 = new StackedColumnSeries();
            stack1.Values = new ChartValues<double> { 1, 2, 3, 4, 2 };
            //是否在图形对应的Stack部分显示值
            stack1.DataLabels = true;
            stack1.Title = "Mike";
            Series.Add(stack1);

            //Stack2
            StackedColumnSeries stack2 = new StackedColumnSeries();
            stack2.Values = new ChartValues<double> { 3, 1, 1, 4,3 };
            //是否在图形对应的Stack部分显示值
            stack2.DataLabels = false;
            stack2.Title = "Jonson";
            Series.Add(stack2);

            //Stack2
            StackedColumnSeries stack3 = new StackedColumnSeries();
            stack3.Values = new ChartValues<double> { 2, 2, 4, 2, 4 };
            //是否在图形对应的Stack部分显示值
            stack3.DataLabels = true;
            stack3.Title = "Jonson";
            Series.Add(stack3);

            Axis_X_Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" };
            Axis_Y_LabelFormatter = value => value + "K";
            Axis_X_Title = "月份";
            Axis_Y_Title = "开支";

            ChartName = "基本StackColumnChart";
            Description = "X轴坐标是一组字符串，Y轴坐标使用了格式化 Axis_Y_LabelFormatter = value => value + \"K\""+
                "\nJonson的Stack不显示数据标签，DataLabels=false";
            DataContext = this;
        }
    }
}
