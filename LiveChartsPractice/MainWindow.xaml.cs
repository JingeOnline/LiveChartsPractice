﻿using System;
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

        private void TabControl_HomePage1_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
                    columnControlList.Add(new UC_ColumnChart_2_A());
                    columnControlList.Add(new UC_ColumnChart_2_B());
                    columnControlList.Add(new UC_ColumnChart_2_C());
                    columnControlList.Add(new UC_ColumnChart_2_D());
                    columnControlList.Add(new UC_ColumnChart_2_E());
                    columnControlList.Add(new UC_ColumnChart_2_F());
                    columnControlList.Add(new UC_ColumnChart_2_G());
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
                    lineControlList.Add(new UC_LineChart_4());
                    lineControlList.Add(new UC_LineChart_5());
                    lineControlList.Add(new UC_LineChart_6());
                    lineControlList.Add(new UC_LineChart_4_A());
                    lineControlList.Add(new UC_LineChart_4_B());
                    lineChartTab.UserControlList = lineControlList;

                    tabItem.Content = lineChartTab;
                    break;
                case "StepLine":
                    UserControl_TabContent stepLineTab = new UserControl_TabContent();
                    stepLineTab.TabLabelTitle = tabHead;

                    List<UserControl> stepLineList = new List<UserControl>();
                    stepLineList.Add(new UC_StepLine_1());
                    stepLineTab.UserControlList = stepLineList;

                    tabItem.Content = stepLineTab;
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
                case "ScatterPlot":
                    UserControl_TabContent scatterPlotTab = new UserControl_TabContent();
                    scatterPlotTab.TabLabelTitle = tabHead;

                    List<UserControl> scatterControlList = new List<UserControl>();
                    scatterControlList.Add(new UC_ScatterPlot_1());
                    scatterPlotTab.UserControlList = scatterControlList;
                    tabItem.Content = scatterPlotTab;
                    break;
                case "PieChart":
                    UserControl_TabContent pieChartTab = new UserControl_TabContent();
                    pieChartTab.TabLabelTitle = tabHead;

                    List<UserControl> pieControlList = new List<UserControl>();
                    pieControlList.Add(new UC_PieChart_1());
                    pieControlList.Add(new UC_PieChart_1_A());
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

        private void TabControl_HomePage2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl tabControl = (TabControl)e.Source;
            TabItem tabItem = tabControl.SelectedItem as TabItem;
            String tabHead = tabItem.Header.ToString();
            switch (tabHead)
            {
                case "HeatSeries":
                    UserControl_TabContent heatTab = new UserControl_TabContent();
                    heatTab.TabLabelTitle = tabHead;

                    List<UserControl> heatList = new List<UserControl>();
                    heatList.Add(new UC_HeatSeries_1());
                    heatTab.UserControlList = heatList;

                    tabItem.Content = heatTab;
                    break;
                case "GeoHeatMap":
                    UserControl_TabContent geoTab = new UserControl_TabContent();
                    geoTab.TabLabelTitle = tabHead;
                    List<UserControl> geoList = new List<UserControl>();
                    geoList.Add(new UC_GeoHeatMap_1());
                    geoTab.UserControlList = geoList;

                    tabItem.Content = geoTab;
                    break;
            }
        }

        //切换面板的按钮
        private void Button_SwitchTabControl_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl_HomePage1.Visibility == Visibility.Visible)
            {
                TabControl_HomePage1.Visibility = Visibility.Collapsed;
                TabControl_HomePage2.Visibility = Visibility.Visible;
                TextBlock_Switch.Text = "Last Page";
                TextBlock_SwitchIcon.Text = "\xE72B";
            }
            else
            {
                TabControl_HomePage1.Visibility = Visibility.Visible;
                TabControl_HomePage2.Visibility = Visibility.Collapsed;
                TextBlock_Switch.Text = "Next Page";
                TextBlock_SwitchIcon.Text = "\xE72A";
            }
        }
    }
}
