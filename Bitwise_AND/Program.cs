

class Solution
{
    static void maxBitWise(string[] testData)
    {


        for (int index = 0; index < testData.Length; index++)
        {

            string[] nk = testData[index].Split(" ");

            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            List<int> bitwiseAnd = new List<int>();
            int[] sbNumbers = new int[n];

            for (int j = 1; j <= n; j++)
            {
                sbNumbers[j - 1] = j;
            }

            int indexA = 0;
            int indexB = 1;

            while (indexA < n)
            {
                while (indexB < n)
                {
                    int c = sbNumbers[indexA] & sbNumbers[indexB];
                    if (c < k)
                    {
                        bitwiseAnd.Add(c);
                    }
                    indexB++;
                }


                indexA++;
                indexB = indexA + 1;
            }


            var resultData = bitwiseAnd.ToArray();
            Array.Sort(resultData);
            Console.WriteLine(resultData[resultData.Length - 1]);

        }

    }

    static void Main(string[] testData)
    {
        Console.WriteLine("Type the total of sequences");
        int T = int.Parse(Console.ReadLine());

        string[] s = new string[T];

        Console.WriteLine("Type the sequence of numbers");

        for (int z = 0; z < T; z++)
        {
            s[z] = Console.ReadLine();

        }

        maxBitWise(s);
    }
}

