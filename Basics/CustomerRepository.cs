using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    public class CustomerRepository
    {
        InvoiceRepository repository = new InvoiceRepository();
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
        public IEnumerable<Customer> SortByNameReverse(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName)
            //                    .ThenByDescending(c => c.FirstName);
            return SortByName(customerList).Reverse();
        }
        public IEnumerable<Customer> SortByTypeId(List<Customer> customerList)
        {
            return customerList.OrderByDescending(c => c.CustomerTypeId.HasValue)
                                .ThenBy(c => c.CustomerTypeId);

        }

        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            var query = customerList.Select(c => $"{c.FirstName}, {c.LastName}");
            return query;
        }
        
        public dynamic GetCustomCustomer(List<Customer> customerList)
        {
            var query = customerList.Select(c => new
                                {
                                    Name = $"{c.FirstName}, {c.LastName}",
                                    c.EmailAddress
                                });
            foreach(var item in query)
            {
                Console.WriteLine($"{item.Name} : {item.EmailAddress}");
            }
            return query;
        }

        public dynamic GetNamesAndType(List<Customer> customerList,
                                        List<CustomerType> customerTypeList)
        {
            var query = customerList.Join(customerTypeList,
                                        c => c.CustomerTypeId,
                                        ct => ct.CustomerTypeId,
                                        (c, ct) => new
                                        {
                                            Name = $"{c.FirstName}, {c.LastName}",
                                            CustomerTypeName = ct.TypeName
                                        });
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Name} : {item.CustomerTypeName}");
            }
            return query;
        }

        public IEnumerable<Customer> GetOverdueCustomers(List<Customer> customerList)
        {
            var query = customerList.SelectMany(c => c.InvoiceList
                                                      .Where(i => (i.IsPaid ?? false) == false),
                                                    (c, i) => c).Distinct();
                                                    
            return query;
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
                   EmailAddress="kk@mail.com",
                   InvoiceList = repository.Retrieve(1)
                   
               },
               new Customer()
               {
                   CustomerId =2,
                   FirstName="Aditya",
                   LastName="Vardhan",
                   CustomerTypeId=2,
                   EmailAddress="av@mail.com",
                   InvoiceList = repository.Retrieve(2)
               },
               new Customer()
               {
                   CustomerId =3,
                   FirstName="Ram",
                   LastName="DVS",
                   CustomerTypeId=null,
                   EmailAddress="dvsr@mail.com",
                   InvoiceList = repository.Retrieve(3)
               },
               new Customer()
               {
                   CustomerId =4,
                   FirstName="Srinath",
                   LastName="T",
                   CustomerTypeId=3,
                   EmailAddress="sr@mail.com",
                   InvoiceList = repository.Retrieve(4)
               }

            };
            return customerList;

        }
    }
}
