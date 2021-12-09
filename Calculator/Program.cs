using System;

namespace Calculator
{
    class Program
    {
        static void Addition()
        {
            Console.WriteLine("Skriv in ditt först nummer: ");
            double firstnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv in ditt andra nummer: ");
            double secondnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(firstnum + " + " + secondnum + " = " + (firstnum + secondnum));
        }

        static void Subtraction()
        {
            Console.WriteLine("Skriv in ditt först nummer: ");
            double firstnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv in ditt andra nummer: ");
            double secondnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(firstnum + " + " + secondnum + " = " + (firstnum - secondnum));
        }

        static void Multiplication()
        {
            Console.WriteLine("Skriv in ditt först nummer: ");
            double firstnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv in ditt andra nummer: ");
            double secondnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(firstnum + " * " + secondnum + " = " + (firstnum * secondnum));
        }

        static void Division()
        {
            Console.WriteLine("Skriv in ditt först nummer: ");
            double firstnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv in ditt andra nummer: ");
            double secondnum = Convert.ToDouble(Console.ReadLine());
            if (secondnum == 0)
            {
                Console.WriteLine("Du kan inte dividera med 0. ");
            }
            else {
                Console.WriteLine(firstnum + " / " + secondnum + " = " + (firstnum / secondnum));
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till kalkylatorn. Skriv exit för att avsluta programmet.");
            while (true) {
                
                Console.WriteLine("Vill du [A]ddera, [S]ubtrahera, [M]ultiplicera eller [D]ividera? ");
                string method = Console.ReadLine();


                if (method.ToUpper() == "a".ToUpper())
                {
                    Addition();
                }
                else if (method.ToUpper() == "s".ToUpper())
                {
                    Subtraction();
                }
                else if (method.ToUpper() == "m".ToUpper())
                {
                    Multiplication();
                }
                else if (method.ToUpper() == "d".ToUpper())
                {
                    Division();
                }
                else if (method.ToUpper() == "exit".ToUpper())
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ogiltigt räknemetod, var snäll skriv in en giltig bokstav. ");
                }
            }
        }
    }
}
