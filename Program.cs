namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What is your First Name? ");
            string? FirstName=Console.ReadLine(); // Mohaddesse
            System.Console.WriteLine("What is your Last Name? ");
            string? LastName=Console.ReadLine(); //Aghasi
            System.Console.WriteLine("What is your Gender?(Female(f) or Male(m)): ");
            string? Gender=Console.ReadLine();  //Female
            System.Console.WriteLine("How old are you?(between zero to nine hundred ninty nine) ");
            string? Age = Console.ReadLine();    // twenty nine

            Person NewPerson= new Person(FirstName,LastName,Gender.ToLower(),Age.ToLower());
            NewPerson.PrintPerson();

        }
       
    }

}
