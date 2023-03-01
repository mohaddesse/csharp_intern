
namespace Exercise1
{
    class WordToNumber
    {
        public string Age;
        public WordToNumber(string Age)
        {
            this.Age=Age;
        }
        public int ReturnNumber()
        {
           string[] AgeToList = Age.Split();
            int LengthList = AgeToList.Length;
            int finalAge = 0;

            if (LengthList == 0 || LengthList > 4) throw new Exception("Type a number beteween 0 to 999!");
            else
            {
                if(LengthList>1)
                {
                    string Hunderds = AgeToList[0];
                    bool ChekHunderds = (AgeToList[1].Equals("hundred")) ? true : false;
                    bool exists = Enum.IsDefined(typeof(Words), Hunderds);
                        if (ChekHunderds && exists)
                        {
                            int ones=(int)(Enum.Parse(typeof(Words), Hunderds));
                            finalAge = ones * 100;

                            if (LengthList>2)
                            {
                                var SecondPart=AgeToList[2..];
                                finalAge+=VillagersTransform(SecondPart);
                            }
                            if (finalAge>ones*100+99 || finalAge>999 ) throw new Exception("Format of number is not correct");
                            
                        }
                        else finalAge=VillagersTransform(AgeToList);


                }
                else finalAge=VillagersTransform(AgeToList);
            
            }
                return finalAge;            
        }
                public int VillagersTransform(string[] AgeToList)
        {
                string FirstNumber = AgeToList[0];
                int Maximum = Enum.IsDefined(typeof(Words), FirstNumber) ? (int)(Enum.Parse(typeof(Words), FirstNumber))+9 : 1000000;
                int finalAge = 0;
                foreach (var item in AgeToList)
                {
                    bool exists = Enum.IsDefined(typeof(Words), item);
                    if (exists && (finalAge<10 || finalAge>19))
                    {
                        int number = (int)(Enum.Parse(typeof(Words), item));
                        finalAge += number;

                    }
                    else
                    {
                        finalAge = 0;
                        throw new Exception("Format of number is not correct");
                    }

                }
                if (finalAge>Maximum) throw new Exception("Format of number is not correct");
            return finalAge;

        }

    }
}