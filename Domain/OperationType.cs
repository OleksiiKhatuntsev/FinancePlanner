namespace Domain
{
    public class OperationType
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public ICollection<Operation> Operations { get; set; }
    }
}