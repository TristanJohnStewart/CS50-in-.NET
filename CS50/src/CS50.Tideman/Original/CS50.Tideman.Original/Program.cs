namespace CS50.Tideman.Original
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int length = args.Length;
            if (length < 2 || length > 9)
            {
                Console.WriteLine("Minimum of 2 candidates up to a maximum of 9 required as commandline arguements.");
                Environment.Exit(0);
            }

            List<string> candidateNamess = [.. args];

            int numberOfVoters = 0;
            while (true)
            {
                Console.WriteLine("Number of voters:");
                numberOfVoters = Convert.ToInt16(Console.ReadLine());
                if (numberOfVoters >= 1)
                {
                    break;
                }
            }
        }
    }
}
