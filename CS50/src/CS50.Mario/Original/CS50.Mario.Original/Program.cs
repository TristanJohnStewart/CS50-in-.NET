namespace CS50.Mario.Original
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int height = 0;

            while (height < 1)
            {
                Console.WriteLine("Height:");
                string input = Console.ReadLine();
                try
                {
                    height = Convert.ToInt32(input);

                    if (height < 1)
                    {
                        Console.WriteLine("Enter positive integer of 1 or higher.");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0} is outside the range of the Int32 type.", height);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                      input.GetType().Name, input);
                }                
            }

            for (int i = 0; i < height; i++) 
            {
                string spaces = new string(' ', height - i - 1);
                string blocks = new string('#', i + 1);
                Console.WriteLine(spaces + blocks + "  " + blocks);
            }
        }
    }
}
