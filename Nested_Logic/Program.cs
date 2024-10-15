using System;

//TERMINAR TERMINAR TERMINAR TERMINAR TERMINAR
class Solution
{

    static void Main(string[] args)
    {
        string aDate = Console.ReadLine();
        string eDate = Console.ReadLine();
        

        string[] actDate = aDate.Split(" ");
        string[] expDate = eDate.Split(" ");
        
        int aDay = int.Parse(actDate[0]);
        int expDay = int.Parse(expDate[0]);

        int aMonth = int.Parse(actDate[1]);
        int expMonth = Convert.ToInt32(expDate[1]);

        int aYear = Int32.Parse(actDate[2]);
        int expYear = Int32.Parse(expDate[2]);


        int charges = 0;
        //nao deveria precisar olhar mes e dia quando o ano eh menor
        if (aDay < expDay && aMonth < expMonth && aYear < expYear)
        {
            Console.WriteLine("No charges for the costumer");
        }

        else
        {

            if (aYear > expYear) charges = 1000; 
            else
            {
                if (aYear == expYear && aMonth > expMonth)  charges = (aMonth - expMonth) * 500; 

                else 
            {
                if (aYear == expYear && aMonth == expMonth && aDay > expDay) charges = (aDay - expDay) * 15;
            }
                
            }

            Console.WriteLine($"Total of charges for the costumer: {charges}");

        }



    }
}