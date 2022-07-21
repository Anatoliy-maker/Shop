using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public class ICarsCategory
    {
        public IEnumerable<Category> Allcategories { get; }
    }
}
