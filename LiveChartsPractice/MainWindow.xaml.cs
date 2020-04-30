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
                case "BubbleChart":
                    UserControl_TabContent bubbleChartTab = new UserControl_TabContent();
                    bubbleChartTab.TabLabelTitle = tabHead;

                    List<UserControl> bubbleControlList = new List<UserControl>();
                    bubbleControlList.Add(new UC_BubbleChart_1());
                    bubbleChartTab.UserControlList = bubbleControlList;

                    tabItem.Content = bubbleChartTab;
                    break;
                case "PieChart":
                    UserControl_TabContent pieChartTab = new UserControl_TabContent();
                    pieChartTab.TabLabelTitle = tabHead;

                    List<UserControl> pieControlList = new List<UserControl>();
                    pieControlList.Add(new UC_PieChart_1());
                    pieChartTab.UserControlList = pieControlList;

                    tabItem.Content = pieChartTab;
                    break;
                case "AngularGauge":
                    UserControl_TabContent angularGaugeTab = new UserControl_TabContent();
                    angularGaugeTab.TabLabelTitle = tabHead;

                    List<UserControl> angularGaugeList = new List<UserControl>();
                    angularGaugeList.Add(new UC_AngularGauge_1());
                    angularGaugeTab.UserControlList = angularGaugeList;

                    tabItem.Content = angularGaugeTab;
                    break;
                case "Gauge":
                    UserControl_TabContent gaugeTab = new UserControl_TabContent();
                    gaugeTab.TabLabelTitle = tabHead;

                    List<UserControl> gaugeList = new List<UserControl>();
                    gaugeList.Add(new UC_SolidGauge_1());
                    gaugeTab.UserControlList = gaugeList;

                    tabItem.Content = gaugeTab;
                    break;
                case "StackedColumn":
                    UserControl_TabContent stackTab = new UserControl_TabContent();
                    stackTab.TabLabelTitle = tabHead;

                    List<UserControl> stackList = new List<UserControl>();
                    stackList.Add(new UC_StackedColumnChart_1());
                    stackTab.UserControlList = stackList;

                    tabItem.Content = stackTab;
                    break;
                case "StackedArea":
                    UserControl_TabContent stackedAreaTab = new UserControl_TabContent();
                    stackedAreaTab.TabLabelTitle = tabHead;

                    List<UserControl> stackedAreaList = new List<UserControl>();
                    stackedAreaList.Add(new UC_StackedArea_1());
                    stackedAreaTab.UserControlList = stackedAreaList;

                    tabItem.Content = stackedAreaTab;
                    break;
            }
        }
    }
}
