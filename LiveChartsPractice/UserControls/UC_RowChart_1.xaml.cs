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
    /// UC_RowChart_1.xaml 的交互逻辑
    /// </summary>
    public partial class UC_RowChart_1 : UserControl
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
        //Y轴坐标的标签
        public string[] Axis_Y_Labels { get; set; }
        //x轴坐标刻度的字符串格式化工具
        public Func<double, string> Axis_X_LabelFormatter { get; set; }
        //图例的位置
        public LegendLocation LegendLocation { get; set; }

        public UC_RowChart_1()
        {
            InitializeComponent();
            Series = new SeriesCollection
                    {
                        new RowSeries
                        {
                            Title = "Pork",
                            Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
                        },
                    };

            //坐标轴的Title
            Axis_Y_Title = "月份";
            Axis_X_Title = "单价";
            //x轴坐标的标签（当数量大于当前数据的数量，多出的部分，图表中不显示）
            Axis_Y_Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" };
            //y轴坐标，字符串格式化，“C”表示格式化成货币
            Axis_X_LabelFormatter = value => value.ToString("C");
            //设置图例的位置在右侧
            LegendLocation = LegendLocation.Bottom;

            ChartName = "单实体行状图";
            Description = "单线行线图，线条Title=Pork，Y轴坐标的Title=月份，X轴坐标Title=单价，" +
                "Y轴坐标标签是一个字符串数组，X轴的刻度套用了字符串格式化成货币格式, legend图例的位置在底部。" +
                "\n\n另外注意，其排列的方向是从下往上排列。";

            DataContext = this;
        }
    }
}
