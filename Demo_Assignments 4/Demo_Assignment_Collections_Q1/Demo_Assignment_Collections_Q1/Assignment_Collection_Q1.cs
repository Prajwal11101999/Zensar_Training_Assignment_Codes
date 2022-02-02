using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo_Assignment_Collections
{

    class Cricket
    {
        public int Sum_Scores = 0;
        public double Average_Scores = 0;
        int[] arr_scores;
        public void PointsCalculation(int no_of_matches)
        {
            arr_scores = new  int[no_of_matches];
            Console.WriteLine("Enter the morks of : {0} Number of Matches..",no_of_matches);
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine("Enter the Score for Match : {0}", i+1);
                arr_scores[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr_scores.Length; i++)
            {
                Sum_Scores = Sum_Scores + arr_scores[i];
            }
            Console.WriteLine("The Sum of Scores in all the Matches are as Follows : {0} ", Sum_Scores);
            Average_Scores = (double)Sum_Scores / arr_scores.Length;
            Console.WriteLine("The Average of Scores in all the Matches are as Follows : {0} ", Average_Scores);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int NumofMatches;
            Console.WriteLine("Enter the number of Match Score to be entered.");
            NumofMatches = int.Parse(Console.ReadLine());
            Cricket cricket = new Cricket();
            cricket.PointsCalculation(NumofMatches);
        }
    }
}
