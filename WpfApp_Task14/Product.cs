using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Task14
{
    public enum ProductCategories
    {
        Еда,
        ЧайКофеКакао,
        БытоваяТехника,
        Посуда
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductCost { get; set; }
        public string ProductImage { get; set; }
        public ProductCategories ProductCategory { get; set; }
    }
}
