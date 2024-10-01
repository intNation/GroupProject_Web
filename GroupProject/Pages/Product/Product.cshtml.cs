using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace GroupProject.Pages.Product
{
    public class ProductModel : PageModel
    {
        WebServiceClient client = new WebServiceClient();
        public int productId { get; set; }
        public ServiceReference1.Product product;
        public void OnGet()
        {
            productId = Convert.ToInt32(Request.Query["ID"].ToString());
            product = client.GetProductByIDAsync(productId).Result;
        }
    }
}
