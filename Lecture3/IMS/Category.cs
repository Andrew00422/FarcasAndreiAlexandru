// Import the System namespace for fundamental classes like Console, String, etc.
using System;

// Define a namespace to organize related classes and avoid naming conflicts.
namespace IMS
{
    /// <summary>
    /// Represents a product category in the inventory.
    /// </summary>
    public class Category
    {
        // Private field to store the category ID internally.
        private int _categoryId;

        // Private field to store the category name internally.
        private string _categoryName;

        /// <summary>
        /// Public property to get or set the Category ID.
        /// Ensures that the ID is positive before setting.
        /// </summary>
        public int CategoryId
        {
            // Get the value of the private _categoryId field.
            get { return _categoryId; }

            // Set the value of _categoryId with validation.
            set 
            { 
                // Ensure the value is positive; otherwise, throw an exception.
                if (value <= 0)
                    throw new ArgumentException("Category ID must be positive.");
                _categoryId = value; 
            }
        }

        /// <summary>
        /// Public property to get or set the Category Name.
        /// Ensures that the name is not empty or only whitespace.
        /// </summary>
        public string CategoryName
        {
            // Get the value of the private _categoryName field.
            get { return _categoryName; }

            // Set the value of _categoryName with validation.
            set 
            { 
                // Ensure the value is not null, empty, or only whitespace; otherwise, throw an exception.
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Category Name cannot be empty.");
                _categoryName = value; 
            }
        }

        /// <summary>
        /// Constructor to initialize a Category object with an ID and a Name.
        /// </summary>
        /// <param name="categoryId">Unique identifier for the category.</param>
        /// <param name="categoryName">Name of the category.</param>
        public Category(int categoryId, string categoryName)
        {
            // Use the properties to set the values, allowing validation.
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        /// <summary>
        /// Overrides the ToString method to provide a string representation of the Category.
        /// </summary>
        /// <returns>String containing Category ID and Name.</returns>
        public override string ToString()
        {
            // Return a formatted string that includes the category ID and name.
            return $"Category ID: {CategoryId}, Name: {CategoryName}";
        }
    }
}
