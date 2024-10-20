using System;

namespace IMS
{
    /// <summary>
    /// Represents a product in the inventory, inheriting from Item.
    /// </summary>
    public class Product : Item
    {
        // Private fields specific to Product
        private int _quantity;
        private decimal _price;
        private Category _category;
        private Supplier _supplier;

        /// <summary>
        /// Public property to get or set the Quantity of the product.
        /// </summary>
        public int Quantity
        {
            get { return _quantity; }
            set 
            { 
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative.");
                _quantity = value; 
            }
        }

        /// <summary>
        /// Public property to get or set the Price of the product.
        /// </summary>
        public decimal Price
        {
            get { return _price; }
            set 
            { 
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                _price = value; 
            }
        }

        /// <summary>
        /// Public property to get or set the Category of the product.
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set 
            { 
                if (value == null)
                    throw new ArgumentNullException("Category cannot be null.");
                _category = value; 
            }
        }

        /// <summary>
        /// Public property to get or set the Supplier of the product.
        /// </summary>
        public Supplier Supplier
        {
            get { return _supplier; }
            set 
            { 
                if (value == null)
                    throw new ArgumentNullException("Supplier cannot be null.");
                _supplier = value; 
            }
        }

        /// <summary>
        /// Constructor to initialize a Product with all necessary details.
        /// </summary>
        /// <param name="itemId">Unique identifier for the product.</param>
        /// <param name="itemName">Name of the product.</param>
        /// <param name="quantity">Quantity in stock.</param>
        /// <param name="price">Price per unit.</param>
        /// <param name="category">Category of the product.</param>
        /// <param name="supplier">Supplier of the product.</param>
        public Product(int itemId, string itemName, int quantity, decimal price, Category category, Supplier supplier)
            : base(itemId, itemName) // Inheriting from Item
        {
            Quantity = quantity;
            Price = price;
            Category = category;
            Supplier = supplier;
        }

        /// <summary>
        /// Overrides the ToString method to provide a detailed string representation of the Product.
        /// </summary>
        /// <returns>String containing all product details.</returns>
        public override string ToString()
        {
            return $"{base.ToString()}, Quantity: {Quantity}, Price: {Price:C}, Category: {Category.CategoryName}, Supplier: {Supplier.SupplierName}";
        }
    }
}