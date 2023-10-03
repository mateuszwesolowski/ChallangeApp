namespace ChallangeApp
{
    internal class Employee
    {
        private string name;
        private string surname;
        private int age;    

        private List<int> score = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        
        public string Surname { get; private set; }
        public int Age { get; }

        public void AddScore(int number) 
        { 
            this.score.Add(number);
        }

        public int Result
        {
            get 
            {
                return this.score.Sum();
            }
        }
    }
}
