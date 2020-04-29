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

namespace LiveChartsPractice.UserControls
{
    /// <summary>
    /// UC_AngularGauge_1.xaml 的交互逻辑
    /// </summary>
    public partial class UC_AngularGauge_1 : UserControl
    {
        //窗口下面的描述文字
        public string Description { get; set; }
        //图表的名称
        public string ChartName { get; set; }

        public UC_AngularGauge_1()
        {
            InitializeComponent();
            ChartName = "AngularGauge";
            Description = "基本角度量规，完全由xaml在前端创建，主要属性包括：" +
                "\nFromValue（起点值），ToValue（终点值），Wedge（仪表板的整体角度范围），LabelsStep（刻度数值的间距），" +
                "TicksStep（刻度间距），TicksForeground（刻度颜色），SectionsInnerRadius（色彩环的辐射宽度）";

            DataContext = this;
        }
    }
}
