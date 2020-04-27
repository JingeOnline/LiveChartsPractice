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

                    SeriesCollection series_0 = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Title = "曲线图",
                            Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
                        },
                    };

                    UserControl_Chart chart_0 = new UserControl_Chart();
                    chart_0.Description = "单线曲线图，值类型为double，只设置了Title和Values属性，鼠标悬停显示Title";
                    chart_0.Series = series_0;
                    TabItem_Linechart.Content = chart_0;

                    break;

                case 1:
                    SeriesCollection series_1 = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Title = "柱状图",
                            Values = new ChartValues<double> { 4, 6, 5, 2, 4 }
                        }
                    };
                    UserControl_Chart chart_1 = new UserControl_Chart();
                    chart_1.Description = "单柱状图，值类型为double，只设置了Title和Values属性，鼠标悬停显示Title";
                    chart_1.Series = series_1;
                    TabItem_Columnchart.Content = chart_1;

                    break;
                case 2:
                    SeriesCollection series_2 = new SeriesCollection
                    {
                        new RowSeries
                        {
                            Title = "行状图",
                            Values = new ChartValues<double> { 4, 6, 5, 2, 4 }
                        }
                    };
                    UserControl_Chart chart_2 = new UserControl_Chart();
                    chart_2.Description = "单行状图，值类型为double，只设置了Title和Values属性，鼠标悬停显示Title";
                    chart_2.Series = series_2;
                    TabItem_Rowchart.Content = chart_2;
                    break;
            }
        }





    }
}
