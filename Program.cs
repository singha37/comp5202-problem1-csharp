using System;

namespace problem1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            Console.WriteLine("this program will as for two numbers and see which one is greater");

            var num1 = 0;
            var num2 = 0;
            Console.WriteLine("please type in your first number");
            var isnumber = int.TryParse(Console.ReadLine(),out num1);

             Console.WriteLine("please type in your Second number");
            var isnumber = int.TryParse(Console.ReadLine(),out num2);

            if(isnumber){
                Console.WriteLine($"{num1} is grater than {num2}");
            }
            else{
                Console.WriteLine($"{num2} is grater than {num1}");
            }    
 

            
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
