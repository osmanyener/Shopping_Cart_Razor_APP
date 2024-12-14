namespace ASP.NET.CoreRazorAPP.Pages
{
    public class ProductModel
    {
        List<Product> products = new List<Product>();

        public ProductModel()
        {
            products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    ProductName = "Apple",
                    ProductCode = "App1",
                    Price = 140
                },
                new Product()
                {
                    Id = 2,
                    ProductName = "Laptop",
                    ProductCode = "Lap1",
                    Price = 80
                },
                new Product()
                {
                    Id = 3,
                    ProductName = "MacBook",
                    ProductCode = "Mac1",
                    Price = 160
                },
            };
        }


        public List<Product> AllProducts()
        {
            return products;
        }
        
        public Product find(int id)
        {
            return products.Where(x => x.Id == id).FirstOrDefault();
        }
    }
    

}
