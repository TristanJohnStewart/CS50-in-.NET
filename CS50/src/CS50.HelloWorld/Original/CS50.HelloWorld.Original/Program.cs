namespace CS50.HelloWorld.Original
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? name = "";
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
            }
            Console.WriteLine("hello, " + name);
        }
    }
}
