using IFSPstore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPstore.Domain.Entities
{
    public class City : BaseEntitiy<int>
    {
        public string? Name { get; set; }
        public string? State { get; set; }

        public City(int id, string name,  string state) : base(id)
        {
            Name = name;
            State = State;
        }
        public City()
        {

        }

    }
}
