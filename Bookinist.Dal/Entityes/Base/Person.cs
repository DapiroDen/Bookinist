using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookinist.Dal.Entityes.Base
{
    public abstract class Person : NameEntity
    {
        public string SurName { get; set; }

        public string Patronymic { get; set; }
    }
}
