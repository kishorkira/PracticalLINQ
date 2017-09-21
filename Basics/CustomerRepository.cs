using System.Collections.Generic;

namespace Basics
{
    class CustomerRepository
    {
        public Customer FindCustomer(List<Customer> customerList,int customerId)
        {

            Customer foundCustomer = null;

            foreach(var customer in customerList)
            {
                if(customer.CustomerId == customerId)
                {
                    foundCustomer = customer;
                    break;
                }
            }

            return foundCustomer;
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
