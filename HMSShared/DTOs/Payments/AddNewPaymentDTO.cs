using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Payments
{
    public class AddNewPaymentDTO
    {
        public AddNewPaymentDTO(int reservationID, decimal amount, string paymentMethod)
        {
            ReservationID = reservationID;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }

        public int ReservationID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}
