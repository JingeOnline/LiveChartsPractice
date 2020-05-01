using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// UC_ColumnChart_2.xaml 的交互逻辑
    /// </summary>
    public partial class UC_ColumnChart_2_F : UserControl,INotifyPropertyChanged
    {
        //窗口下面的描述文字
        public string Description { get; set; }
        //图表的名称
        public string ChartName { get; set; }
        //图表
        public SeriesCollection Series { get; set; }
        //坐标轴的Title
        public string Axis_X_Title { get; set; }
        public string Axis_Y_Title { get; set; }
        //x轴坐标的标签
        public string[] Axis_X_Labels { get; set; }
        //y轴坐标刻度的字符串格式化工具
        public Func<double, string> axis_Y_LabelFormatter;
        public Func<double, string> Axis_Y_LabelFormatter 
        {
            get { return axis_Y_LabelFormatter; }
            set
            {
                axis_Y_LabelFormatter = value;
                OnPropertyChanged("Axis_Y_LabelFormatter");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        //图例的位置
        public LegendLocation LegendLocation { get; set; }

        public UC_ColumnChart_2_F()
        {
            InitializeComponent();
            Series = new SeriesCollection();

            //实体1
            ColumnSeries column1 = new ColumnSeries();
            column1.Title = "Pork";
            column1.Values = new ChartValues<double> { 4, 6, 5, 2, 4 };
            Series.Add(column1);
            //实体2
            ColumnSeries column2 = new ColumnSeries();
            column2.Title = "Lamb";
            column2.Values = new ChartValues<double> { 5, 9, 4, 8, 5 };
            Series.Add(column2);
            //实体3
            ColumnSeries column3 = new ColumnSeries();
            column3.Title = "Beef";
            column3.Values = new ChartValues<double> { 2, 4, 6, 7, 8 };
            Series.Add(column3);

            //坐标轴的Title
            Axis_X_Title = "月份";
            Axis_Y_Title = "单价";
            //x轴坐标的标签（当数量大于当前数据的数量，多出的部分，图表中不显示）
            Axis_X_Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" };
            //y轴坐标，字符串格式化，“C”表示格式化成货币
            Axis_Y_LabelFormatter = value => value.ToString("C");
            //设置图例的位置在右侧
            LegendLocation = LegendLocation.Right;

            ChartName = "F-坐标轴数值格式化";
            Description = "点击按钮，分别格式化成不同的字符串格式, Tooltip中的单位跟着改变。"+"\n"+
                "Axis_Y_LabelFormatter = value => value.ToString(\"C\")"+"\n"+
                "Axis_Y_LabelFormatter = val => val + \"°\""+"\n"+
                "Axis_Y_LabelFormatter = val => val + \"Million items sold\"";

            DataContext = this;
        }



        private void Button_Formate1_Click(object sender, RoutedEventArgs e)
        {
            //“C”表示格式化成货币
            Axis_Y_LabelFormatter = value => value.ToString("C");

        }

        private void Button_Formate2_Click(object sender, RoutedEventArgs e)
        {
            //格式化成温度
            Axis_Y_LabelFormatter = val => val + "°";

        }

        private void Button_Formate3_Click(object sender, RoutedEventArgs e)
        {
            //格式化成自定义后缀
            Axis_Y_LabelFormatter = val => val + "Million items sold";
        }
    }
}
