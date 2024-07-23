namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            // Get Input
            string input = Console.ReadLine();
            string output = string.Empty;

            try
            {
                int i = Convert.ToInt16(input);

                if (i != null)
                {

                    for(int x=1; x<=i; x++)
                    {
                        if (x % 3 == 0 && x % 5 == 0)
                        {
                            output = "FizzBuzz";
                        }
                        else if (x % 3 == 0 && x % 5 != 0)
                        {
                            output = "Fizz";
                        }
                        else if (x % 5 == 0 && x % 3 != 0)
                        {
                            output = "Buzz";
                        }
                        else if (x % 5 != 0 && x % 3 != 0)
                        {
                            output = x.ToString();
                        }
                        Console.WriteLine(output);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input!");                
            } 

            Console.ReadKey();

        }
    }
}
