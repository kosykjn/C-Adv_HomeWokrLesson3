using System.Windows;

namespace homeWorkLesson3_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly StopWatcher stopWatcher;
        public MainWindow()
        {
            InitializeComponent();

            stopWatcher = new StopWatcher();

            stopWatcher.Updated += timeSpan =>
            {
                timerOutput.Text = timeSpan.ToString(@"mm\:ss");
            };
        }

        private void ButtonStartClick(object sender, RoutedEventArgs e)
        {
            stopWatcher.Start();
        }

        private void ButtonStopClick(object sender, RoutedEventArgs e)
        {
            stopWatcher.Stop();
        }

        private void ButtonResetClick(object sender, RoutedEventArgs e)
        {
            stopWatcher.Reset();
        }
    }
}
