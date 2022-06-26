using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblProducts = new HashSet<TblProduct>();
        }

        public int Id { get; set; }
        public string CatName { get; set; }

        public virtual ICollection<TblProduct> TblProducts { get; set; }
    }
}
