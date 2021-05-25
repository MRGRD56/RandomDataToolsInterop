using System;
using System.Diagnostics;
using System.Globalization;

namespace RandomDataToolsInterop.Models
{
    public class Person
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Patronymic { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }
        
        public string Phone { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }
        
        public Passport Passport { get; set; }
        
        public Documents Documents { get; set; }
        
        public PaymentInfo PaymentInfo { get; set; }
        
        public Education Education { get; set; }
        
        public Car Car { get; set; }

        internal static Person FromRawInfo(PersonRawInfo raw)
        {
            Gender gender = null;
            if (raw.GenderCode == Gender.Male.Code)
            {
                gender = Gender.Male;
            }
            else if (raw.GenderCode == Gender.Female.Code)
            {
                gender = Gender.Female;
            }
 
            var cardDate = DateTime.ParseExact(raw.BankDate, "MM/yy", new CultureInfo("ru-RU"));
            cardDate = new DateTime(cardDate.Year, cardDate.Month, DateTime.DaysInMonth(cardDate.Year, cardDate.Month));
            
            var person = new Person
            {
                LastName = raw.LastName,
                FirstName = raw.LastName,
                Patronymic = raw.FatherName,
                DateOfBirth = DateTime.Parse(raw.DateOfBirth, new CultureInfo("ru-RU")),
                Age = raw.YearsOld,
                Phone = raw.Phone,
                Login = raw.Login,
                Password = raw.Password,
                Email = raw.Email,
                Gender = gender,
                Passport = new Passport
                {
                    Series = raw.PasportSerial,
                    Number = raw.PasportNumber.ToString(),
                    FullNumber = raw.PasportNum,
                    LivingAddress = raw.Address,
                    RegistrationAddress = raw.AddressReg,
                    Country = raw.Country,
                    Region = raw.Region,
                    City = raw.City,
                    Street = raw.Street,
                    House = raw.House,
                    Apartment = raw.Apartment,
                    Code = raw.PasportCode,
                    IssuedBy = raw.PasportOtd,
                    IssueDate = DateTime.Parse(raw.PasportDate, new CultureInfo("ru-RU"))
                },
                Documents = new Documents
                {
                    InnFiz = raw.InnFiz,
                    Kpp = raw.Kpp.ToString(),
                    Ogrn = raw.Ogrn,
                    Oms = raw.Oms.ToString(),
                    Snils = raw.Snils,
                    InnUr = raw.InnUr
                },
                PaymentInfo = new PaymentInfo
                {
                    Bik = raw.BankBik.ToString(),
                    Corr = raw.BankCorr,
                    Inn = raw.BankInn.ToString(),
                    Kpp = raw.BankKpp.ToString(),
                    Num = raw.BankNum,
                    Client = raw.BankClient,
                    CardNumber = raw.BankCard,
                    CardDate = cardDate,
                    CardCvc = raw.BankCvc.ToString()
                },
                Education = new Education
                {
                    Name = raw.EduName,
                    Program = raw.EduProgram,
                    Specialty = raw.EduSpecialty,
                    Year = raw.EduYear,
                    DocumentNumber = raw.EduDocNum,
                    RegistrationNumber = raw.EduRegNumber
                },
                Car = new Car
                {
                    Brand = raw.CarBrand,
                    Color = raw.CarColor,
                    Model = raw.CarModel,
                    Number = raw.CarNumber,
                    Pts = raw.CarPts,
                    Sts = raw.CarSts,
                    Vin = raw.CarVin,
                    Year = raw.CarYear,
                    PtsDate = DateTime.Parse(raw.CarPtsDate, new CultureInfo("ru-RU")),
                    StsDate = DateTime.Parse(raw.CarStsDate, new CultureInfo("ru-RU"))
                }
            };

            return person;
        }
    }
}