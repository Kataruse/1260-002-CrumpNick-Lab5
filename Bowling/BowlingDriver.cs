using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Bowling
{
    public class BowlingDriver
    {
        static void Main(string[] args)
        {
            BowlingAverage d = new BowlingAverage();
            Console.WriteLine("----------DEFAULT BOWLING AVERAGE----------");
            Console.WriteLine(d.ToString());

            int games;
            int[] scores;
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("\nEnter the amount of games played: ");
                        games = Convert.ToInt32(Console.ReadLine());
                        if (games > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{games} is not a valid integer for games played");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                
                scores = new int[games];
                for (int i = 0; i < scores.Length; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"\nEnter the score for game {i+1}: ");
                            scores[i] = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                try
                {
                    BowlingAverage userBowlingAverage = new BowlingAverage(scores, games);
                    Console.WriteLine("\n----------DEFAULT BOWLING AVERAGE----------");
                    Console.WriteLine(userBowlingAverage.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Write("\nWould you like to contine? (Y/N): ");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }
    }
}
