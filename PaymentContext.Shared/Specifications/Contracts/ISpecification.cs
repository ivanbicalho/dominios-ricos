using PaymentContext.Shared.Validations;

namespace PaymentContext.Shared.Specifications
{
    public interface ISpecification
    {
        Contract Contract { get; }
    }
}