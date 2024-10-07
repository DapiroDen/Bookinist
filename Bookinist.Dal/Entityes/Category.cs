using Bookinist.Dal.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookinist.Dal.Entityes
{
    public class Category : NameEntity
    {
        public virtual ICollection<Book> Books { get; set; }
    }
}
