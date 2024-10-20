// Import the System namespace, which contains fundamental classes for console input/output and other basic functionalities.
using System;

// Import the System.Collections.Generic namespace to use generic collections like List<T>.
using System.Collections.Generic;

// Define a namespace to organize related classes and avoid naming conflicts.
// All classes related to the Inventory Management System are contained within this namespace.
namespace IMS
{
    // The Program class contains the entry point of the application.
    class Program
    {
        // The Main method is the starting point of the application.
        // When the program runs, execution begins here.
        static void Main(string[] args)
        {
            // Create a list to store Supplier objects.
            List<Supplier> suppliers = new List<Supplier>();
            
            // Create a list to store Category objects.
            List<Category> categories = new List<Category>();
            
            // Create a list to store Product objects.
            List<Product> products = new List<Product>();

            // Display a welcome message to the user.
            Console.WriteLine("Welcome to the Inventory Management System!\n");

            // =======================
            // Section: Collect Suppliers
            // =======================
            Console.WriteLine("=== Enter Suppliers ==="); // Display section header for suppliers.

            // Prompt the user to enter the number of suppliers they wish to add.
            int supplierCount = ReadPositiveInt("How many suppliers would you like to enter? ");

            // Loop through the number of suppliers to collect their details.
            for (int i = 0; i < supplierCount; i++)
            {
                // Inform the user which supplier they're entering details for.
                Console.WriteLine($"\nEntering details for Supplier {i + 1}:");
                
                // Use a loop to ensure valid input is collected.
                while (true)
                {
                    try
                    {
                        // Prompt and read the Supplier ID, ensuring it's a positive integer.
                        int supplierId = ReadPositiveInt("Enter Supplier ID: ");
                        
                        // Prompt and read the Supplier Name, ensuring it's not empty.
                        string supplierName = ReadNonEmptyString("Enter Supplier Name: ");
                        
                        // Prompt and read the Supplier Contact Email, ensuring it's a valid email format.
                        string contactEmail = ReadValidEmail("Enter Supplier Contact Email: ");

                        // Create a new Supplier object with the provided details.
                        Supplier supplier = new Supplier(supplierId, supplierName, contactEmail);
                        
                        // Add the new Supplier to the suppliers list.
                        suppliers.Add(supplier);
                        
                        // Inform the user that the supplier was added successfully.
                        Console.WriteLine("Supplier added successfully!");
                        
                        // Exit the input loop since the supplier was added without errors.
                        break;
                    }
                    catch (Exception ex) // Catch any exceptions thrown during Supplier creation.
                    {
                        // Display the error message to the user.
                        Console.WriteLine($"Error: {ex.Message}");
                        
                        // Prompt the user to re-enter the supplier details.
                        Console.WriteLine("Please re-enter the supplier details.\n");
                    }
                }
            }

            // =======================
            // Section: Collect Categories
            // =======================
            Console.WriteLine("\n=== Enter Categories ==="); // Display section header for categories.

            // Prompt the user to enter the number of categories they wish to add.
            int categoryCount = ReadPositiveInt("How many categories would you like to enter? ");

            // Loop through the number of categories to collect their details.
            for (int i = 0; i < categoryCount; i++)
            {
                // Inform the user which category they're entering details for.
                Console.WriteLine($"\nEntering details for Category {i + 1}:");
                
                // Use a loop to ensure valid input is collected.
                while (true)
                {
                    try
                    {
                        // Prompt and read the Category ID, ensuring it's a positive integer.
                        int categoryId = ReadPositiveInt("Enter Category ID: ");
                        
                        // Prompt and read the Category Name, ensuring it's not empty.
                        string categoryName = ReadNonEmptyString("Enter Category Name: ");

                        // Create a new Category object with the provided details.
                        Category category = new Category(categoryId, categoryName);
                        
                        // Add the new Category to the categories list.
                        categories.Add(category);
                        
                        // Inform the user that the category was added successfully.
                        Console.WriteLine("Category added successfully!");
                        
                        // Exit the input loop since the category was added without errors.
                        break;
                    }
                    catch (Exception ex) // Catch any exceptions thrown during Category creation.
                    {
                        // Display the error message to the user.
                        Console.WriteLine($"Error: {ex.Message}");
                        
                        // Prompt the user to re-enter the category details.
                        Console.WriteLine("Please re-enter the category details.\n");
                    }
                }
            }

            // =======================
            // Section: Collect Products
            // =======================
            Console.WriteLine("\n=== Enter Products ==="); // Display section header for products.

            // Prompt the user to enter the number of products they wish to add.
            int productCount = ReadPositiveInt("How many products would you like to enter? ");

            // Loop through the number of products to collect their details.
            for (int i = 0; i < productCount; i++)
            {
                // Inform the user which product they're entering details for.
                Console.WriteLine($"\nEntering details for Product {i + 1}:");
                
                // Use a loop to ensure valid input is collected.
                while (true)
                {
                    try
                    {
                        // Prompt and read the Product ID, ensuring it's a positive integer.
                        int itemId = ReadPositiveInt("Enter Product ID: ");
                        
                        // Prompt and read the Product Name, ensuring it's not empty.
                        string itemName = ReadNonEmptyString("Enter Product Name: ");
                        
                        // Prompt and read the Quantity in Stock, ensuring it's a non-negative integer.
                        int quantity = ReadNonNegativeInt("Enter Quantity in Stock: ");
                        
                        // Prompt and read the Price per Unit, ensuring it's a non-negative decimal.
                        decimal price = ReadNonNegativeDecimal("Enter Price per Unit: ");

                        // Allow the user to select an existing Category from the list.
                        Category selectedCategory = SelectCategory(categories);
                        
                        // If no categories are available, inform the user and exit the product entry loop.
                        if (selectedCategory == null)
                        {
                            Console.WriteLine("No categories available. Please add a category first.");
                            break;
                        }

                        // Allow the user to select an existing Supplier from the list.
                        Supplier selectedSupplier = SelectSupplier(suppliers);
                        
                        // If no suppliers are available, inform the user and exit the product entry loop.
                        if (selectedSupplier == null)
                        {
                            Console.WriteLine("No suppliers available. Please add a supplier first.");
                            break;
                        }

                        // Create a new Product object with the provided details and selected Category and Supplier.
                        Product product = new Product(itemId, itemName, quantity, price, selectedCategory, selectedSupplier);
                        
                        // Add the new Product to the products list.
                        products.Add(product);
                        
                        // Inform the user that the product was added successfully.
                        Console.WriteLine("Product added successfully!");
                        
                        // Exit the input loop since the product was added without errors.
                        break;
                    }
                    catch (Exception ex) // Catch any exceptions thrown during Product creation.
                    {
                        // Display the error message to the user.
                        Console.WriteLine($"Error: {ex.Message}");
                        
                        // Prompt the user to re-enter the product details.
                        Console.WriteLine("Please re-enter the product details.\n");
                    }
                }
            }

            // =======================
            // Section: Display Entered Data
            // =======================
            Console.WriteLine("\n=== Inventory Data ===\n"); // Display section header for inventory data.

            // Display all entered Categories.
            Console.WriteLine("Categories:");
            foreach (var category in categories)
            {
                Console.WriteLine(category); // Calls the ToString() method of the Category class.
            }

            Console.WriteLine(); // Print a blank line for better readability.

            // Display all entered Suppliers.
            Console.WriteLine("Suppliers:");
            foreach (var supplier in suppliers)
            {
                Console.WriteLine(supplier); // Calls the ToString() method of the Supplier class.
            }

            Console.WriteLine(); // Print a blank line for better readability.

            // Display all entered Products.
            Console.WriteLine("Products:");
            foreach (var product in products)
            {
                Console.WriteLine(product); // Calls the ToString() method of the Product class.
            }

            // =======================
            // Section: Exit Prompt
            // =======================
            // Inform the user to press any key to exit the application.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(); // Waits for the user to press a key before closing.
        }

        // =======================
        // Helper Methods
        // =======================

        /// <summary>
        /// Reads a positive integer from the console.
        /// Continues to prompt the user until a valid positive integer is entered.
        /// </summary>
        /// <param name="prompt">The message displayed to prompt the user.</param>
        /// <returns>A positive integer entered by the user.</returns>
        static int ReadPositiveInt(string prompt)
        {
            int value; // Variable to store the user's input.

            // Loop indefinitely until a valid input is received.
            while (true)
            {
                Console.Write(prompt); // Display the prompt message.
                string input = Console.ReadLine(); // Read the user's input as a string.

                // Try to parse the input string to an integer.
                if (int.TryParse(input, out value) && value > 0)
                    return value; // Return the parsed value if it's a positive integer.

                // Inform the user of invalid input and prompt again.
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        /// <summary>
        /// Reads a non-negative integer from the console.
        /// Continues to prompt the user until a valid non-negative integer is entered.
        /// </summary>
        /// <param name="prompt">The message displayed to prompt the user.</param>
        /// <returns>A non-negative integer entered by the user.</returns>
        static int ReadNonNegativeInt(string prompt)
        {
            int value; // Variable to store the user's input.

            // Loop indefinitely until a valid input is received.
            while (true)
            {
                Console.Write(prompt); // Display the prompt message.
                string input = Console.ReadLine(); // Read the user's input as a string.

                // Try to parse the input string to an integer.
                if (int.TryParse(input, out value) && value >= 0)
                    return value; // Return the parsed value if it's a non-negative integer.

                // Inform the user of invalid input and prompt again.
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
        }

        /// <summary>
        /// Reads a non-empty string from the console.
        /// Continues to prompt the user until a non-empty string is entered.
        /// </summary>
        /// <param name="prompt">The message displayed to prompt the user.</param>
        /// <returns>A non-empty string entered by the user.</returns>
        static string ReadNonEmptyString(string prompt)
        {
            // Loop indefinitely until a valid input is received.
            while (true)
            {
                Console.Write(prompt); // Display the prompt message.
                string input = Console.ReadLine(); // Read the user's input as a string.

                // Check if the input is not null, empty, or whitespace.
                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim(); // Return the trimmed input string.

                // Inform the user of invalid input and prompt again.
                Console.WriteLine("Input cannot be empty. Please try again.");
            }
        }

        /// <summary>
        /// Reads a valid email address from the console.
        /// Continues to prompt the user until a valid email containing '@' is entered.
        /// </summary>
        /// <param name="prompt">The message displayed to prompt the user.</param>
        /// <returns>A valid email address entered by the user.</returns>
        static string ReadValidEmail(string prompt)
        {
            // Loop indefinitely until a valid email is received.
            while (true)
            {
                Console.Write(prompt); // Display the prompt message.
                string email = Console.ReadLine(); // Read the user's input as a string.

                // Check if the email is not null, empty, and contains an '@' symbol.
                if (!string.IsNullOrWhiteSpace(email) && email.Contains("@"))
                    return email.Trim(); // Return the trimmed email string.

                // Inform the user of invalid input and prompt again.
                Console.WriteLine("Invalid email address. Please enter a valid email containing '@'.");
            }
        }

        /// <summary>
        /// Reads a non-negative decimal value from the console.
        /// Continues to prompt the user until a valid non-negative decimal is entered.
        /// </summary>
        /// <param name="prompt">The message displayed to prompt the user.</param>
        /// <returns>A non-negative decimal entered by the user.</returns>
        static decimal ReadNonNegativeDecimal(string prompt)
        {
            decimal value; // Variable to store the user's input.

            // Loop indefinitely until a valid input is received.
            while (true)
            {
                Console.Write(prompt); // Display the prompt message.
                string input = Console.ReadLine(); // Read the user's input as a string.

                // Try to parse the input string to a decimal.
                if (decimal.TryParse(input, out value) && value >= 0)
                    return value; // Return the parsed value if it's a non-negative decimal.

                // Inform the user of invalid input and prompt again.
                Console.WriteLine("Invalid input. Please enter a non-negative decimal number.");
            }
        }

        /// <summary>
        /// Allows the user to select a Category from the list of available categories.
        /// Displays all available categories and prompts the user to enter a valid Category ID.
        /// </summary>
        /// <param name="categories">List of available Category objects.</param>
        /// <returns>The selected Category object, or null if no categories are available.</returns>
        static Category SelectCategory(List<Category> categories)
        {
            // Check if there are any categories available.
            if (categories.Count == 0)
                return null; // Return null if no categories are available.

            Console.WriteLine("\nAvailable Categories:"); // Display a header for available categories.

            // Loop through each category and display its ID and Name.
            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryId}, Name: {category.CategoryName}");
            }

            // Loop indefinitely until a valid Category ID is selected.
            while (true)
            {
                // Prompt the user to enter a Category ID.
                int selectedId = ReadPositiveInt("Enter the Category ID for the product: ");
                
                // Search for the Category with the entered ID in the categories list.
                Category selectedCategory = categories.Find(c => c.CategoryId == selectedId);
                
                // If a matching Category is found, return it.
                if (selectedCategory != null)
                    return selectedCategory;

                // Inform the user if the entered Category ID was not found.
                Console.WriteLine("Category ID not found. Please enter a valid Category ID.");
            }
        }

        /// <summary>
        /// Allows the user to select a Supplier from the list of available suppliers.
        /// Displays all available suppliers and prompts the user to enter a valid Supplier ID.
        /// </summary>
        /// <param name="suppliers">List of available Supplier objects.</param>
        /// <returns>The selected Supplier object, or null if no suppliers are available.</returns>
        static Supplier SelectSupplier(List<Supplier> suppliers)
        {
            // Check if there are any suppliers available.
            if (suppliers.Count == 0)
                return null; // Return null if no suppliers are available.

            Console.WriteLine("\nAvailable Suppliers:"); // Display a header for available suppliers.

            // Loop through each supplier and display its ID and Name.
            foreach (var supplier in suppliers)
            {
                Console.WriteLine($"ID: {supplier.SupplierId}, Name: {supplier.SupplierName}");
            }

            // Loop indefinitely until a valid Supplier ID is selected.
            while (true)
            {
                // Prompt the user to enter a Supplier ID.
                int selectedId = ReadPositiveInt("Enter the Supplier ID for the product: ");
                
                // Search for the Supplier with the entered ID in the suppliers list.
                Supplier selectedSupplier = suppliers.Find(s => s.SupplierId == selectedId);
                
                // If a matching Supplier is found, return it.
                if (selectedSupplier != null)
                    return selectedSupplier;

                // Inform the user if the entered Supplier ID was not found.
                Console.WriteLine("Supplier ID not found. Please enter a valid Supplier ID.");
            }
        }
    }
}
