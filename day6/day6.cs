using System;
using System.Linq;

namespace Days
{
    class Day6
    {
        public static List<List<int>> example = new List<List<int>>
        {
            new List<int> {7, 9},
            new List<int> {15, 40},
            new List<int> {30, 200}
        };

        public static List<List<int>> problem = new List<List<int>>
        {
            new List<int> {41, 244},
            new List<int> {66, 1047},
            new List<int> {72, 1228},
            new List<int> {66, 1040}
        };

        static public void Solve()
        {
            List<int> winners = new List<int> {};

            foreach (List<int> race in problem)
            {
                int t_total = race[0];
                int d_race = race[1];
                List<int> hold_times = Enumerable.Range(1, t_total).ToList();
                
                winners.Add(
                    hold_times.Count(
                        t_hold => t_hold * (t_total - t_hold) > d_race
                    )
                );
            }

            int possibilities = 1;
            foreach (int winner in winners){
                possibilities = winner * possibilities;
            }
            Console.WriteLine(possibilities);
        }
    }
}