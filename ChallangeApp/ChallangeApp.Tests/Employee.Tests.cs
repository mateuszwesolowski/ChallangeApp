using NUnit.Framework;

namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void IsMinValueIsCorrent()
        {
            var employee = new Employee("Krzysztof", "Malinowski");
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);

        }

        [Test]
        public void IsMaxIsCorrent()
        {

            var employee = new Employee("Krzysztof", "Malionowski");
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(6, statistics.Max);

        }

        [Test]
        public void IsAvarageValueIsCorrent()
        {

            var employee = new Employee("Krzysztof", "Malionowski");
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Average);

        }

        [Test]

        public void WhenAddAnotherGrade_ReturnCorrectAverage()
        {
            var employee = new Employee("Krzysztof", "Jazyna");
            employee.AddGrade(4);
            employee.AddGrade(6);   
            employee.AddGrade('A');
            employee.AddGrade('c');
            employee.AddGrade("25");

            var statistics = employee.GetStatistics();

            Assert.AreEqual(39, statistics.Average);


        }

    }
}