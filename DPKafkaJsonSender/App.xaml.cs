using DPKafkaJsonSender.Views;
using Prism.Ioc;
using System.Windows;

namespace DPKafkaJsonSender
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            try
            {
                Window shell = (Window)Container.Resolve(typeof(MainWindow));
                return shell;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + ex.InnerException.Message + ex.InnerException.StackTrace);
            }
            return null;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
