using System;

// Abstract Product
public abstract class Product
{
    public abstract string Name { get; }
}

// Concrete Product
public class Smartphone : Product
{
    public override string Name => "Smartphone";
}

// Concrete Product
public class Laptop : Product
{
    public override string Name => "Laptop";
}

// Concrete Product
public class Tablet : Product
{
    public override string Name => "Tablet";
}

// Abstract Factory
public abstract class ProductFactory
{
    public abstract Product CreateProduct();
}

// Concrete Factory
public class SmartphoneFactory : ProductFactory
{
    public override Product CreateProduct()
    {
        return new Smartphone();
    }
}

// Concrete Factory
public class LaptopFactory : ProductFactory
{
    public override Product CreateProduct()
    {
        return new Laptop();
    }
}

// Concrete Factory
public class TabletFactory : ProductFactory
{
    public override Product CreateProduct()
    {
        return new Tablet();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter product type (smartphone, laptop, tablet):");
        string productType = Console.ReadLine();

        ProductFactory factory = null;

        switch (productType)
        {
            case "smartphone":
                factory = new SmartphoneFactory();
                break;
            case "laptop":
                factory = new LaptopFactory();
                break;
            case "tablet":
                factory = new TabletFactory();
                break;
            default:
                Console.WriteLine("Invalid product type");
                return;
        }

        if (factory != null)
        {
            Product product = factory.CreateProduct();
            Console.WriteLine($"Created {product.Name}");
        }

        Console.ReadKey();
    }
}