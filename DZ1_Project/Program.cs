using System;
using ClassLibrary;

/*Radite sustav koji omogućuje rad: 

s epizodama TV serije 
s brojem gledatelja
ukupnom sumom njihovih ocjena 
i najvećom danom ocjenom iz intervala [0.0-10.0]*/
namespace DZ1_Project
{
    class Program
    {
        static void Main(string[] args)
        {

			 double GenerateRandomScore()
            {
				double score;
				Random rand = new Random();
				score = rand.NextDouble() * 10;
				score = Math.Round(score, 1);
				return score;
            }

			Episode ep1 = new Episode();
			Episode ep2 = new Episode(10, 64.39, 8.7);
			int viewers = 10;
			for (int i = 0; i < viewers; i++)
			{
				ep1.AddView(GenerateRandomScore());
				Console.WriteLine(ep1.GetMaxScore());
			}
			if (ep1.GetAverageScore() > ep2.GetAverageScore())
			{
				Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
			}
			else
			{
				Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
			}
		}
    }
}
