using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkritKCFormApplication.DataObjects;

namespace AkritKCFormApplication
{
    class Calculate
    {
        public int[] CountInstances(List<Review> reviews,String criteriaName)
        {
            int excellentCount = 0;
            int goodCount = 0;
            int averageCount = 0;
            int dissatisfiedCount = 0;
            int[] reviewMatrix;


            foreach (Review r in reviews)
            {
                int index = r.getCriteriaIndex(criteriaName);
                if (r.criterias[index].criteriaName == criteriaName)
                {
                    String verdict = r.CriteriaRated(r.criterias[index]);
                    switch (verdict)
                    {
                        case "excellent":
                            excellentCount++;
                            break;
                        case "good":
                            goodCount++;
                            break;
                        case "average":
                            averageCount++;
                            break;
                        case "dissatisfied":
                            dissatisfiedCount++;
                            break;
                    }
                    
                }
            }

            reviewMatrix = new int[] { excellentCount, goodCount, averageCount, dissatisfiedCount};

            return reviewMatrix;
        }

        public double countScore(Review review)
        {
            double totalAverage = 0;

            foreach (Criteria criteria in review.criterias)
            {
                totalAverage += review.CriteriaScore(criteria);
            }

            totalAverage = totalAverage / (review.criterias.Count());
            totalAverage = Math.Round(totalAverage, 2);
            return totalAverage;
        }

        public double totalScore(List<double> averages)
        {
            double totalAverage = 0;

            foreach (Double a in averages)
            {
                totalAverage += a;
            }

            totalAverage = totalAverage / averages.Count();
            totalAverage = Math.Round(totalAverage, 2);

            return totalAverage;
        }                           

    }
}
