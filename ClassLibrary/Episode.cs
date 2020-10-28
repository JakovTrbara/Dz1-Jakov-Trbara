using System;

namespace ClassLibrary
{
    public class Episode
    {
        private int viewerCount;
        private double scoreSum;
        private double maxScore;
        private double averageRating;

        public double MaxScore
        {
            get { return maxScore; }
            set
            {
                if(maxScore<10 && maxScore >= 0)
                {
                    maxScore = value;
                }
                else
                {
                    Console.WriteLine("Incorrect Max Score!");
                }
            }
        }
        

        public Episode()
        {
            viewerCount = 0;
            scoreSum = 0;
            maxScore = 0;
        }
        public Episode(int viewercount, double scoresum,double maxscore) 
        {
            viewerCount = viewercount;
            scoreSum = scoresum;
            maxScore = maxscore;
        }
        public void AddView(double randomScore)
        {
            viewerCount++;
            scoreSum += randomScore;
            if (randomScore > MaxScore)
            {
                MaxScore = randomScore;
            }

        }
        public double GetMaxScore()
        {
            return MaxScore;
        }
        public int GetViewerCount()
        {
            return viewerCount;
        }
        public double GetAverageScore()
        {
            double avgScore = scoreSum / viewerCount;
            return avgScore;
        }

        // AddView , GenerateRandomScore, GetMaxScore, GetAverageScore, GetViewerCount







    }
}
