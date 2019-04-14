using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var student = new Student("Ivan", "Bicalho", "123456789123", "ivanribeirob@gmail.com");
            //student.FirstName = "";
        }
    }
}
