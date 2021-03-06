using DPKafkaJsonSenderWPF.ViewModels;
using System.Windows;

namespace DPKafkaJsonSenderWPF.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly string DTimeFormat = "yyyy-MM-dd HH:mm:ss.fff";
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            CalculateTime();
        }
        private void CalculateTimeClick(object sender, RoutedEventArgs e)
        {
            CalculateTime();
        }
        private void CalculateTime()
        {
            TimeStampControl.SelectedTime = System.DateTime.Now.AddMinutes(2);
            RequestStampControl.SelectedTime = System.DateTime.Now.AddMinutes(1);
            ResponceStampControl.SelectedTime = System.DateTime.Now.AddMinutes(1).AddSeconds(1);

            if (DataContext is MainWindowViewModel vm)
            {
                vm.Client.Timestamp = TimeStampControl.SelectedTime.ToString(DTimeFormat);
                vm.Client.DTimeRequestDp = RequestStampControl.SelectedTime.ToString(DTimeFormat);
                vm.Client.DTimeResponseDp = ResponceStampControl.SelectedTime.ToString(DTimeFormat);
                vm.RaiseClientModel();
            }
        }
        private void TimeStampTimeChanged(object sender, HandyControl.Data.FunctionEventArgs<System.DateTime> e)
        {
            if (DataContext is MainWindowViewModel vm)
            {
                if (sender is HandyControl.Controls.TimeBar tb)
                {
                    string time_string = e.Info.ToString(DTimeFormat);
                    if (tb.Name == "TimeStampControl")
                    {
                        vm.Client.Timestamp = time_string;
                    }
                    else if (tb.Name == "RequestStampControl")
                    {
                        vm.Client.DTimeRequestDp = time_string;
                    }
                    else if (tb.Name == "ResponceStampControl")
                    {
                        vm.Client.DTimeResponseDp = time_string;
                    }
                }
                vm.RaiseClientModel();
            }
        }
    }
}
