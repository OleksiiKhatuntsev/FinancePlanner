namespace Domain
{
    public class Operation
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public decimal Amount { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public Guid CurrencyId { get; set; }

        public Currency Currency { get; set; }

        public Guid OperationTypeId { get; set; }

        public OperationType OperationType { get; set; }
    }
}