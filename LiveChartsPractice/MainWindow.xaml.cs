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
using LiveChartsPractice.UserControls;

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
            TabItem tabItem = tabControl.SelectedItem as TabItem;
            String tabHead = tabItem.Header.ToString();

            switch (tabHead)
            {
                case "ColumnChart":
                    UserControl_TabContent columnChartTab = new UserControl_TabContent();
                    columnChartTab.TabLabelTitle = tabHead;

                    List<UserControl> columnControlList = new List<UserControl>();
                    columnControlList.Add(new UC_ColumnChart_1());
                    columnControlList.Add(new UC_ColumnChart_2());
                    columnControlList.Add(new UC_ColumnChart_3());
                    columnControlList.Add(new UC_ColumnChart_4());
                    columnChartTab.UserControlList = columnControlList;

                    tabItem.Content = columnChartTab;
                    break;
                case "LineChart":
                    UserControl_TabContent lineChartTab = new UserControl_TabContent();
                    lineChartTab.TabLabelTitle = tabHead;

                    List<UserControl> lineControlList = new List<UserControl>();
                    lineControlList.Add(new UC_LineChart_1());
                    lineControlList.Add(new UC_LineChart_2());
                    lineControlList.Add(new UC_LineChart_3());
                    lineChartTab.UserControlList = lineControlList;

                    tabItem.Content = lineChartTab;
                    break;
                case "RowChart":
                    UserControl_TabContent rowChartTab = new UserControl_TabContent();
                    rowChartTab.TabLabelTitle = tabHead;

                    List<UserControl> rowControlList = new List<UserControl>();
                    rowControlList.Add(new UC_RowChart_1());
                    rowChartTab.UserControlList = rowControlList;

                    tabItem.Content = rowChartTab;
                    break;
            }
        }
    }
}
