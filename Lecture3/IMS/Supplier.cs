using System;

namespace IMS
{
    /// <summary>
    /// Represents a supplier in the inventory system.
    /// </summary>
    public class Supplier
    {
        // Private fields to store data
        private int _supplierId;
        private string _supplierName;
        private string _contactEmail;

        /// <summary>
        /// Public property to get or set the Supplier ID.
        /// </summary>
        public int SupplierId
        {
            get { return _supplierId; }
            set 
            { 
                if (value <= 0)
                    throw new ArgumentException("Supplier ID must be positive.");
                _supplierId = value; 
            }
        }

        /// <summary>
        /// Public property to get or set the Supplier Name.
        /// </summary>
        public string SupplierName
        {
            get { return _supplierName; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Supplier Name cannot be empty.");
                _supplierName = value; 
            }
        }

        /// <summary>
        /// Public property to get or set the Supplier Contact Email.
        /// </summary>
        public string ContactEmail
        {
            get { return _contactEmail; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                    throw new ArgumentException("Invalid email address.");
                _contactEmail = value; 
            }
        }

        /// <summary>
        /// Constructor to initialize a Supplier object with ID, Name, and Contact Email.
        /// </summary>
        /// <param name="supplierId">Unique identifier for the supplier.</param>
        /// <param name="supplierName">Name of the supplier.</param>
        /// <param name="contactEmail">Contact email of the supplier.</param>
        public Supplier(int supplierId, string supplierName, string contactEmail)
        {
            SupplierId = supplierId;
            SupplierName = supplierName;
            ContactEmail = contactEmail;
        }

        /// <summary>
        /// Overrides the ToString method to provide a string representation of the Supplier.
        /// </summary>
        /// <returns>String containing Supplier ID, Name, and Contact Email.</returns>
        public override string ToString()
        {
            return $"Supplier ID: {SupplierId}, Name: {SupplierName}, Email: {ContactEmail}";
        }
    }
}
