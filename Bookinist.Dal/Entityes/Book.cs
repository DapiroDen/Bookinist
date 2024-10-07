using Bookinist.Dal.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookinist.Dal.Entityes
{
    public class Book : NameEntity
    {
        public virtual Category Category { get; set; }
    }
}
