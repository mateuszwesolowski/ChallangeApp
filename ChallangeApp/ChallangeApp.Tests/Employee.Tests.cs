namespace ChallangeApp.Tests
{
    public class Tests
    {
      
        [Test]
        public void IsSumIsCorrent()
        {
            //Assert.Pass();

            //arrange - przygotowanie
            var employee = new Employee("Mateusz", "Wesolowski", 34);
            employee.AddScore(-4);
            employee.AddScore(-6);

            //act - uruchmienie
            var result = employee.Result;

            //assert - czy zosta³y spe³nione warunki
            Assert.AreEqual(-10, result);
          
        }
    }
}