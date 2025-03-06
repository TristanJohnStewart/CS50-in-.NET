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

            // 1st loop through list of candidates, selecting the candidate for first half of the ranked pair match off
            // (1st loop refered to as i)
            // (candidate 1 refered to as #1)
            // 
            // for loop i = 0
            // while i is less than length
            // i++ at the end of the loop

                // 2nd loop going through list of candidates again to select the candidate for the 2nd half of the pairing 
                // (2nd loop refered to as j)
                // (candidate 2 refered to as #2)
                //
                // for loop j = i + 1
                // while j is less than length
                // j++ at the end of the loop


            // if i equals j then skip
            // (this is because they would be selecting the same candidate
            //  we don't need a match up of a candidate vs themself)

            // if #1 & #2 already have a matchup 
            // i.e. if we're checking for beta (#1) and alpha (#2)
            // we should check to see if #2 vs #1 is already listed
            // with the method I'm using we know that if #1 comes after #2 in the list, then we should skip
            // this is because we do the matchups of AvsB, AvsC, AvsD, etc. Then move onto B once we've hit the end of the list for Avs?.
            // Where we start at the beginning of the list again.
            // But we already have AvsB so we don't need and we don't want BvsB either.
            // So we start the new list at the candidate listed immediately after the current ?

            for (int i = 0; i < numberOfVoters; i++) 
            {
                for (int j = 0; j < length; j++)
                {
                    Console.WriteLine("Rank {0}:", j);
                    
                    //Console.ReadLine();
                }
                // Console.WriteLine
            }       

            // each voter will write in a name 

            // we need to hold the data of each candidate pairing
            // i.e. with 3 candidates
            // alpha vs beta
            // alpha vs charlie
            // beta vs charlie

            // i.e. with 4
            // alpha vs beta
            // alpha vs charlie
            // alpha vs delta
            // beta vs charlie
            // beta vs delta
            // charlie vs delta

            // i.e. with 5 
            // alpha vs beta
            // alpha vs charlie
            // alpha vs delta
            // alpha vs fred
            // beta vs charlie
            // beta vs delta
            // beta vs fred
            // charlie vs delta
            // charlie vs fred
        }
    }
}
