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

            // getting ranked preferences from voters
            for (int i = 0; i < numberOfVoters; i++)
            {
                bool[] rankingRecieved = new bool[listLength];
                for (int j = 0; j < listLength; j++)
                {
                    rankingRecieved[j] = false;
                }

                for (int j = 0; j < length; j++)
                {
                    Console.WriteLine("Rank {0}:", j);
                    string? votee = Console.ReadLine();

                    if (string.IsNullOrEmpty(votee))
                    {
                        Console.WriteLine("Invalid Vote.");
                        return;
                    }
                    votee = votee.ToUpper();

                    for (int k = 0; k < listLength; k++)
                    {
                        // if the pairing has already recieved rankings from this voter
                        // skip the pairing onto next loop iteration
                        if (rankingRecieved[k] == true)
                        {
                            continue;
                        }
                        // elseif if the pairing has a name match for one of the candidates 
                        // increase the point for said candidate by 1
                        else if (votee == rankedPairs[k].CandidateOneName.ToUpper())
                        {
                            rankedPairs[k].CandidateOneVotes++;
                            rankingRecieved[k] = true;
                            continue;
                        }
                        else if (votee == rankedPairs[k].CandidateTwoName.ToUpper())
                        {
                            rankedPairs[k].CandidateTwoVotes++;
                            rankingRecieved[k] = true;
                            continue;
                        }
                    }
                }
                Console.WriteLine("");
            }

            // sort rankedPairs in decreasing order of margin of victory
            // loop (i) to select the index where the new rankedPair will be shifted to,
            // and the index for the present for the new rankedPair to resort
                // loop (j) to find the rankedPair that will be shifted

            for (int i = 0; i < listLength; i++)
            {
                Console.WriteLine("Index: " + i + " #1 " + rankedPairs[i].CandidateOneName + " Votes: " + rankedPairs[i].CandidateOneVotes + " vs #2 " + rankedPairs[i].CandidateTwoName + " Votes: " + rankedPairs[i].CandidateTwoVotes);
            }

            // lock in rankedPairs
                // check for cycle

            // print winner
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
