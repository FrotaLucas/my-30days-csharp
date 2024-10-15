using System;
using System.Security.Cryptography.X509Certificates;

class ClassOfMethods
{
    public void Method1()
    {
        Method2();

    }
    public void Method2()
    {
        try
        {
            //Usando try catch nos nao deixamos o error escalar em todos on niveis (Metodos 1,2 3)
            //O erro eh tratado no primeiro catch que ele encontra pelo caminho. NoCaso aqui nesse Method2
            //Experimente remover o bloco try catch. O erro vai ser escalado para todos os niveis !!
            Method3();
        }

        catch(Exception ex)
        {
            Console.WriteLine("Exceção Tratada");
        }

    }  public void Method3()
    {
        Console.WriteLine("Method =)");

        throw new Exception("Occoreu um erro aqui");
    }



}
class Solution
{
    public static void Main(string[] args)
    {
        new ClassOfMethods().Method1();


        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}


