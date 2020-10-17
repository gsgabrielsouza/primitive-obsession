using System;
using Payment.Domain.ValueObjects;

namespace Payment.Domain
{
    public class PaymentMethod
    {
        public PaymentMethod(Email email, Document document)
        {
            Email = email;
            Document = document;
        }
        public DateTime PaidDate { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
    }
}