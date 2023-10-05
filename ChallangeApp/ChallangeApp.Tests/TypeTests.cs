namespace ChallangeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void AreTwoIntObjectEqual()
        {

            //arrange - przygotowanie
            int number1 = 2;
            int number2 = 2;

            //act - uruchmienie

            //assert - czy zostały spełnione warunki
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void AreTwoFloatObjectEqual()
        {

            //arrange - przygotowanie
            float number3 = 123456789;
            float number4 = 123456789;

            //act - uruchmienie


            //assert - czy zostały spełnione warunki

            Assert.AreEqual(number3, number4);
        }

        [Test]

        public void AreTwoStringObjectEqual()
        {
            //arrange
            string name1 = "Mateusz";
            string name2 = "Mateusz";

            //act

            //assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObject()
        {

            //arrange - przygotowanie
            var empolyee1 = GetEmployee("Mateusz");
            var employee2 = GetEmployee("Mateusz");

            //act - uruchmienie


            //assert - czy zostały spełnione warunki

            Assert.AreNotEqual(empolyee1, employee2);


            Employee GetEmployee(string name)
            {

                return new Employee(name);

            }

        }
    }
}
