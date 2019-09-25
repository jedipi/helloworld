using System;
using HelloWorld.Enum;
using HelloWorld.Model;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var baby = new Baby()
                .SetFirstName("Allie")
                .SetLastName("Tam")
                .SetGender(Gender.Girl)
                .SetBod(new DateTime(2019, 08, 20));

            try
            {
                var contraction = 0;
                while (contraction < 10)
                {
                    Console.WriteLine($"Wife screaming {contraction}...");
                    System.Threading.Thread.Sleep(500);
                    contraction++;
                }

                Console.WriteLine("");
                Console.WriteLine("\"Hello World!\"");
                Console.WriteLine($"My name is {baby.FirstName} {baby.LastName}");
                Console.WriteLine($"I am a {baby.Sex}.");
                Console.WriteLine($"My Birthday is {baby.Bod.ToString("dd-MM-yyyy")}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // add these two line to keep the console window open
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
            
        }
    }
}
