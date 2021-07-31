using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkritKCFormApplication.DataObjects
{
    class Review
    {
        public Customer Customer;
        public List<Criteria> criterias;
        public DateTime date;
        public TimeSpan time;
        String rated;
        int score;

        public Review(Customer customer, List<Criteria> criterias, DateTime date, TimeSpan time)
        {
            this.Customer = customer;
            this.criterias = criterias;
            this.date = date;
            this.time = time;
        }

        public String CriteriaRated(Criteria cri) {
            if (cri.dissatisfied)
            {
                rated = "dissatisfied";
            }

            if (cri.average)
            {
                rated = "average";
            }

            if (cri.good)
            {
                rated = "good";
            }

            if (cri.excellent)
            {
                rated = "excellent";
            }
            return rated;
        }

        public int CriteriaScore(Criteria cri)
        {
            if (cri.dissatisfied)
            {
                score = 1;
            }

            if (cri.average)
            {
                score = 2;
            }

            if (cri.good)
            {
                score = 3;
            }

            if (cri.excellent)
            {
                score = 5;
            }

            return score;
        }

        public int getCriteriaIndex(String criteriaName)
        {
            int index = 0;

            for (int i = 0; i < criterias.Count; i++)
            {
                if (criterias[i].criteriaName == criteriaName)
                {
                    index = i;
                    return index;
                }
            }

            return index;
        } 

    }
}
