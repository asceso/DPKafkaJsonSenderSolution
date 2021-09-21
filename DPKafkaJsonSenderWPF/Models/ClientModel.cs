using Prism.Mvvm;
using System;

namespace DPKafkaJsonSenderWPF.Models
{
    public class ClientModel : BindableBase
    {
        private string uid;
        private string timestamp;
        private string dtimeRequestDp;
        private string dtimeResponseDp;
        private string link;
        private string firstName;
        private string middleName;
        private string lastName;
        private string passportSeries;
        private string passportNumber;
        private string issuedBy;
        private DateTime issuedDate;
        private string issuedId;
        private string snils;
        private string inn;
        private string gender;
        private string mobilePhone;
        private string homePhone;
        private string birthPlace;
        private DateTime birthDate;
        private AddressModel registrationAddress;
        private AddressModel homeAddress;
        private bool isTrusted;

        private string linkResponce;
        private string passportResponce;
        private string commonResponce;

        public string Uid { get => RaiseLinksAndReturnField(uid); set => SetProperty(ref uid, value); }
        public string Timestamp { get => RaiseLinksAndReturnField(timestamp); set => SetProperty(ref timestamp, value); }
        public string DTimeRequestDp { get => RaiseLinksAndReturnField(dtimeRequestDp); set => SetProperty(ref dtimeRequestDp, value); }
        public string DTimeResponseDp { get => RaiseLinksAndReturnField(dtimeResponseDp); set => SetProperty(ref dtimeResponseDp, value); }
        public string Link { get => RaiseLinksAndReturnField(link); set => SetProperty(ref link, value); }
        public string FirstName { get => RaiseLinksAndReturnField(firstName); set => SetProperty(ref firstName, value); }
        public string MiddleName { get => RaiseLinksAndReturnField(middleName); set => SetProperty(ref middleName, value); }
        public string LastName { get => RaiseLinksAndReturnField(lastName); set => SetProperty(ref lastName, value); }
        public string PassportSeries { get => RaiseLinksAndReturnField(passportSeries); set => SetProperty(ref passportSeries, value); }
        public string PassportNumber { get => RaiseLinksAndReturnField(passportNumber); set => SetProperty(ref passportNumber, value); }
        public string IssuedBy { get => RaiseLinksAndReturnField(issuedBy); set => SetProperty(ref issuedBy, value); }
        public DateTime IssuedDate { get => RaiseLinksAndReturnField(issuedDate); set => SetProperty(ref issuedDate, value); }
        public string IssuedId { get => RaiseLinksAndReturnField(issuedId); set => SetProperty(ref issuedId, value); }
        public string Snils { get => RaiseLinksAndReturnField(snils); set => SetProperty(ref snils, value); }
        public string INN { get => RaiseLinksAndReturnField(inn); set => SetProperty(ref inn, value); }
        public string Gender { get => RaiseLinksAndReturnField(gender); set => SetProperty(ref gender, value); }
        public string MobilePhone { get => RaiseLinksAndReturnField(mobilePhone); set => SetProperty(ref mobilePhone, value); }
        public string HomePhone { get => RaiseLinksAndReturnField(homePhone); set => SetProperty(ref homePhone, value); }
        public string BirthPlace { get => RaiseLinksAndReturnField(birthPlace); set => SetProperty(ref birthPlace, value); }
        public DateTime BirthDate { get => RaiseLinksAndReturnField(birthDate); set => SetProperty(ref birthDate, value); }
        public AddressModel RegistrationAddress { get => RaiseLinksAndReturnField(registrationAddress); set => SetProperty(ref registrationAddress, value); }
        public AddressModel HomeAddress { get => RaiseLinksAndReturnField(homeAddress); set => SetProperty(ref homeAddress, value); }
        public bool IsTrusted { get => isTrusted; set => SetProperty(ref isTrusted, value); }

        private string RaiseLinksAndReturnField(string output_field)
        {
            RaiseLinks();
            return output_field;
        }
        private DateTime RaiseLinksAndReturnField(DateTime output_field)
        {
            RaiseLinks();
            return output_field;
        }
        private AddressModel RaiseLinksAndReturnField(AddressModel output_field)
        {
            RaiseLinks();
            return output_field;
        }
        private void RaiseLinks()
        {
            RaisePropertyChanged(nameof(LinkResponce));
            RaisePropertyChanged(nameof(PassportResponce));
            RaisePropertyChanged(nameof(CommonResponce));
        }

        public string LinkResponce
        {
            get
            {
                linkResponce = $"{{\"link\":\"{link}\"," +
                               $"\"reqKey\":\"{uid}\"," +
                               $"\"timestamp\":\"{timestamp}\"}}";
                return linkResponce;
            }
            set => SetProperty(ref linkResponce, value);
        }
        public string PassportResponce
        {
            get
            {
                passportResponce = $"{{" +
                                   $"\"reqKey\":\"{uid}\"," +
                                   $"\"typeConsent\":\"CREDIT\",\"oid\": \"$oid\"," +
                                   $"\"dtimeRequestDp\":\"{dtimeRequestDp}\",\"dtimeResponseDp\":\"{dtimeResponseDp}\"," +
                                   $"\"timestamp\":\"{timestamp}\"," +
                                   $"\"responseType\":\"RF_PASSPORT\"," +
                                   $"\"response\":" +
                                       $"{{" +
                                       $"\"firstName\":\"{firstName}\"," +
                                       $"\"middleName\":\"{middleName}\"," +
                                       $"\"lastName\":\"{lastName}\"," +
                                       $"\"series\":\"{(passportSeries == "____" ? string.Empty : passportSeries)}\"," +
                                       $"\"number\":\"{(passportNumber == "______" ? string.Empty : passportNumber)}\"," +
                                       $"\"issuedBy\":\"{issuedBy}\"," +
                                       $"\"issueDate\":\"{issuedDate:dd.MM.yyyy}\"," +
                                       $"\"issueId\":\"{(string.IsNullOrEmpty(issuedId) || issuedId == "___-___" ? string.Empty : issuedId.Replace('-', '\0'))}\"," +
                                       $"\"type\":\"RF_PASSPORT\"" +
                                       $"}}," +
                                   $"\"error\":" +
                                       $"{{" +
                                       $"\"errorSource\":\"<errorSource>\"," +
                                       $"\"errorCode\":\"<errorCode>\"," +
                                       $"\"errorDescription\":\"<errorDescription>\"," +
                                       $"\"additionalInfo\":" +
                                           $"{{\"field1\":\"<field1>\"," +
                                           $"\"field2\":\"<field2>\"}}" +
                                       $"}}" +
                                   $"}}";
                return passportResponce;
            }
            set => SetProperty(ref passportResponce, value);
        }
        public string CommonResponce
        {
            get
            {
                commonResponce = $"{{" +
                                   $"\"reqKey\":\"{uid}\"," +
                                   $"\"typeConsent\":\"CREDIT\",\"oid\": \"$oid\"," +
                                   $"\"timestamp\":\"{timestamp}\"," +
                                   $"\"responseType\":\"GENERAL\"," +
                                   $"\"response\":" +
                                       $"{{" +
                                       $"\"firstName\":\"{firstName}\"," +
                                       $"\"middleName\":\"{middleName}\"," +
                                       $"\"lastName\":\"{lastName}\"," +
                                       $"\"oid\":\"$oid\"," +
                                       $"\"snils\":\"{snils}\"," +
                                       $"\"inn\":\"{inn}\"," +
                                       $"\"gender\":\"{gender}\"," +
                                       $"\"birthDate\":\"{birthDate}\"," +
                                       $"\"birthPlace\":\"{birthPlace}\"," +
                                       $"\"citizenship\":\"RUS\"," +
                                       $"\"email\":\"example@mail.com\"," +
                                       $"\"mobilePhone\":\"{mobilePhone}\"," +
                                       $"\"homePhone\":\"{homePhone}\"," +
                                            $"\"registrationAddress\":" +
                                            $"{{" +
                                            $"\"addressStr\":\"{registrationAddress.AddressStr}\"," +
                                            $"\"countryId\":\"{registrationAddress.CountryId}\"," +
                                            $"\"zipCode\":\"{registrationAddress.ZipCode}\"," +
                                            $"\"region\":\"{registrationAddress.Region}\"," +
                                            $"\"area\":\"{registrationAddress.Area}\"," +
                                            $"\"additionArea\":\"{registrationAddress.AdditionArea}\"," +
                                            $"\"city\":\"{registrationAddress.City}\"," +
                                            $"\"district\":\"{registrationAddress.District}\"," +
                                            $"\"settlement\":\"{registrationAddress.Settlement}\"," +
                                            $"\"street\":\"{registrationAddress.Street}\"," +
                                            $"\"additionAreaStreet\":\"{registrationAddress.AdditionAreaStreet}\"," +
                                            $"\"house\":\"{registrationAddress.House}\"," +
                                            $"\"frame\":\"{registrationAddress.Frame}\"," +
                                            $"\"building\":\"{registrationAddress.Building}\"," +
                                            $"\"flat\":\"{registrationAddress.Flat}\"," +
                                            $"\"fiasCode\":\"{registrationAddress.FiasCode}\"" +
                                            $"}}," +
                                            $"\"homeAddress\":" +
                                            $"{{" +
                                            $"\"addressStr\":\"{homeAddress.AddressStr}\"," +
                                            $"\"countryId\":\"{homeAddress.CountryId}\"," +
                                            $"\"zipCode\":\"{homeAddress.ZipCode}\"," +
                                            $"\"region\":\"{homeAddress.Region}\"," +
                                            $"\"area\":\"{homeAddress.Area}\"," +
                                            $"\"additionArea\":\"{homeAddress.AdditionArea}\"," +
                                            $"\"city\":\"{homeAddress.City}\"," +
                                            $"\"district\":\"{homeAddress.District}\"," +
                                            $"\"settlement\":\"{homeAddress.Settlement}\"," +
                                            $"\"street\":\"{homeAddress.Street}\"," +
                                            $"\"additionAreaStreet\":\"{homeAddress.AdditionAreaStreet}\"," +
                                            $"\"house\":\"{homeAddress.House}\"," +
                                            $"\"frame\":\"{homeAddress.Frame}\"," +
                                            $"\"building\":\"{homeAddress.Building}\"," +
                                            $"\"flat\":\"{homeAddress.Flat}\"," +
                                            $"\"fiasCode\":\"{homeAddress.FiasCode}\"" +
                                            $"}}," +
                                       $"\"trusted\":{isTrusted.ToString().ToLower()}" +
                                       $"}}," +
                                   $"\"error\":" +
                                       $"{{" +
                                       $"\"errorSource\":\"<errorSource>\"," +
                                       $"\"errorCode\":\"<errorCode>\"," +
                                       $"\"errorDescription\":\"<errorDescription>\"," +
                                       $"\"additionalInfo\":" +
                                           $"{{\"field1\":\"<field1>\"," +
                                           $"\"field2\":\"<field2>\"}}" +
                                       $"}}" +
                                   $"}}";
                return commonResponce;
            }
            set => SetProperty(ref commonResponce, value);
        }

        public ClientModel()
        {
            Link = "https://esia-portal1.test.gosuslugi.ru/login/";
            RegistrationAddress = new AddressModel();
            HomeAddress = new AddressModel();
            IssuedDate = DateTime.Now;
            BirthDate = DateTime.Now;
        }
    }
    public class AddressModel : BindableBase, ICloneable
    {
        private string addressStr;
        private string countryId;
        private string zipCode;
        private string region;
        private string area;
        private string additionArea;
        private string city;
        private string district;
        private string settlement;
        private string street;
        private string additionAreaStreet;
        private string house;
        private string frame;
        private string building;
        private string flat;
        private string fiasCode;

        public string AddressStr { get => addressStr; set => SetProperty(ref addressStr, value); }
        public string CountryId { get => countryId; set => SetProperty(ref countryId, value); }
        public string ZipCode { get => zipCode; set => SetProperty(ref zipCode, value); }
        public string Region { get => region; set => SetProperty(ref region, value); }
        public string Area { get => area; set => SetProperty(ref area, value); }
        public string AdditionArea { get => additionArea; set => SetProperty(ref additionArea, value); }
        public string City { get => city; set => SetProperty(ref city, value); }
        public string District { get => district; set => SetProperty(ref district, value); }
        public string Settlement { get => settlement; set => SetProperty(ref settlement, value); }
        public string Street { get => street; set => SetProperty(ref street, value); }
        public string AdditionAreaStreet { get => additionAreaStreet; set => SetProperty(ref additionAreaStreet, value); }
        public string House { get => house; set => SetProperty(ref house, value); }
        public string Frame { get => frame; set => SetProperty(ref frame, value); }
        public string Building { get => building; set => SetProperty(ref building, value); }
        public string Flat { get => flat; set => SetProperty(ref flat, value); }
        public string FiasCode { get => fiasCode; set => SetProperty(ref fiasCode, value); }

        public object Clone() => MemberwiseClone();
    }
}
