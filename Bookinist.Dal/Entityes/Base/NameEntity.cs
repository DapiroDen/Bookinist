using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookinist.Dal.Entityes.Base
{
    public abstract class NameEntity : Entity
    {
        [Required]
        public string Name { get; set; }

    }
}
