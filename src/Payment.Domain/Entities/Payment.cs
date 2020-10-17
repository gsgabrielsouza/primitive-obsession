namespace Payment.Domain
{
    public class Payment
    {
        public Payment(string email)
        {
            Email = email;
        }
        public DateTime PaidDate { get; set; }
        public string Email { get; set; }
    }
}