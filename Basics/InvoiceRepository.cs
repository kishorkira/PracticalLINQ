using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    public  class InvoiceRepository
    {
        public List<Invoice> Retrieve(int CustomerId)
        {
            List<Invoice> invoiceList = new List<Invoice>
            {
                new Invoice
                {
                    InvoiceId =1,
                    CustomerId =2,
                    InvoiceDate =new DateTime(2017,9,23),
                    DueDate =new DateTime(2017,10,5),
                    IsPaid =null
                },
                 new Invoice
                {
                    InvoiceId =2,
                    CustomerId =2,
                    InvoiceDate =new DateTime(2017,9,23),
                    DueDate =new DateTime(2017,10,5),
                    IsPaid =null
                },
                 
                  new Invoice
                {
                    InvoiceId =3,
                    CustomerId =4,
                    InvoiceDate =new DateTime(2017,9,23),
                    DueDate =new DateTime(2017,10,5),
                    IsPaid =null
                }, new Invoice
                {
                    InvoiceId =4,
                    CustomerId =1,
                    InvoiceDate =new DateTime(2017,9,23),
                    DueDate =new DateTime(2017,10,5),
                    IsPaid =true
                }
            };
            List<Invoice> filteredList= invoiceList.Where(i => i.CustomerId == CustomerId).ToList();
            return filteredList;
        }
    }
}
