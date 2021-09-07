using DPKafkaJsonSender.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows;

namespace DPKafkaJsonSender.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string title = "Формирование JSON для ГУ kafka";
        private ClientModel client;

        public string Title { get => title; set => SetProperty(ref title, value); }
        public ClientModel Client { get => client; set => SetProperty(ref client, value); }

        public void RaiseClientModel() => RaisePropertyChanged(nameof(Client));

        public DelegateCommand CopyLinkResponceCommand { get; set; }
        public DelegateCommand CopyPassportResponceCommand { get; set; }
        public DelegateCommand CopyCommonResponceCommand { get; set; }

        public MainWindowViewModel()
        {
            Client = new ClientModel();
            CopyLinkResponceCommand = new DelegateCommand(OnCopyLinkResponce);
            CopyPassportResponceCommand = new DelegateCommand(OnCopyPassportResponce);
            CopyCommonResponceCommand = new DelegateCommand(OnCopyCommonResponce);
        }
        private void OnCopyLinkResponce() => Clipboard.SetText(Client.LinkResponce);
        private void OnCopyPassportResponce() => Clipboard.SetText(Client.PassportResponce);
        private void OnCopyCommonResponce() => Clipboard.SetText(Client.CommonResponce);
    }
}
