// Import the System namespace for fundamental classes like Console, String, etc.
using System;

// Define a namespace to organize related classes and avoid naming conflicts.
namespace IMS
{
    /// <summary>
    /// Base class representing a general item in the inventory.
    /// </summary>
    public class Item
    {
        // Private field to store the item ID internally.
        private int _itemId;

        // Private field to store the item name internally.
        private string _itemName;

        /// <summary>
        /// Public property to get or set the Item ID.
        /// Ensures that the ID is positive before setting.
        /// </summary>
        public int ItemId
        {
            // Get the value of the private _itemId field.
            get { return _itemId; }

            // Set the value of _itemId with validation.
            set 
            { 
                // Ensure the value is positive; otherwise, throw an exception.
                if (value <= 0)
                    throw new ArgumentException("Item ID must be positive.");
                _itemId = value; 
            }
        }

        /// <summary>
        /// Public property to get or set the Item Name.
        /// Ensures that the name is not empty or only whitespace.
        /// </summary>
        public string ItemName
        {
            // Get the value of the private _itemName field.
            get { return _itemName; }

            // Set the value of _itemName with validation.
            set 
            { 
                // Ensure the value is not null, empty, or only whitespace; otherwise, throw an exception.
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Item Name cannot be empty.");
                _itemName = value; 
            }
        }

        /// <summary>
        /// Constructor to initialize an Item with ID and Name.
        /// </summary>
        /// <param name="itemId">Unique identifier for the item.</param>
        /// <param name="itemName">Name of the item.</param>
        public Item(int itemId, string itemName)
        {
            // Use the properties to set the values, allowing validation.
            ItemId = itemId;
            ItemName = itemName;
        }

        /// <summary>
        /// Overrides the ToString method to provide a string representation of the Item.
        /// </summary>
        /// <returns>String containing Item ID and Name.</returns>
        public override string ToString()
        {
            // Return a formatted string that includes the item ID and name.
            return $"Item ID: {ItemId}, Name: {ItemName}";
        }
    }
}

        
