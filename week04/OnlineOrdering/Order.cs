public class Order {

    private List<Product> _products;
    private Customer _customer;

    public Order (Customer customer) {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct (Product product) {
        _products.Add(product);
    }

    public double GetTotalCost() {
        double total = 0;
        foreach (var product in _products) {
            total += product.GetTotalCost();
        }
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel() {
        string label = "Packing List:\n";
        foreach (var product in _products) {
            label += $"{product.GetPackingInfo()}\n";
        }
        return label;
    }

    public string GetShippingLabel() {
        return _customer.GetShippingLabel();
    }
}