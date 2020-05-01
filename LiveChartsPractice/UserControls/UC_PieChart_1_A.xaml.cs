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
    public partial class UC_PieChart_1_A : UserControl
    {
        //窗口下面的描述文字
        public string Description { get; set; }
        //图表的名称
        public string ChartName { get; set; }
        //LabelPoint的格式化工具
        public Func<ChartPoint, string> _LabelPoint { get; set; }

        public UC_PieChart_1_A()
        {
            InitializeComponent();

            Description = "关闭悬停的时候产生“分裂”动画效果Hoverable=\"True\"，在单击的时候单独设置这一项的弹出距离" +
                "\nselectedSeries.PushOut = 28"+ "\nDataLabels=\"True\""+
                "\nDataLabel示Value值和百分比，直接从图标上看没问题。但是在Tooltip中，除了显示DataLabel还自带显示百分比，所有出现了重复。";
            ChartName = "基本饼图（单击事件),并显示DataLabel\n格式化输出LabelPoint";

            //格式化LabelPoint中显示的文字（第一项显示Value值，第二项显示百分比）
            //这样输出在图标上直接看没什么问题，但是到了Tooltip中，内容就重复了。
            _LabelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataContext = this;
        }

        private void Chart_1_DataClick(object sender, ChartPoint chartPoint)
        {
            PieChart chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            //让选中的实体弹出
            var selectedSeries = (PieSeries)chartPoint.SeriesView;
            selectedSeries.PushOut = 28;
        }
    }
}
