using System.Text.RegularExpressions;
namespace Payment.Domain.ValueObjects
{
    public class Email
    {
        public Email(string address)
        {
            Address = address;
            Host = address.Split('@')[1];
        }

        public string Address { get; private set; }
        public string Host { get; set; }

        public bool IsValid => new Regex("/^w+[+.w-]*@([w-]+.)*w+[w-]*.([a-z]{2,4}|d+)$/i").IsMatch(Address);

        public static implicit operator Email(string input) => new Email(input);
    }
}