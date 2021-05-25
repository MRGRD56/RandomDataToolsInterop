using Newtonsoft.Json;

namespace RandomDataToolsInterop.Models
{
    /// <summary>
    /// Raw person data. <br/>
    /// Generated from JSON by https://json2csharp.com/
    /// </summary>
    internal class PersonRawInfo
    {
        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("FatherName")]
        public string FatherName { get; set; }

        [JsonProperty("DateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("YearsOld")]
        public int YearsOld { get; set; }

        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("Login")]
        public string Login { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("GenderCode")]
        public string GenderCode { get; set; }

        [JsonProperty("PasportNum")]
        public string PasportNum { get; set; }

        [JsonProperty("PasportSerial")]
        public string PasportSerial { get; set; }

        [JsonProperty("PasportNumber")]
        public int PasportNumber { get; set; }

        [JsonProperty("PasportCode")]
        public string PasportCode { get; set; }

        [JsonProperty("PasportOtd")]
        public string PasportOtd { get; set; }

        [JsonProperty("PasportDate")]
        public string PasportDate { get; set; }

        [JsonProperty("inn_fiz")]
        public string InnFiz { get; set; }

        [JsonProperty("inn_ur")]
        public string InnUr { get; set; }

        [JsonProperty("snils")]
        public string Snils { get; set; }

        [JsonProperty("oms")]
        public long Oms { get; set; }

        [JsonProperty("ogrn")]
        public string Ogrn { get; set; }

        [JsonProperty("kpp")]
        public int Kpp { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("AddressReg")]
        public string AddressReg { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Street")]
        public string Street { get; set; }

        [JsonProperty("House")]
        public int House { get; set; }

        [JsonProperty("Apartment")]
        public int Apartment { get; set; }

        [JsonProperty("bankBIK")]
        public int BankBik { get; set; }

        [JsonProperty("bankCorr")]
        public string BankCorr { get; set; }

        [JsonProperty("bankINN")]
        public long BankInn { get; set; }

        [JsonProperty("bankKPP")]
        public int BankKpp { get; set; }

        [JsonProperty("bankNum")]
        public string BankNum { get; set; }

        [JsonProperty("bankClient")]
        public string BankClient { get; set; }

        [JsonProperty("bankCard")]
        public string BankCard { get; set; }

        [JsonProperty("bankDate")]
        public string BankDate { get; set; }

        [JsonProperty("bankCVC")]
        public int BankCvc { get; set; }

        [JsonProperty("EduSpecialty")]
        public string EduSpecialty { get; set; }

        [JsonProperty("EduProgram")]
        public string EduProgram { get; set; }

        [JsonProperty("EduName")]
        public string EduName { get; set; }

        [JsonProperty("EduDocNum")]
        public string EduDocNum { get; set; }

        [JsonProperty("EduRegNumber")]
        public string EduRegNumber { get; set; }

        [JsonProperty("EduYear")]
        public int EduYear { get; set; }

        [JsonProperty("CarBrand")]
        public string CarBrand { get; set; }

        [JsonProperty("CarModel")]
        public string CarModel { get; set; }

        [JsonProperty("CarYear")]
        public int CarYear { get; set; }

        [JsonProperty("CarColor")]
        public string CarColor { get; set; }

        [JsonProperty("CarNumber")]
        public string CarNumber { get; set; }

        [JsonProperty("CarVIN")]
        public string CarVin { get; set; }

        [JsonProperty("CarSTS")]
        public string CarSts { get; set; }

        [JsonProperty("CarSTSDate")]
        public string CarStsDate { get; set; }

        [JsonProperty("CarPTS")]
        public string CarPts { get; set; }

        [JsonProperty("CarPTSDate")]
        public string CarPtsDate { get; set; }
    }
}