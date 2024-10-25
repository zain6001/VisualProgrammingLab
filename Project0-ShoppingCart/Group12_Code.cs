using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Product
{
    public int Id{ get; set; }
    public string Name{ get; set; }

    private decimal price;
    public decimal Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Price must be greater than 0. Please enter the price again.");
                price = GetValidPrice();
            }
            else
            {
                price = value;
            }
        }
    }
    private int quantity;

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Quantity must be greater then 0.Please enter quantitiy again.");
                quantity = GetValidQuantity();
            }
            else
            {
                quantity = value;
            }

        }
    }

    private int GetValidQuantity()
    {
        string input;
        int q;

        while (true)
        {
            Console.Write("Enter valid quantity : ");
            input = Console.ReadLine();
            if (int.TryParse(input, out q))
            {
                if (q > 0)
                {
                    return q;
                }
            }
            Console.WriteLine("Please enter Quantity greater then 0.");
        }



    }

    private decimal GetValidPrice()
    {
        decimal inputPrice;
        string input;

        while (true)
        {
            Console.Write("Enter a valid price: ");
            input = Console.ReadLine();

            if (decimal.TryParse(input, out inputPrice))
            {
                if (inputPrice > 0)
                {
                    return inputPrice;
                }
            }

            Console.WriteLine("Invalid input. Please enter a number greater than or equal to 0.");
        }
    }




}

public class Cart
{

    private List<Product> cartItems = new List<Product>();
    public void AddProduct()
    {
        Console.Clear();
        try
        {
            Console.WriteLine("Recommendations");
            Console.WriteLine("{0,5} | {1,-15} | {2,10} ", "ID", "Name", "Price (PKR)");
            Console.WriteLine("{0,5} | {1,-15} | {2,10} ", "1", "Pen", "Rs:100");
            Console.WriteLine("{0,5} | {1,-15} | {2,10} ", "2", "Watch", "Rs:1000");
            Console.WriteLine("{0,5} | {1,-15} | {2,10} ", "3", "Cocomo", "Rs:50");
            Console.WriteLine("{0,5} | {1,-15} | {2,10} ", "4", "keyBoard", "Rs:10000");

            Product product = new Product();

            Console.Write("Enter Product ID: ");
            product.Id = int.Parse(Console.ReadLine());

            var checks = cartItems.FirstOrDefault(x => x.Id == product.Id);
            if (checks != null)
            {

                Console.Write($"Enter quantity of {checks.Name} at {checks.Price} PKR: ");
                int quant = int.Parse(Console.ReadLine());
                checks.Quantity = quant + checks.Quantity;
                Console.WriteLine("Product added to the cart successfully!");
                return;

            }
            if (product.Id == 1)
            {
                product.Name = "Pen";
                product.Price = 100m;
                Console.Write($"Enter quantity of {product.Name} at {product.Price} PKR: ");
                product.Quantity = int.Parse(Console.ReadLine());
                cartItems.Add(product);
                return;
            }
            else if (product.Id == 2)
            {
                product.Name = "Watch";
                product.Price = 1000m;
                Console.Write($"Enter quantity of {product.Name} at {product.Price} PKR: ");
                product.Quantity = int.Parse(Console.ReadLine());
                cartItems.Add(product);
                return;
            }
            else if (product.Id == 3)
            {
                product.Name = "Cocomo";
                product.Price = 50m;
                Console.Write($"Enter quantity of {product.Name} at {product.Price} PKR: ");
                product.Quantity = int.Parse(Console.ReadLine());
                cartItems.Add(product);
                return;
            }
            else if (product.Id == 4)
            {
                product.Name = "Keyboard";
                product.Price = 10000m;
                Console.Write($"Enter quantity of {product.Name} at {product.Price} PKR: ");
                product.Quantity = int.Parse(Console.ReadLine());
                cartItems.Add(product);
                return;
            }


            Console.Write("Enter Product Name: ");
            product.Name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            product.Price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Product Quantity: ");
            product.Quantity = int.Parse(Console.ReadLine());

            cartItems.Add(product);
            Console.WriteLine("Product added to the cart successfully!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid values.");
        }

    }
    public async Task ViewCart()
    {
        Console.Clear();
        if (!cartItems.Any())
        {
            Console.WriteLine("Cart is empty!");
            clearScreen();
            return;
        }
        else
        {
            CartExpiration();
        }
        decimal subtotal = 0;
        Console.WriteLine("\n--- Items in Your Cart ---");
        Console.WriteLine("{0,5} | {1,-15} | {2,10} | {3,8} | {4,12}",
                          "ID", "Name", "Price (PKR)", "Quantity", "Total (PKR)");
        foreach (var product in cartItems)
        {
            decimal itemTotal = product.Price * product.Quantity;
            subtotal += itemTotal;
            Console.WriteLine("{0,5} | {1,-15} | {2,10:N2} | {3,8} | {4,12:N2}",
                  product.Id, product.Name, product.Price,
                  product.Quantity, itemTotal);
        }

        const decimal discountRate = 0.10m;
        const decimal salesTaxRate = 0.08m;

        decimal discount = subtotal * discountRate;
        decimal taxableAmount = subtotal - discount;
        decimal salesTax = taxableAmount * salesTaxRate;


        decimal totalAmount = taxableAmount + salesTax;


        Console.WriteLine($"\nSubtotal      : Rs:{subtotal}");
        Console.WriteLine($"Discount (10%):-Rs:{discount}");
        Console.WriteLine($"Sales Tax (8%):+Rs{salesTax}");
        Console.WriteLine($"Total Amount  : Rs:{totalAmount}");

        Console.WriteLine("\n\n1. CheckOut");
        Console.WriteLine("2. Goback");
        Console.Write("Please enter your choice : ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            if (cartItems.Any())
            {
                cartItems.Clear();
                Console.Clear();
            }
            Console.WriteLine("Checkout SuccessFull");
            clearScreen();
        }


    }
    public async Task CartExpiration()
    {
        await Task.Delay(180 * 1000);
        cartItems.Clear();
        Console.Clear();
        Console.WriteLine("\nThe cart has been cleared due to inactivity.");
        clearScreen();
    }

    public void RemoveProduct()
    {
        Console.Clear();
        try
        {
            Console.Write("Enter the Product ID to remove: ");
            int productId = int.Parse(Console.ReadLine());

            var product = cartItems.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                Console.WriteLine($"Product under Name: {product.Name} removed from the cart.");
                cartItems.Remove(product);

            }
            else
            {
                Console.WriteLine("Product not found in the cart.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid Product ID.");
        }
        clearScreen();
    }
    void clearScreen()
    {
        Console.Write("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
    }
}

class User
{
    static void Main(string[] args)
    {
        Cart cart = new Cart();
        bool check = true;
        int choice;

        do
        {
            Console.Clear();
            try
            {
                Console.WriteLine("\n--- Shopping Cart Menu ---");
                Console.WriteLine("1. Add Product to Cart");
                Console.WriteLine("2. Remove Product from Cart");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        cart.AddProduct();
                        break;
                    case 2:
                        cart.RemoveProduct();
                        break;
                    case 3:
                        cart.ViewCart();
                        break;
                    case 4:
                        check = false;
                     
                        Console.WriteLine("Exiting... !");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
        } while (check);
    }
}
