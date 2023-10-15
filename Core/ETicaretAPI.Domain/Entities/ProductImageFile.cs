using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    /// <summary>
    /// TPH yapılanmasındaki 2.yapı
    /// </summary>
    public class ProductImageFile:File
    {
        public bool Showcase { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
