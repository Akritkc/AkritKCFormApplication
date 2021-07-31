using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkritKCFormApplication.DataObjects;

namespace AkritKCFormApplication
{
    
    class QuickSort
    {
        Calculate calculate = new Calculate();
        public void sort(List<Review> reviews, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = calculate.countScore(reviews[(left + right) / 2]);

            while (i <= j)
            {
                while (calculate.countScore(reviews[i]) < pivot)
                {
                    i++;
                }

                while (calculate.countScore(reviews[j]) > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    var tmp = reviews[i];
                    reviews[i] = reviews[j];
                    reviews[j] = tmp;
                    i++;
                    j--;
                }   
            }

            if (left < j)
            {
                sort(reviews, left, j);
            }

            if (i < right)
            {
                sort(reviews, i, right);
            }

        }

        public List<Review> reverseList(List<Review> reviews)
        {
            List<Review> reviewsInverse = new List<Review>();
            for (int i = reviews.Count(); i > 0; i--)
            {
                reviewsInverse.Add(reviews[i-1]);
            }
            return reviewsInverse;

        }
    }
}
