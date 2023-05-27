namespace Domain
{
    public class Currency
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<Operation> Operations { get; set; }
    }
}