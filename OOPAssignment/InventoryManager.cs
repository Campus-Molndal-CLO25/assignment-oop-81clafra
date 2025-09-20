// See https://aka.ms/new-console-template for more information

// Huvudklassen som hanterar all logik

using System.Globalization;

public class InventoryManager
{
    private List<Product> products;
    private List<Order> orders;

    internal void LoadProductsFromCsv(string filePath)
    {
        string[] productsArray = File.ReadAllLines(filePath);
        products = new List<Product>();
        foreach (string productDataElementsString in productsArray.Skip(1)) //Cred: https://stackoverflow.com/a/6429755
        {
            string[] productDataElementsArray = productDataElementsString.Split(',');

            // Generated with assistance from TabbyML/DeepSeekCoder-6.7B
            Product product = new Product
            {
                Name = productDataElementsArray[0],
                Category = productDataElementsArray[1],
                Price = decimal.Parse(productDataElementsArray[2], CultureInfo.InvariantCulture), //Cred: https://stackoverflow.com/a/15897318
                Quantity = int.Parse(productDataElementsArray[3])
            };
            products.Add(product);
        }
    }

    internal void LoadOrdersFromCsv(string filePath)
    {
        string[] ordersArray = File.ReadAllLines(filePath);
        orders = new List<Order>();
        foreach (string orderDataElementsString in ordersArray.Skip(1)) //Cred: https://stackoverflow.com/a/6429755
        {
            string[] orderDataElementsArray = orderDataElementsString.Split(',');

            // Generated with assistance from TabbyML/DeepSeekCoder-6.7B
            Order order = new Order
            {
                CustomerId = orderDataElementsArray[0],
                CustomerName = orderDataElementsArray[1],
                ProductName = orderDataElementsArray[2],
                QuantityOrdered = int.Parse(orderDataElementsArray[3])
            };
            orders.Add(order);
        }
    }

    internal void ProcessOrders()
    {
        throw new NotImplementedException();
    }

    internal void SaveUpdatedProductsToCsv(string filePath)
    {
        throw new NotImplementedException();
    }



}
