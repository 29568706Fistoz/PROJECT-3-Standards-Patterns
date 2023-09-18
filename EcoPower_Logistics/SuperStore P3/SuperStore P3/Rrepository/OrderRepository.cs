using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;

public class OrderRepository
{
    private readonly SuperStoreContext _context;

    public OrderRepository(SuperStoreContext context)
    {
        _context = context;
    }

    public IEnumerable<Order> GetAllOrders()
    {
        return _context.Orders.Include(o => o.Customer).ToList();
    }

    public Order GetOrderById(int orderId)
    {
        return _context.Orders.Include(o => o.Customer).FirstOrDefault(o => o.OrderId == orderId)
            ?? throw new NotFoundException("Order not found");
    }


    public void AddOrder(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }

    public void UpdateOrder(Order order)
    {
        _context.Entry(order).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void DeleteOrder(int orderId)
    {
        var order = _context.Orders.Find(orderId);
        if (order != null)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
}
