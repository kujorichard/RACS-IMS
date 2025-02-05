using MongoDB.Driver;
using RAC_IMS.Backend_MongoDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAC_IMS
{
    public partial class ProductList : Form
    {
        // Declare MongoDB service and product collection variables
        private MongoDBService _mongoService;  // MongoDB service for database operations
        private IMongoCollection<Product> _productCollection;  // Collection to store products in MongoDB

        public ProductList()
        {
            InitializeComponent();

            // MongoDB connection string to connect to local instance (localhost) and specify database name
            string connectionString = "mongodb://localhost:27017/"; // MongoDB connection URL (default for local MongoDB)
            string databaseName = "Products"; // Name of the MongoDB database to use
            _mongoService = new MongoDBService(connectionString, databaseName); // Create instance of MongoDBService with the connection info
            _productCollection = _mongoService.GetProductsCollection(); // Get list of products in the Products database
        }

        // Method to insert a product into the MongoDB collection
        private async void InsertProduct(Product product)
        {
            // Insert the provided product into the MongoDB collection asynchronously
            await _productCollection.InsertOneAsync(product);  // This call sends the product data to MongoDB to be stored
        }

        // Load Products to DataGridView
        private async void LoadProducts()
        {
            // Retrieve all the products from the MongoDB 'Products' collection asynchronously
            var products = await _productCollection.Find(_ => true).ToListAsync(); // This fetches all products from the collection
            // Bind the list of products to the DataGridView for display
            products_data_grid.DataSource = products; // Sets the data source of the DataGridView to the fetched list of products
        }

        // Event handler for button click to add a new product
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Create a new Product object with sample data
            var newProduct = new Product
            {
                ID = 101, // Unique identifier for the product
                name = "Car Shampoo", // Name of the product
                reseller_price = 10.5, // Reseller price for the product
                wholesale_price = 7.0, // Wholesale price of the product
                retail_price = 15.0, // Retail price of the product
                category = "Cleaning Supplies", // Category that the product belongs to
                supplier_id = 3 // ID of the supplier providing this product
            };

            // Call the InsertProduct method to insert the newly created product into MongoDB
            InsertProduct(newProduct); // This will send the new product data to the MongoDB database
        }

        // Event handler to load products into the DataGridView when the form is first loaded
        private void ProductList_Load(object sender, EventArgs e)
        {
            // Call LoadProducts to fetch the data from MongoDB and display it in the DataGridView
            LoadProducts(); // This loads and displays the products from MongoDB when the form is loaded
        }
    }
}
