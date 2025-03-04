namespace CS50.Credit.Original
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string result = "INVALID";
            string? cardString = "";
            long cardNumber = 0;

            // ask for card number
            while (true)
            {
                Console.WriteLine("Number:");
                cardString = Console.ReadLine();
                if (!string.IsNullOrEmpty(cardString))
                {
                    try
                    {
                        cardNumber = Convert.ToInt64(cardString);
                        break;
                    }
                    catch (FormatException) { }
                }
            }

            int length = cardString.Length;

            // intialize types, paired with starting digit identifiers, and lengths
            string[] cardTypes = { "VISA", "VISA", "AMEX", "AMEX", "MASTERCARD", "MASTERCARD", "MASTERCARD", "MASTERCARD", "MASTERCARD" };
            string[] cardStarts = { "4", "4", "34", "37", "51", "52", "53", "54", "55" };
            int[] cardLengths = { 13, 16, 15, 15, 16, 16, 16, 16, 16, };

            for (int i = 0; i < cardTypes.Length; i++)
            {
                if (cardString.StartsWith(cardStarts[i]) && cardLengths[i] == length)
                {
                    result = cardTypes[i];
                } 
            }

            int checkSum = 0;
            int additionIndex = length - 1;
            int multiplicationIndex = length - 2;

            while (true)
            {
                if (additionIndex < 0)
                {
                    break;
                }
                else
                {
                    checkSum += (int)char.GetNumericValue(cardString[additionIndex]);
                    additionIndex -= 2;
                }

                if (multiplicationIndex < 0)
                {
                    break;
                }
                else
                {
                    checkSum += 2 * (int)char.GetNumericValue(cardString[multiplicationIndex]);
                    multiplicationIndex -= 2;
                }
            }

            if (checkSum % 10 != 0) 
            { 
                result = "INVALID"; 
            }

            Console.WriteLine(result);
        }
    }
}