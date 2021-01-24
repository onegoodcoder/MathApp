using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do you wanna calculate perimiter or area");
            string choice = Console.ReadLine();
            if (choice == "area")
            {
                Console.WriteLine("formula = lxw");
                Console.WriteLine("what is your length to solve area");
                string userinput1 = Console.ReadLine();
                Console.WriteLine("what is your width to solve area");
                string userinput2 = Console.ReadLine();
                int userinputone = Int32.Parse(userinput1);
                int userinputtwo = Int32.Parse(userinput1);
                int numbers1 = userinputone * userinputtwo;
                Console.WriteLine("area = " + numbers1);
            }
            else
            {
                Console.WriteLine("formula = l + l + w + w");
                Console.WriteLine("what is your first length to solve perimiter");
                string userinput1add =  Console.ReadLine();
                Console.WriteLine("what is your second length to solve perimiter");
                string userinput2add = Console.ReadLine();
                Console.WriteLine("what is your first width to solve perimiter");
                string userinput3add = Console.ReadLine();
                Console.WriteLine("what is your second width to solve perimiter");
                string userinput4add = Console.ReadLine();
                int userinputoneadd = Int32.Parse(userinput1add);
                int userinputtwoadd = Int32.Parse(userinput2add);
                int userinputthreeadd = Int32.Parse(userinput3add);
                int userinputfouradd = Int32.Parse(userinput4add);
                int numbers = userinputoneadd + userinputtwoadd + userinputthreeadd + userinputfouradd;
                string result = "p = " + numbers;
                Console.WriteLine(result);
            }
                
        

        }
    }
}
