using DPKafkaJsonSenderWPF.Models;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Windows;

namespace DPKafkaJsonSenderWPF.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private List<AddressModel> TestAddressses;

        private string title = "Формирование JSON для ГУ kafka";
        private ClientModel client;

        public string Title { get => title; set => SetProperty(ref title, value); }
        public ClientModel Client { get => client; set => SetProperty(ref client, value); }

        public void RaiseClientModel() => RaisePropertyChanged(nameof(Client));

        public DelegateCommand GetRandomAddressModelCommand { get; set; }
        public DelegateCommand CopyRegistrationAddressToHomeAddressCommand { get; set; }
        public DelegateCommand CopyLinkResponceCommand { get; set; }
        public DelegateCommand CopyPassportResponceCommand { get; set; }
        public DelegateCommand CopyCommonResponceCommand { get; set; }

        public MainWindowViewModel()
        {
            Client = new ClientModel();
            GetRandomAddressModelCommand = new DelegateCommand(OnGetRandomAddress);
            CopyRegistrationAddressToHomeAddressCommand = new DelegateCommand(OnCopyRegistrationAddressToHomeAddress);
            CopyLinkResponceCommand = new DelegateCommand(OnCopyLinkResponce);
            CopyPassportResponceCommand = new DelegateCommand(OnCopyPassportResponce);
            CopyCommonResponceCommand = new DelegateCommand(OnCopyCommonResponce);
            FillTestAddresses();
        }
        private void FillTestAddresses()
        {
            TestAddressses = new List<AddressModel>();
            TestAddressses.Add(new AddressModel()
            {
                AddressStr = "Респ. Алтай, г. Горно-Алтайск, ул. Абаканская, д. 1",

            });
        }

        private void OnGetRandomAddress()
        {

        }
        private void OnCopyRegistrationAddressToHomeAddress()
        {
            Client.HomeAddress = (AddressModel)Client.RegistrationAddress.Clone();
        }
        private void OnCopyLinkResponce() => Clipboard.SetText(Client.LinkResponce);
        private void OnCopyPassportResponce() => Clipboard.SetText(Client.PassportResponce);
        private void OnCopyCommonResponce() => Clipboard.SetText(Client.CommonResponce);
    }
}
