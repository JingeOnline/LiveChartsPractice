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
    /// UC_StackedArea_1.xaml 的交互逻辑
    /// </summary>
    public partial class UC_StackedArea_1 : UserControl
    {
        //窗口下面的描述文字
        public string Description { get; set; }
        //图表
        public SeriesCollection Series { get; set; }
        //图表的名称
        public string ChartName { get; set; }
        //x轴坐标字符串格式化工具
        public Func<double, string> Axis_X_LabelFormatter { get; set; }
        //y轴坐标字符串格式化工具
        public Func<double, string> Axis_Y_LabelFormatter { get; set; }


        public UC_StackedArea_1()
        {
            InitializeComponent();
            Series = new SeriesCollection();

            //Stack1
            StackedAreaSeries stack1 = new StackedAreaSeries();
            stack1.Title = "Asia";
            ChartValues<DateTimePoint> chartValues1 = new ChartValues<DateTimePoint>();
            chartValues1.Add(new DateTimePoint(new DateTime(1950, 1, 1), 1395));
            chartValues1.Add(new DateTimePoint(new DateTime(1960, 1, 1), 1694));
            chartValues1.Add(new DateTimePoint(new DateTime(1970, 1, 1), 2128));
            chartValues1.Add(new DateTimePoint(new DateTime(1980, 1, 1), 2634));
            stack1.Values = chartValues1;
            stack1.LineSmoothness = 1;
            Series.Add(stack1);

            //Stack2
            StackedAreaSeries stack2 = new StackedAreaSeries();
            stack2.Title = "Africa";
            ChartValues<DateTimePoint> chartValues2 = new ChartValues<DateTimePoint>();
            chartValues2.Add(new DateTimePoint(new DateTime(1950, 1, 1), 228));
            chartValues2.Add(new DateTimePoint(new DateTime(1960, 1, 1), 1285));
            chartValues2.Add(new DateTimePoint(new DateTime(1970, 1, 1), 366));
            chartValues2.Add(new DateTimePoint(new DateTime(1980, 1, 1), 478));
            stack2.Values = chartValues2;
            stack2.LineSmoothness = 1;
            Series.Add(stack2);

            //Stack3
            StackedAreaSeries stack3 = new StackedAreaSeries
            {
                Title = "N & S America",
                Values = new ChartValues<DateTimePoint>
                    {
                        new DateTimePoint(new DateTime(1950, 1, 1), 339),
                        new DateTimePoint(new DateTime(1960, 1, 1), 824),
                        new DateTimePoint(new DateTime(1970, 1, 1), 519),
                        new DateTimePoint(new DateTime(1980, 1, 1), 618),
                    },
                LineSmoothness = 0
            };
            Series.Add(stack3);

            //Stack4
            StackedAreaSeries stack4 = new StackedAreaSeries
            {
                Title = "Europe",
                Values = new ChartValues<DateTimePoint>
                    {
                        new DateTimePoint(new DateTime(1950, 1, 1), 549),
                        new DateTimePoint(new DateTime(1960, 1, 1), 605),
                        new DateTimePoint(new DateTime(1970, 1, 1), 657),
                        new DateTimePoint(new DateTime(1980, 1, 1), 694),
                    },
                LineSmoothness = 0
            };
            Series.Add(stack4);

            //x轴坐标格式化（DataTime格式化成yyyy）
            Axis_X_LabelFormatter = val => new DateTime((long)val).ToString("yyyy");
            //y轴坐标格式化（用逗号分隔千位的数字,并且精确到小数点后两位）
            Axis_Y_LabelFormatter = val => val.ToString("N") + " M";

            ChartName = "基本StackArea";
            Description = "Asian和Africa线条的平滑度=1，Europe和NS America的线条平滑度=0。"+
                "\nx轴和y轴的坐标都是自动生成，因为这次每个数据节点都是以一个DataTimePoint(DateTime,Double), " +
                "会根据DateTime自动生成x轴坐标，根据Double自动生成y轴坐标"+"\n"+
                "x轴坐标格式化成ToString(\"yyyy\")，y轴坐标格式化用ToString(\"N\")";
            DataContext = this;

            //MessageBox.Show(Convert.ToInt32("3000").ToString("N"));
        }
    }
}
