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
    /// UC_PieChart_1.xaml 的交互逻辑
    /// </summary>
    public partial class UC_PieChart_1 : UserControl
    {
        //窗口下面的描述文字
        public string Description { get; set; }
        //图表的名称
        public string ChartName { get; set; }

        public UC_PieChart_1()
        {
            InitializeComponent();

            Description = "基本饼图（完全xaml），只设置了Title名称和Value的数值，他就会自动生成百分比的饼图。";
            ChartName = "基本饼图（完全xaml）";
            DataContext = this;
        }
    }
}
