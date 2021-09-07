using DPKafkaJsonSender.ViewModels;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace DPKafkaJsonSender.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TimeStampControl.SelectedTime = System.DateTime.Now;
            RequestStampControl.SelectedTime = System.DateTime.Now;
            ResponceStampControl.SelectedTime = System.DateTime.Now;
        }
        private void TimeStampTimeChanged(object sender, HandyControl.Data.FunctionEventArgs<System.DateTime> e)
        {
            if (DataContext is MainWindowViewModel vm)
            {
                if (sender is HandyControl.Controls.TimeBar tb)
                {
                    string time_string = e.Info.ToString("yyyy-MM-dd HH:mm:ss.fff");
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
        private void OnlyNumbersTextPreview(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
