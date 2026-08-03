using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Shared.DTOs.Payments
{
    public class UpdatePaymentDTO
    {
        public UpdatePaymentDTO(int paymentID, int reservationID, decimal amount, string paymentMethod)
        {
            PaymentID = paymentID;
            ReservationID = reservationID;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }

        public int PaymentID { get; set; }
        public int ReservationID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}
