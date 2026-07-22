using HMSDataAccessLayer;
using System;
using System.Collections.Generic;

namespace HMSBusinessLayer
{
    public class clsPaymentsBusiness
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        public int PaymentID { get; set; }
        public int ReservationID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }

        public PaymentListDTO PaymentListDto
        {
            get
            {
                return new PaymentListDTO(
                    this.PaymentID,
                    this.ReservationID,
                    this.Amount,
                    this.PaymentMethod,
                    this.PaymentDate
                );
            }
        }

        public AddNewPaymentDTO AddNewPaymentDto
        {
            get
            {
                return new AddNewPaymentDTO(
                    this.ReservationID,
                    this.Amount,
                    this.PaymentMethod
                );
            }
        }

        public UpdatePaymentDTO UpdatePaymentDto
        {
            get
            {
                return new UpdatePaymentDTO(
                    this.PaymentID,
                    this.ReservationID,
                    this.Amount,
                    this.PaymentMethod
                );
            }
        }

        public clsPaymentsBusiness(PaymentListDTO dto, enMode cMode = enMode.AddNew)
        {
            this.PaymentID = dto.PaymentID;
            this.ReservationID = dto.ReservationID;
            this.Amount = dto.Amount;
            this.PaymentMethod = dto.PaymentMethod;
            this.PaymentDate = dto.PaymentDate;
            this.Mode = cMode;
        }

        public static List<PaymentListDTO> GetAllPayments()
        {
            return clsPaymentsData.GetAllPayments();
        }

        public static clsPaymentsBusiness Find(int paymentID)
        {
            PaymentListDTO dto = clsPaymentsData.GetPaymentByID(paymentID);

            if (dto != null)
                return new clsPaymentsBusiness(dto, enMode.Update);

            return null;
        }

        public static List<PaymentListDTO> GetByReservationID(int reservationID)
        {
            return clsPaymentsData.GetPaymentsByReservationID(reservationID);
        }

        public static bool DeletePayment(int paymentID)
        {
            return clsPaymentsData.DeletePayment(paymentID);
        }

        private bool _AddNewPayment()
        {
            this.PaymentID = clsPaymentsData.AddNewPayment(AddNewPaymentDto);
            return this.PaymentID != -1;
        }

        private bool _UpdatePayment()
        {
            return clsPaymentsData.UpdatePayment(UpdatePaymentDto);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePayment();
            }

            return false;
        }
    }
}
