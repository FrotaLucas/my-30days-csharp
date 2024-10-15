

using System.Text.RegularExpressions;

class Solution
{
    static void Main(string[] args)
    {
        //string[] test;
        //string testinho = "olha so que veio";

        //test = testinho.Select(c => c.ToString()).ToArray();

        //Console.WriteLine("comecou");
        //Console.WriteLine(test[0]);
        //Console.WriteLine(string.Join(",", test)); // Convert array to string for printing

        //printa objeto
        //Console.WriteLine(test);


        List<string[]> data = new List<string[]>();

        Console.WriteLine("Type the total of users");
        int N = int.Parse(Console.ReadLine());

        for( int i=0; i<N; i++)
        {
            Console.WriteLine($"Type the name and the E-mail from the {i+1}. user");
            string[] firstNameEmailId = Console.ReadLine().Split();

            string firstName = firstNameEmailId[0];
            string email = firstNameEmailId[1];
            
            //accept only email from @gmail.com
            string checkEmail = "@gmail.com$";

            var match = Regex.Match(email,checkEmail, RegexOptions.IgnoreCase);
            
            if(match.Success)
            {
                data.Add(firstNameEmailId);
            }


        }


        
        int j = 0;
        string[] names = new string[data.Count];
        foreach (string[] s in data)
        {
            names[j] = s[0];
            j++;
        }
        Array.Sort(names);


        Console.WriteLine("Name of all users:\n");
        foreach (string item in names )
        {
            Console.WriteLine(item);
        }
    }
}