using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Payments
{
    public class PaymentListDTO
    {
        public PaymentListDTO(int paymentID, int reservationID, decimal amount, string paymentMethod, DateTime paymentDate)
        {
            PaymentID = paymentID;
            ReservationID = reservationID;
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaymentDate = paymentDate;
        }

        public int PaymentID { get; set; }
        public int ReservationID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
