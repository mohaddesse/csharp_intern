namespace Exercise1
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public string Gender;
        public string Age;
        public Person(string FirstName, string LastName,string Gender,string Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender=Gender;
            this.Age=Age;
        }
        public void PrintPerson()
        {
            WordToNumber word=new WordToNumber(Age);
            int AgeNumber=word.ReturnNumber();
            string IntervalAge=(AgeNumber<20)?"teenager":
            (AgeNumber<30)?"young":
            (AgeNumber<50)?"middle-aged":"aged";
            string GenderStand=Gender.Substring(0,1);
            System.Console.WriteLine(GenderStand);
            string DefineGender=(GenderStand.Equals("f"))?"Miss":(GenderStand.Equals("m"))?"Mr":"";
            System.Console.WriteLine("{0} {1} {2}, You are {3}.",DefineGender,FirstName,LastName,IntervalAge);
        }
    }
}