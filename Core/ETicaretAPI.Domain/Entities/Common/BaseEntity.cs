using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        //Migrationlarımıza zorla ekleme bunu bastırabilelim.
        virtual public DateTime UpdatedDate { get; set; }

    }
}
