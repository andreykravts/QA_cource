using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMatala3
{
    public class Flight
    {

        public Customer OrderedBy = new Customer();
        public DateTime FlightDate;
        

        public bool CanBeCanceledBy(Customer customer)
        {
            return (customer.VIP == true || customer == OrderedBy);
        }
        public bool CanBeOrderedBy(Customer customer, DateTime orderDate)
        {
            if (customer.age > 18 && orderDate < FlightDate && orderDate != FlightDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
 
}

