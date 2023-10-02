using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    /// <summary>
    /// TPH Yapılanmasındaki 3.yapı
    /// </summary>
    public class InvoiceFile:File
    {
        public decimal Price { get; set; }
    }
}
