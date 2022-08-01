using MyWinOWIN.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWinOWIN.controllers
{
    public class CustomersApiController : ApiController
    {
        public IHttpActionResult Get()
        {
            IList<Customer> customers= new List<Customer>();

            customers.Add(new Customer()
            {
                customerId = 12312,
                customerName = "Syed Awase",
                customerAddress = "HRBR, Bangalore"
            });
            customers.Add(new Customer()
            {
                customerId = 3423,
                customerName = "Syed Azeez",
                customerAddress = "Aundh, Pune"
            });

            return Ok<IList<Customer>>(customers);


        }

    }
}
