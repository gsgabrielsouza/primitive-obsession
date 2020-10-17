using System;
using Payment.Domain.ValueObjects;

namespace Payment.Domain
{
    public class PaymentMethod
    {
        public PaymentMethod(Email email, TaxDocument document)
        {
            Email = email;
            Document = document;
        }
        public DateTime PaidDate { get; private set; }
        public TaxDocument Document { get; private set; }
        public Email Email { get; private set; }
    }
}