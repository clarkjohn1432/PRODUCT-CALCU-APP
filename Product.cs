
internal class Product
{
    private int price;
    private string productName;

    public Product(string productName, int price)
    {
        this.price = price;
        this.productName = productName;
    }

    public int getPrice()
    {
        return this.price;
    }

    public string getProductName()
    {
        return this.productName;
    }
}
