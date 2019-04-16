using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {        
        public Email(string address)
        {
            Address  = address;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Address, nameof(Email.Address), "Email inválido"));
        }

        public string Address { get; private set; }
    }
}