namespace ERP_System;
using TECHCOOL.UI;
using System.Collections.Generic;

public partial class Database
{
    private List<SalesOrder> salesOrders = new();
    private int nextSalesOrderId = 1;

    public SalesOrder? GetSalesOrderById(int id)
    {
        foreach (var order in salesOrders)
        {
            if (order.SalesOrderId == id)
            {
                return order;
            }
        }
        return null;
    }

    public SalesOrder[] GetSalesOrders()
    {
        return salesOrders.ToArray();
    }

    public void AddSalesOrder(SalesOrder order)
    {
        if (order.SalesOrderId == 0)
        {
            order.SalesOrderId = nextSalesOrderId++;
            order.Name = order.OrderNumber;
            salesOrders.Add(order);
        }
    }
    
    

    public void UpdateSalesOrder(SalesOrder order)
    {
        if (order.SalesOrderId == 0)
        {
            AddSalesOrder(order);
            return;
        }

        SalesOrder? oldOrder = GetSalesOrderById(order.SalesOrderId);
        if (oldOrder == null)
        {
            return;
        }

        oldOrder.OrderNumber = order.OrderNumber;
        oldOrder.Name = order.OrderNumber;
        oldOrder.Customer = order.Customer;
        oldOrder.Date = order.Date;
        oldOrder.TotalAmount = order.TotalAmount;
        oldOrder.Status = order.Status;
        oldOrder.Products = order.Products;
    }

    public void DeleteSalesOrder(int id)
    {
        SalesOrder? found = GetSalesOrderById(id);
        if (found != null)
        {
            salesOrders.Remove(found);
        }
    }
}
