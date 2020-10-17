using System;
using Payment.Domain.Enums;

namespace Payment.Domain.ValueObjects
{
    public struct TaxDocument
    {
        public TaxDocument(string number)
        {
            Number = number;
            DocumentType = DocumentType.Invalid;
        }

        public TaxDocument(string number, DocumentType documentType) : this(number)
        {
            DocumentType = documentType;
        }

        public string Number { get; private set; }
        public DocumentType DocumentType { get; private set; }
        public static implicit operator TaxDocument(string input) => new TaxDocument(input);

        private void IsValid(string input)
        {
            // generic exception
            if (input.Length < 13)
                throw new Exception("generic exception");
        }
    }
}