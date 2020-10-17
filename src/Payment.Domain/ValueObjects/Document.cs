using Payment.Domain.Enums;

namespace Payment.Domain.ValueObjects
{
    public class Document
    {
        public Document(string number, EDocumentType documentType)
        {
            Number = number;
            DocumentType = documentType;
        }
        public string Number { get; private set; }
        public EDocumentType DocumentType { get; private set; }
    }
}