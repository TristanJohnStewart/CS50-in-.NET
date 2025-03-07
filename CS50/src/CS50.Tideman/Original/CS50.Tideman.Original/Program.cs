using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

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

            List<string> candidateNames = [.. args];

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

            // assigning ranked pairings
            List<RankedPair> rankedPairs = new();
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    rankedPairs.Add(new RankedPair(candidateNames[i], 0, candidateNames[j], 0, null));
                }
            }

            int listLength = rankedPairs.Count;

            for (int i = 0; i < numberOfVoters; i++) 
            {
                for (int j = 0; j < length; j++)
                {
                    Console.WriteLine("Rank {0}:", j);
                    string? votee = Console.ReadLine();

                    if (string.IsNullOrEmpty(votee))
                    {
                        continue;
                    }

                    for (int k = 0; k < listLength; k++)
                    {
                        //if (votee == rankedPairs[k].CandidateOneName || 
                        //    votee == rankedPairs[k].CandidateTwoName)
                        //{

                        //}

                        // check if vote is valid
                        // (see if string inputted matches string of any candidates
                        //  force both strings to upper to check for name similarities)
                        // if voteName equals rankedPairs[
                    }
                }
                Console.WriteLine("");
            }       
        }

        public class RankedPair
        {
            private string candidateOneName;
            private int candidateOneVotes;

            private string candidateTwoName;
            private int candidateTwoVotes;

            private string? winner;

            public RankedPair(string candidateOneName, int candidateOneVotes, string candidateTwoName, int candidateTwoVotes, string? winner)
            {
                this.candidateOneName = candidateOneName;
                this.candidateOneVotes = candidateOneVotes;
                this.candidateTwoName = candidateTwoName;
                this.candidateTwoVotes = candidateTwoVotes;
                this.winner = winner;
            }

            public string CandidateOneName
            {
                get { return candidateOneName; }
                set { candidateOneName = value; }
            }

            public int CandidateOneVotes
            {
                get { return candidateOneVotes; }
                set { candidateOneVotes = value; }
            }
            public string CandidateTwoName
            {
                get { return candidateTwoName; }
                set { candidateTwoName = value; }
            }
            public int CandidateTwoVotes
            {
                get { return candidateTwoVotes; }
                set { candidateTwoVotes = value; }
            }
            public string Winner
            {
                get { return winner; }
                set { winner = value; }
            }
        }
    }
}
