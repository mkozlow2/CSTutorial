using System;
using System.Collections.Generic;
using System.Linq;

namespace Odcinek10

{
    class Diary
    {
        private List<float> ratings;

        public Diary()
        {
            ratings = new List<float>();
        }

        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            float sum = 0, i = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            return sum / ratings.Count();
        }

        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
