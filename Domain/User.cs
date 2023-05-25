namespace Domain
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Guid CurrencyId { get; set; }

        public Currency Currency { get; set; }

        public ICollection<Operation> Operations { get; set; }
    }
}