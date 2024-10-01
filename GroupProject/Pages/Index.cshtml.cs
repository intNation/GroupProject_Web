using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;

namespace GroupProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly WebServiceClient client;

        public IndexModel(WebServiceClient client)
        {
            this.client = client;
        }

        public List<ServiceReference1.Product> FeaturedProducts { get; set; }
        public List<ServiceReference1.Product> SaleItems { get; set; }
        public void OnGet()
        {
            FeaturedProducts = client.GetFeaturedProductsAsync().Result;
            SaleItems = client.GetProductsOnSaleOnCategoryAsync("Accessories").Result;

        }
    }
}
