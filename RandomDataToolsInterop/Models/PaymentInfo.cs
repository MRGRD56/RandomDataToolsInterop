using System;

namespace RandomDataToolsInterop.Models
{
    public class PaymentInfo
    {
        public string Bik { get; set; }

        public string Corr { get; set; }

        public string Inn { get; set; }

        public string Kpp { get; set; }

        public string Num { get; set; }

        public string Client { get; set; }

        public string CardNumber { get; set; }

        public DateTime? CardDate { get; set; }

        public string CardCvc { get; set; }
    }
}