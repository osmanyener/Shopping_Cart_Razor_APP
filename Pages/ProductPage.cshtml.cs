using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET.CoreRazorAPP.Pages
{
    public class ProductPageModel : PageModel
    {
        public List<Product> productList { get; set; }

        public void OnGet()
        {
            ProductModel productModel = new ProductModel();

            productList = productModel.AllProducts();

        }
    }
}
