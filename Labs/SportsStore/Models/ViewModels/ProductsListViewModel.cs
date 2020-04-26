using System.Collections.Generic;
using SportsStore.Models;

namespace SportsStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; } // list of products
        public PagingInfo PagingInfo { get; set; } // divides the number of products per page
        public string CurrentCategory { get; set; }
    }
}
