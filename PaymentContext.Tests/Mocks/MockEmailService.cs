using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.Services;

namespace PaymentContext.Tests.Mocks
{
    public class MockEmailService : IEmailService
    {
        public void Send(string to, string email, string subject, string body)
        {            
        }
    }
}