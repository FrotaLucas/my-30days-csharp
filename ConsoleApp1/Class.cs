using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Employee
    {
        public string name;
        public int age;

        public double tax = 0.0023;
        private int taxID = 1001295;

        public Employee(string nameX, int AgeX) { 
        
        name = nameX;
        age = AgeX;
        }
        
        public void CalculateTax()
        {
            Console.WriteLine("{0} has worked here", name);
        }

        public double taxX
        {
            get { return tax; }

            set { 
                if (value < 0)
                {
                   tax = 0;

                }

                else
                {
                    tax = value;
                }
                
            }
        }

    
    }
}
