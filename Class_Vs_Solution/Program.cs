class Person
{
    int age;

    public Person(int newAge)
    {
        if (age < 0) Console.WriteLine("Invalid Age");

        else age = newAge;
    }

    public void amIOld()
    {
        if (age < 13) Console.WriteLine("You are too young");

        else if (age < 18) Console.WriteLine("You are a teenager");

        else Console.WriteLine("You are old");
    }

    public void passYears()
    {
        age++;
    }

   
}

class Solution
{

    static void Main(string[] args)
    {
        Console.WriteLine("Type the total of students");
        int T = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < T; i++)
        {

            Console.WriteLine("Type the age of the next student");
            int a = int.Parse(Console.ReadLine());
            Person p = new Person(a);

            p.amIOld();

            for (int j = 0; j < 3; j++)
            {
                p.passYears();
            }
            p.amIOld();
        }
    }
}