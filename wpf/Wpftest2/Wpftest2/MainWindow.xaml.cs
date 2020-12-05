using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Wpftest2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 時刻表示用タイマー
        /// </summary>
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            //タイマー生成
            timer = CreateTimer();
        }
        /// <summary>
        /// タイマー生成処理
        /// </summary>
        /// <return>生成したタイマー///</return>
        private DispatcherTimer CreateTimer()
        {
            //タイマー動作の生成
            var t = new DispatcherTimer(DispatcherPriority.SystemIdle);

            //タイマー動作の間隔を300ミリ秒に設定
            t.Interval = TimeSpan.FromMilliseconds(300);

            //タイマー動作の定義
            t.Tick += (sender, e) =>
            {
                //現在の時刻表示をテキストに設定
                textBlock.Text = DateTime.Now.ToString("HH:mm:ss");
            };

            return t;


        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            timer.Start();
        }
    }

}
