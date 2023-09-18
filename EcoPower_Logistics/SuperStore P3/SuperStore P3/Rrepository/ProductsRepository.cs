using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;

public class ProductRepository
{
    private readonly SuperStoreContext _context;

    public ProductRepository(SuperStoreContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }

    public Product GetProductById(int productId)
    {
        return _context.Products.FirstOrDefault(p => p.ProductId == productId)
            ?? throw new NotFoundException("Product not found");
    }


    public void AddProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void UpdateProduct(Product product)
    {
        _context.Entry(product).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void DeleteProduct(int productId)
    {
        var product = _context.Products.Find(productId);
        if (product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
