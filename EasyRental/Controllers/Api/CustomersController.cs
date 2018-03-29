using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Net.Http;
using System.Web.Http;
using EasyRental.Models;
using EasyRental.ViewModels;
using EasyRental.Dtos;
using AutoMapper;

namespace EasyRental.Controllers.Api
{
    public class CustomersController : ApiController

    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/customers
        [HttpGet]
        public IHttpActionResult GetCustomers()
        {
            return Ok(_context.Customers.Include(m=>m.MembershipType).ToList().Select(Mapper.Map<Customer,CustomerDto>));
        }

        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            else
            {
                return Ok(Mapper.Map<Customer,CustomerDto>(customer));
            } 
        }
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customerDto.Id),customerDto);
        }
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id , CustomerDto customerDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var CustomerInDb = _context.Customers.Single(c => c.Id == id);
            if (CustomerInDb == null)
            {
                return NotFound();
            }
            else
            {
                Mapper.Map<CustomerDto, Customer>(customerDto, CustomerInDb);
                

                _context.SaveChanges();
            }
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteCustomer (int id)
        {
            var CustomerInDb = _context.Customers.Single(c => c.Id == id);
            if (CustomerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                _context.Customers.Remove(CustomerInDb);
                _context.SaveChanges();
            }

            return Ok();
        }
    }
}
