using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    public class CustomerRepository
    {
        public Customer FindCustomer(List<Customer> customerList,int customerId)
        {

            Customer foundCustomer = null;

            //foreach(var customer in customerList)
            //{
            //    if(customer.CustomerId == customerId)
            //    {
            //        foundCustomer = customer;
            //        break;
            //    }
            //}

            //var customers = from c in customerList
            //                where c.CustomerId == customerId
            //                select c;

            //foundCustomer = customers.First();

            foundCustomer = customerList
                            .FirstOrDefault(c=> c.CustomerId == customerId);

            return foundCustomer;
        }

        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName)
                                .ThenBy(c => c.FirstName);
        }


        public List<Customer> Retrieve()
        {

            List<Customer> customerList = new List<Customer>
            {
               new Customer()
               {
                   CustomerId =1,
                   FirstName="Kishor",
                   LastName="Kira",
                   CustomerTypeId=1,
                   EmailAddress="kk@mail.com"
               },
               new Customer()
               {
                   CustomerId =2,
                   FirstName="Aditya",
                   LastName="VardhAN",
                   CustomerTypeId=2,
                   EmailAddress="av@mail.com"
               },
               new Customer()
               {
                   CustomerId =3,
                   FirstName="Ram",
                   LastName="DVS",
                   CustomerTypeId=1,
                   EmailAddress="dvsr@mail.com"
               },
               new Customer()
               {
                   CustomerId =4,
                   FirstName="Srinath",
                   LastName="Reddy",
                   CustomerTypeId=3,
                   EmailAddress="sr@mail.com"
               }

            };
            return customerList;

        }
    }
}
