using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkritKCFormApplication.DataObjects
{
    class Customer
    {
        public String customerName { get; set; }
        public String customerNumber { get; set; }
        public String customerEmail { get; set; }

        public Customer(String name, String number, String email)
        {
            this.customerName = name;
            this.customerNumber = number;
            this.customerEmail = email;
        }

    }
}
