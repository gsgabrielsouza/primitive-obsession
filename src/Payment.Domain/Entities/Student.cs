using Payment.Domain.ValueObjects;

namespace Payment.Domain.Entities
{
    public class Student
    {
        public Student(Name name,Document document, Email email)
        {
            Email = email;
            Name = name;
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
    }
}