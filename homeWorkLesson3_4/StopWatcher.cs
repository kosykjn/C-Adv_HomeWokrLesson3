using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace homeWorkLesson3_4
{
    public class StopWatcher
    {
        private readonly Stopwatch stopwatch;
        private Timer timer;

        public event Action<TimeSpan> Updated;
        public void OnUpdated(object sWatch)
        {
            if (Application.Current.Dispatcher != null)
                Application.Current.Dispatcher.Invoke(() =>
                {
                    Updated?.Invoke(((Stopwatch)sWatch).Elapsed);
                });
        }

        public StopWatcher()
        {
            stopwatch = new Stopwatch();
        }

        public void Start ()
        {
            stopwatch.Start();
            timer = new Timer(OnUpdated, stopwatch, 0, 1000);
        }
        public void Stop()
        {
            stopwatch.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
        public void Reset()
        {
            stopwatch.Reset();
            OnUpdated(stopwatch);
        }
    }
}
