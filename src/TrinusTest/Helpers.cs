using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace TrinusTest
{
    public sealed class DelayAction : Microsoft.Xaml.Behaviors.EventTrigger
    {
        private EventArgs _eventArgs;
        private DispatcherTimer _delayTimer;

        public static readonly DependencyProperty DelayProperty =
            DependencyProperty.Register("Delay", typeof(double)
            , typeof(DelayAction), new PropertyMetadata(0.0));

        public double Delay
        {
            get { return (double)base.GetValue(DelayProperty); }
            set { base.SetValue(DelayProperty, value); }
        }

        protected override void OnDetaching()
        {
            if (_delayTimer != null)
            {
                _delayTimer.Stop();
                _delayTimer = null;
            }
            base.OnDetaching();
        }

        protected override void OnEvent(EventArgs eventArgs)
        {
            if (_delayTimer != null)
            {
                _delayTimer.Stop();
            }
            _eventArgs = eventArgs;
            _delayTimer = new DispatcherTimer();
            _delayTimer.Interval = TimeSpan.FromMilliseconds(this.Delay);
            _delayTimer.Tick += new EventHandler(TimerTick);
            _delayTimer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this._delayTimer.Stop();
            base.InvokeActions(this._eventArgs);
        }
    }
}
