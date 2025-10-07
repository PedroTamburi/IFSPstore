using IFSPstore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IFSPstore.Domain.Entities
{
    public class Category : BaseEntitiy<int>
    {
        public string Name { get; set; }

        public Category(int id, string name) : base(id)
        {
            Name = name;
        }
        public Category()
        {

        }

    }
}
