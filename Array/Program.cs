class Solution
{


    static void Main(string[] args)
    {
        Console.WriteLine("Type the total of integers to be converted");
        int T = int.Parse(Console.ReadLine());

        Console.WriteLine("Type the sequence of integers");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), val => Convert.ToInt32(val));

        string sOutput = "";

        foreach (int c in arr)
        {
            sOutput = c.ToString() + " " + sOutput;
        }
        Console.WriteLine(sOutput); 
    }
}