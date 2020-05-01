﻿using System;
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
    /// UC_LineChart_1.xaml 的交互逻辑
    /// </summary>
    public partial class UC_LineChart_5 : UserControl
    {

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
        //图例的位置
        public LegendLocation LegendLocation { get; set; }


        public UC_LineChart_5()
        {
            InitializeComponent();
            ChartName = "Tooltip（悬停提示框）自定义";

            Series = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Title = "Mike",
                            Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
                        },
                        new LineSeries
                        {
                            Title = "Jane",
                            Values = new ChartValues<double> { 2, 3, 6, 6 ,2 }
                        },
                        new LineSeries
                        {
                            Title = "Susan",
                            Values = new ChartValues<double> { 6, 1, 3, 4 ,5 }
                        },
                    };

            //坐标轴的Title
            Axis_X_Title = "月份";
            Axis_Y_Title = "单价";
            //x轴坐标的标签（当数量大于当前数据的数量，多出的部分，图表中不显示）
            Axis_X_Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" };
            //y轴坐标，字符串格式化，“C”表示格式化成货币
            Axis_Y_LabelFormatter = value => value.ToString("C");
            //设置图例的位置在右侧
            LegendLocation = LegendLocation.Right;
            DataContext = this;
        }

    }
}
