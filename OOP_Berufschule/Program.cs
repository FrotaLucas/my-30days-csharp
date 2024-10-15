using System;
using System.Security;

//use of static 
class Methods
{
    static int count = 0;
    public Methods()
    {
        count++;
        Console.WriteLine("Count Value:" + count);
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("I am protectedMethod");
    }
    static void StaticMethod()
    {
        Console.WriteLine("I am StaicMethod");

    }
    private void PrivateMethod()
    {
        Console.WriteLine("I am privateMethod");

    }

    public class Animal
    {
        protected void Breath()
        {
            Console.WriteLine("I am breathing");
        }
        public void Walk()
        {
            Console.WriteLine("I am walking");
        }
    }

    public class Dog : Animal
    {
      
    }
    static void Main(string[] args)
    {
        //I
        //static method nao precisa de objeto pra ser chamado
        //Methods.StaticMethod();

        //Methods methods = new Methods();

        //protected e public method precisam de objeto pra poder chamar o metodo
        //methods.ProtectedMethod();
        //methods.PrivateMethod();

        //II
        //valor de count vai subindo pq ele eh statico.
        //Methods methodsSum = new Methods();
        //Methods methodsSumAgain = new Methods();

        ///III 
        ///protected vs public
        Dog pitbull = new Dog();
        //metodo public pode ser chamado no filho
        pitbull.Walk();
        //method protected nao pode ser chamado no filho
        //pitbull.Breath();
    }


}




