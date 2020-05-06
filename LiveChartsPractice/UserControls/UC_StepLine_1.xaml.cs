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
    /// UC_StepLine_1.xaml 的交互逻辑
    /// </summary>
    public partial class UC_StepLine_1 : UserControl
    {
        public string ChartName { get; set; }
        public string Description { get; set; }
        public UC_StepLine_1()
        {
            InitializeComponent();
            ChartName = "StepLine";
            Description = "代码全部在xaml前端写成：\n"+
                "Pork线条采用默认值，Beef线条自定义粗细StrokeThickness=\"5\"，" +
                "Lamb线条自定义垂直颜色为透明AlternativeStroke=\"Transparent\""+
                "\nx轴横坐标Lables属性，定义坐标轴的标签，值之间用英文逗号分隔";
            DataContext = this;
        }
    }
}
