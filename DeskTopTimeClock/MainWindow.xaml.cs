using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace DesktopClock
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑 更多资料微信/B站关注 < 香辣恐龙蛋 >
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _Timer = new DispatcherTimer();
        string[] _ChineseHour = null;
        double _Scale;
        public MainWindow()
        {
            InitializeComponent();

            _ChineseHour = new string[] {
                /*  1      2        3       4       5       6       7      8*/
                "丑初", "丑正", "寅初", "寅正" ,"卯初", "卯正", "辰初", "辰正" ,

                /*  9      10           11                 12             13       14      15     16*/
                "巳初", "巳正 大荒落", "午初 阳气炽盛", "午正 阴阳交相" ,"未初", "未正", "申初", "申正" ,
            
                /* 17      18      19      20      21      22      23     24*/
                "酉初", "酉正", "戌初", "戌正" ,"亥初", "子正 阳气始萌", "子初 一阳生", "子正 阳气始萌" };

            _Timer.Interval = TimeSpan.FromSeconds(1);
            _Timer.Tick += new EventHandler(Update_Time);
            _Timer.Start();
            _Scale = this.ViewBox_Clock.RenderTransform.Value.M11;
        }

        private void Update_Time(object sender, EventArgs e)
        {
            this.Lable_ModernClock.Content = $"{DateTime.Now.Hour.ToString("00")} : {DateTime.Now.Minute.ToString("00")} : {DateTime.Now.Second.ToString("00")}";
            this.Lable_ChineseClock.Content = _ChineseHour[DateTime.Now.Hour == 24 ? 0 : DateTime.Now.Hour - 1];
            this.Lable_Day.Content = $"{DateTime.Now.Month.ToString("00")} - {DateTime.Now.Day.ToString("00")} - {DateTime.Now.Year.ToString().Substring(2, 2)}";
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                if (e.Delta > 0 && _Scale < 10)
                {
                    _Scale += 0.02;

                }
                else
                {
                    if (_Scale > 0.2)
                    {
                        _Scale -= 0.02;
                    }
                }
            }

            ScaleTransform scaleTransform = new ScaleTransform();
            scaleTransform.ScaleX = scaleTransform.ScaleY = _Scale;
            this.ViewBox_Clock.RenderTransform = scaleTransform;
        }
    }
}
