using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Currencies.Any()) {return; }

            var operationTypes = new List<OperationType>
            {
                new OperationType
                {
                    Title = "Purchase"
                },
                new OperationType
                {
                    Title = "Refill"
                }
            };

            await context.OperationTypes.AddRangeAsync(operationTypes);
            await context.SaveChangesAsync();


            var currencies = new List<Currency>
            {
                new Currency
                {
                    Title = "USD"
                },
                new Currency
                {
                    Title = "EUR"
                },
                new Currency
                {
                    Title = "UAH"
                },
                new Currency
                {
                    Title = "PLN"
                }
            };

            await context.Currencies.AddRangeAsync(currencies);
            await context.SaveChangesAsync();


            var users = new List<User>
            {
                new User
                {
                    Name = "Alex",
                    Email = "alex@gmail.com",
                    Password = "qwerty123",
                    CurrencyId = context.Currencies.First(x => x.Title == "USD").Id
                },
                new User
                {
                    Name = "Sasha",
                    Email = "sasha@gmail.com",
                    Password = "qwerty123",
                    CurrencyId = context.Currencies.First(x => x.Title == "EUR").Id
                }
            };

            await context.Users.AddRangeAsync(users);
            await context.SaveChangesAsync();

            var operations = new List<Operation>
            {
                new Operation
                {
                    Title = "Compensation",
                    Amount = 2500,
                    OperationTypeId = context.OperationTypes.First(ot => ot.Title == "Refill").Id,
                    CurrencyId = context.Currencies.First(x => x.Title == "USD").Id,
                    UserId = context.Users.First(x => x.Email == "alex@gmail.com").Id,
                },
                new Operation
                {
                    Title = "Kaufland",
                    Amount = 50,
                    OperationTypeId = context.OperationTypes.First(ot => ot.Title == "Purchase").Id,
                    CurrencyId = context.Currencies.First(x => x.Title == "USD").Id,
                    UserId = context.Users.First(x => x.Email == "alex@gmail.com").Id,
                },
                new Operation
                {
                    Title = "Zoo",
                    Amount = 10,
                    OperationTypeId = context.OperationTypes.First(ot => ot.Title == "Purchase").Id,
                    CurrencyId = context.Currencies.First(x => x.Title == "EUR").Id,
                    UserId = context.Users.First(x => x.Email == "sasha@gmail.com").Id,
                }
            };

            await context.Operations.AddRangeAsync(operations);
            await context.SaveChangesAsync();
        }
    }
}