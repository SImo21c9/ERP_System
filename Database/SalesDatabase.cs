using ERP_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SalesDatabase : SalesOrder
{
    private readonly Dictionary<string, SalesOrder> _salesOrders = new();

    // Hent salgsordre ud fra id
    public SalesOrder? GetSalesOrderById(string id)
    {
        _salesOrders.TryGetValue(id, out var order);
        return order;
    }

    // Hent alle salgsordrer
    public IReadOnlyCollection<SalesOrder> GetAllSalesOrders()
    {
        return _salesOrders.Values;
    }

    // Indsæt salgsordre
    public bool InsertSalesOrder(SalesOrder order)
    {
        return _salesOrders.TryAdd(order.OrderNumber, order);
    }

    // Opdater salgsordre
    public bool UpdateSalesOrder(SalesOrder updatedOrder, string id)
    {
        if (!_salesOrders.ContainsKey(id)) return false;
        _salesOrders[id] = updatedOrder;
        return true;
    }

    // Slet salgsordre ud fra id
    public bool DeleteSalesOrder(string id)
    {
        return _salesOrders.Remove(id);
    }
}
