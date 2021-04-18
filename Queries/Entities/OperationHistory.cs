using System;

namespace Queries.Entities
{
    public class OperationHistory
    {
        public int Id { get; }
        public int UserId { get; }
        public string Operation { get; }
        public DateTime Date { get; }

        public OperationHistory(int id, string operation, DateTime date)
        {
            Id = id;
            Operation = operation;
            Date = date;
        }
    }
}