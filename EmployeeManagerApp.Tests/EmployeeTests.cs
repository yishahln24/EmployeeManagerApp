using NUnit.Framework;
using EmployeeManagerApp.Models;
using System;

namespace EmployeeManagerApp.Tests
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void CalculateAnnualBonus_ValidSalary_ReturnsTenPercent()
        {
            var employee = new Employee { Salary = 60000m };
            decimal expectedBonus = 6000m;

            decimal actualBonus = employee.CalculateAnnualBonus();

            Assert.AreEqual(expectedBonus, actualBonus);
        }

        [Test]
        public void CalculateAnnualBonus_NegativeSalary_ThrowsArgumentException()
        {
            var employee = new Employee { Salary = -5000m };
            Assert.Throws<ArgumentException>(() => employee.CalculateAnnualBonus());
        }
    }
}