using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkritKCFormApplication.DataObjects
{
    class Criteria
    {
        public String criteriaName {get; set;}
       
        public Boolean dissatisfied { get; set; }
        public Boolean average { get; set; }
        public Boolean good { get; set; }
        public Boolean excellent { get; set; }

        public Criteria(String name)
        {
            this.criteriaName = name;

        }

        public void disableAll() 
        {
            excellent = false;
            good = false;
            average = false;
            dissatisfied = false;
        }

    }
}
