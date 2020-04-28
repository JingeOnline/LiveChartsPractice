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

namespace LiveChartsPractice
{
    /// <summary>
    /// UserControl_Chart_Advanced.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl_Chart_Advanced : UserControl
    {
        public string Description { get; set; }
        public string Axis_X_Title { get; set; }
        public string Axis_Y_Title { get; set; }
        public string[] Axis_X_Labels { get; set; }
        public string[] Axis_Y_Labels { get; set; }
        public LegendLocation _LegendLocation { get; set; }
        public SeriesCollection Series { get; set; }
        public Func<double,string> Axis_Y_LabelFormatter { get; set; }

        public UserControl_Chart_Advanced()
        {
            InitializeComponent();

            //Description = "三个实体，颜色自动，图例位置LegendLocation=Right，X轴坐标为自定义string[], " +
            //    "Y轴坐标自动生成，但应用了字符串格式化，将double类型转换为货币";
            ////进阶柱状图
            //Series = new SeriesCollection();

            ////不同实体会自动适配不同的颜色
            ////实体1
            //ColumnSeries line1 = new ColumnSeries();
            //line1.Title = "Mike";
            //line1.Values = new ChartValues<double> { 4, 6, 5, 2, 4 };
            //Series.Add(line1);
            ////实体2
            //ColumnSeries line2 = new ColumnSeries();
            //line2.Title = "Jane";
            //line2.Values = new ChartValues<double> { 5, 9, 4, 8, 5 };
            //Series.Add(line2);
            ////实体3
            //ColumnSeries line3 = new ColumnSeries();
            //line3.Title = "Jane";
            //line3.Values = new ChartValues<double> { 2, 4, 6, 7, 8 };
            //Series.Add(line3);
            
            ////y轴坐标，字符串格式化，“C”表示格式化成货币
            //Axis_Y_LabelFormatter= value => value.ToString("C");
            ////图例说明的位置
            //_LegendLocation = LegendLocation.Right;
            ////x轴坐标
            //Axis_X_Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            ////坐标轴的Title
            //Axis_X_Title = "X轴Title";
            //Axis_Y_Title = "Y轴Title";

            DataContext = this;
        }
    }
}
