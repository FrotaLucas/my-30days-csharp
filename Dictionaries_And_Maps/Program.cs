class Solution
{
    static void Main(string[] args)
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        string[] arr;

        Console.WriteLine("Type the total of costumers");
        int T = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            Console.WriteLine("Type first the name, then the telephone");
            arr = Array.ConvertAll(Console.ReadLine().Split(" "), val => Convert.ToString(val));
            phoneBook.Add(arr[0], arr[1]);
        }

        string query;
        while (true)
        {   
            Console.WriteLine("Why person are you looking for the cellphone number ?");
            query = Console.ReadLine();
            if (query.ToLower() == "exit") break;
            try
            {
                Console.WriteLine(query + "=" + phoneBook[query]);
            }

            catch
            {
                Console.WriteLine("Not Found");
            }


        }
    }
    
}