using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace GroupProject.Pages.Product_Category
{
    public class CategoryProductsModel : PageModel
    {
        private readonly WebServiceClient client;

        public CategoryProductsModel(WebServiceClient client)
        {
            this.client = client;
        }

        public List<ServiceReference1.Product> Products { get; set; }
        public string category { get; set; }
        public void OnGet(string category)
        {
            this.category = category;
            Products = client.GetProductsbyCategoryAsync(category).Result;
        }
    }
}


