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
        internal string LastName { get; set; }

        [JsonProperty("FirstName")]
        internal string FirstName { get; set; }

        [JsonProperty("FatherName")]
        internal string FatherName { get; set; }

        [JsonProperty("DateOfBirth")]
        internal string DateOfBirth { get; set; }

        [JsonProperty("YearsOld")]
        internal int YearsOld { get; set; }

        [JsonProperty("Phone")]
        internal string Phone { get; set; }

        [JsonProperty("Login")]
        internal string Login { get; set; }

        [JsonProperty("Password")]
        internal string Password { get; set; }

        [JsonProperty("Email")]
        internal string Email { get; set; }

        [JsonProperty("Gender")]
        internal string Gender { get; set; }

        [JsonProperty("GenderCode")]
        internal string GenderCode { get; set; }

        [JsonProperty("PasportNum")]
        internal string PasportNum { get; set; }

        [JsonProperty("PasportSerial")]
        internal string PasportSerial { get; set; }

        [JsonProperty("PasportNumber")]
        internal int PasportNumber { get; set; }

        [JsonProperty("PasportCode")]
        internal string PasportCode { get; set; }

        [JsonProperty("PasportOtd")]
        internal string PasportOtd { get; set; }

        [JsonProperty("PasportDate")]
        internal string PasportDate { get; set; }

        [JsonProperty("inn_fiz")]
        internal string InnFiz { get; set; }

        [JsonProperty("inn_ur")]
        internal string InnUr { get; set; }

        [JsonProperty("snils")]
        internal string Snils { get; set; }

        [JsonProperty("oms")]
        internal long Oms { get; set; }

        [JsonProperty("ogrn")]
        internal string Ogrn { get; set; }

        [JsonProperty("kpp")]
        internal int Kpp { get; set; }

        [JsonProperty("Address")]
        internal string Address { get; set; }

        [JsonProperty("AddressReg")]
        internal string AddressReg { get; set; }

        [JsonProperty("Country")]
        internal string Country { get; set; }

        [JsonProperty("Region")]
        internal string Region { get; set; }

        [JsonProperty("City")]
        internal string City { get; set; }

        [JsonProperty("Street")]
        internal string Street { get; set; }

        [JsonProperty("House")]
        internal int House { get; set; }

        [JsonProperty("Apartment")]
        internal int Apartment { get; set; }

        [JsonProperty("bankBIK")]
        internal int BankBik { get; set; }

        [JsonProperty("bankCorr")]
        internal string BankCorr { get; set; }

        [JsonProperty("bankINN")]
        internal long BankInn { get; set; }

        [JsonProperty("bankKPP")]
        internal int BankKpp { get; set; }

        [JsonProperty("bankNum")]
        internal string BankNum { get; set; }

        [JsonProperty("bankClient")]
        internal string BankClient { get; set; }

        [JsonProperty("bankCard")]
        internal string BankCard { get; set; }

        [JsonProperty("bankDate")]
        internal string BankDate { get; set; }

        [JsonProperty("bankCVC")]
        internal int BankCvc { get; set; }

        [JsonProperty("EduSpecialty")]
        internal string EduSpecialty { get; set; }

        [JsonProperty("EduProgram")]
        internal string EduProgram { get; set; }

        [JsonProperty("EduName")]
        internal string EduName { get; set; }

        [JsonProperty("EduDocNum")]
        internal string EduDocNum { get; set; }

        [JsonProperty("EduRegNumber")]
        internal string EduRegNumber { get; set; }

        [JsonProperty("EduYear")]
        internal int EduYear { get; set; }

        [JsonProperty("CarBrand")]
        internal string CarBrand { get; set; }

        [JsonProperty("CarModel")]
        internal string CarModel { get; set; }

        [JsonProperty("CarYear")]
        internal int CarYear { get; set; }

        [JsonProperty("CarColor")]
        internal string CarColor { get; set; }

        [JsonProperty("CarNumber")]
        internal string CarNumber { get; set; }

        [JsonProperty("CarVIN")]
        internal string CarVin { get; set; }

        [JsonProperty("CarSTS")]
        internal string CarSts { get; set; }

        [JsonProperty("CarSTSDate")]
        internal string CarStsDate { get; set; }

        [JsonProperty("CarPTS")]
        internal string CarPts { get; set; }

        [JsonProperty("CarPTSDate")]
        internal string CarPtsDate { get; set; }
    }
}