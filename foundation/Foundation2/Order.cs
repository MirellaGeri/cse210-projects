using System;
using System.Collections.Generic;

public class Order
{
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; }
    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    public double CalculateTotalPrice()
    {
        double totalProductCost = 0;
        foreach (var product in Products)
        {
            totalProductCost += product.TotalCost();
        }

        double shippingCost = Customer.IsInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in Products)
        {
            packingLabel += $"Product: {product.Name}, ID: {product.ProductId}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.CustomerAddress.GetFullAddress()}\n";
    }
}