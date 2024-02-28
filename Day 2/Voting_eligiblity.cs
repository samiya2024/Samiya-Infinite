using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_eligiblity
{
    class Voting_eligiblity
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check Your Voting Eligiblity Here Based On Your Age:");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (IsEligibleToVote(age))
            {
                Console.WriteLine("You are Eligible To VOTE!!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You are NOT Eligible To VOTE...");
                Console.ReadLine();
            }
        }
        static bool IsEligibleToVote(int age)
        {
            const int VotingAge = 18;
            return age >= VotingAge;
        }
    }
}
