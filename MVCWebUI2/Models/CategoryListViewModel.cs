using System.Collections.Generic;
using Market.Entity.Concrete;

namespace Market.MVCWebUI2.Models
{
    public class CategoryListViewModel
    {
        public List<Category>Categories { get; set; }
        public int CurrentCategory { get;  set; }
    }
}
