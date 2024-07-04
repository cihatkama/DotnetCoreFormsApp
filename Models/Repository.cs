namespace FormsApp.Models;

public class Repository
{
    private static readonly List<Product> _products = new();
    private static List<Category> _categories = new();

    static Repository()
    {
        _categories.Add(new Category() {CategoryId = 1, Name="Telefon"});
        _categories.Add(new Category() {CategoryId = 2, Name="Bilgisayar"});
        _categories.Add(new Category() {CategoryId = 3, Name="Tablet"});
        _categories.Add(new Category() {CategoryId = 4, Name="Robot Süpürge"});

        _products.Add(new Product() { ProductId = 1, ProductName = "iPhone 15 Pro", Price = 65000, Image="1.jpg", CategoryId = 1, IsActive = true});
        _products.Add(new Product() { ProductId = 2, ProductName = "iPhone 15", Price = 48500, Image="2.jpg", CategoryId = 1, IsActive = true});
        _products.Add(new Product() { ProductId = 3, ProductName = "HP Victus 15", Price = 32000, Image="3.jpg", CategoryId = 2, IsActive = true});
        _products.Add(new Product() { ProductId = 4, ProductName = "Casper Excalibur", Price = 25600, Image="4.jpg", CategoryId = 2, IsActive = true});
        _products.Add(new Product() { ProductId = 5, ProductName = "Xiaomi Mi Vacuum", Price = 25000, Image="5.jpg", CategoryId = 3, IsActive = true});
    }

    public static List<Product> Products
    {
        get 
        {
            return _products;
        }
    } 

    public static List<Category> Categories
    {
        get 
        {
            return _categories;
        }
    } 

}