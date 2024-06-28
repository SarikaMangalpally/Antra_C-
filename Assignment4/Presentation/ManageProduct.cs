using Assignment4.DataModel;
using Assignment4.Repository;

namespace Assignment4.Presentation;

public class ManageProduct
{
    IRepository<Product> productRepository = new GenericRepository<Product>();

    public void AddProduct()
    {
        Product product = new Product();
        Console.WriteLine("Enter Id: ");
        product.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        product.Name = Console.ReadLine();
        Console.WriteLine("Enter Price:");
        product.Price = Convert.ToDecimal(Console.ReadLine());
    }

    public void GetAllProducts()
    {
        productRepository.GetAll();
    }

    public Product GetProduct(int id)
    {

        return productRepository.GetById(id);
    }

    public void DeleteProduct(Product product)
    {
        productRepository.RemoveProduct(product);
    }
    
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Press 1 to Add product");
        Console.WriteLine("Press 2 to print all products");
        Console.WriteLine("Press 3 to print the product");
        Console.WriteLine("Press 9 to exit");
        int choice = Convert.ToInt32(Console.ReadLine());
        while (choice != 9)
        {
            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    GetAllProducts();
                    break;
                case 3:
                    Console.WriteLine("Enter Id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    GetProduct(id);
                    break;
                default:
                    Console.WriteLine("Invalid Options");
                    break;
            }
            Console.WriteLine("Press number to continue");
            choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}