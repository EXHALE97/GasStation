using System;

namespace Queries.Entities
{
    public class Client
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string MiddleName { get; }
        public int CardId { get; }
        public int DiscountPercent { get; }
        public DateTime ActivationDate { get; }
        public int CredId { get; }

        public Client(int id, string firstName, string lastName, string middleName, int cardId, int discountPercent, DateTime activationDate, int credId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            CardId = cardId;
            DiscountPercent = discountPercent;
            ActivationDate = activationDate;
            CredId = credId;
        }

        public Client(string firstName, string lastName, string middleName, int cardId)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            CardId = cardId;
        }
    }
}
