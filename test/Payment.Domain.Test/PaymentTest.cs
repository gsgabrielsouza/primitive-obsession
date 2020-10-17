using System;
using Payment.Domain.ValueObjects;
using Xunit;

namespace Payment.Domain.Test
{
    public class PaymentTest
    {
        [Fact]
        public void NewPayment()
        {
            // var payment = new Payment("email@email.com");
            var payment = new PaymentMethod("email@email.com", "12345678912");
            Console.WriteLine(payment.Document);
            Console.WriteLine(payment.Email);
        }
    }
}
