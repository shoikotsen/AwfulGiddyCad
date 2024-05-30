using System;

public class Program
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }

        public PersonalInfo(string name, string birthdate, string workPhone, string cellPhone)
        {
            Name = name;
            Birthdate = birthdate;
            WorkPhone = workPhone;
            CellPhone = cellPhone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Birthdate);
            Console.WriteLine("work " + WorkPhone);
            Console.WriteLine("cell " + CellPhone);
        }
    }

    public static void Main()
    {
        // Unit Test #1
        PersonalInfo person1 = new PersonalInfo("Lucinda Potter", "6/24/1992", "000-000-0101", "000-000-0189");
        person1.DisplayInfo();
        Console.WriteLine();

        // Unit Test #2
        PersonalInfo person2 = new PersonalInfo("John Smith", "8/15/1978", "000-111-0101", "000-111-0189");
        person2.DisplayInfo();
        Console.WriteLine();

        // Unit Test #3
        PersonalInfo person3 = new PersonalInfo("Chris Johnson", "12/01/1987", "000-222-0101", "000-222-0189");
        person3.DisplayInfo();
        Console.WriteLine();

        // Unit Test #4
        PersonalInfo person4 = new PersonalInfo("Robert Hall", "2/27/1949", "000-444-0101", "000-444-0189");
        person4.DisplayInfo();
    }
}
// 2024/05/22_SenShoikot_Exercise 1.1