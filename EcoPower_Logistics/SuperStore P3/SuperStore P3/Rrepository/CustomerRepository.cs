using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System;
using System.Runtime.Serialization;

public class CustomerRepository
{
    private readonly SuperStoreContext _context;

    public CustomerRepository(SuperStoreContext context)
    {
        _context = context;
    }

    public IEnumerable<Customer> GetAllCustomers()
    {
        return _context.Customers.ToList();
    }

    public Customer GetCustomerById(int customerId)
    {
        if (customerId <= 0)
        {
            throw new ArgumentException("Invalid customerId");
        }

        var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == customerId);

        if (customer == null)
        {
            throw new NotFoundException("Customer not found"); // You can create a custom exception class for this
        }

        return customer;
    }


    public void AddCustomer(Customer customer)
    {
        _context.Customers.Add(customer);
        _context.SaveChanges();
    }

    public void UpdateCustomer(Customer customer)
    {
        _context.Entry(customer).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void DeleteCustomer(int customerId)
    {
        var customer = _context.Customers.Find(customerId);
        if (customer != null)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}

[Serializable]
internal class NotFoundException : Exception
{
    public NotFoundException()
    {
    }

    public NotFoundException(string? message) : base(message)
    {
    }

    public NotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}