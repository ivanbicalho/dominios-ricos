namespace PaymentContext.Shared.Commands
{
    public interface ICommand
    {
        // Fail Fast Validations
        // Commands também podem ser Notifiables
        
        void Validate();
    }
}