using IFSPstore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPstore.Domain.Entities
{
    public class Customer : BaseEntitiy<int>
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Document { get; set; }
        public string District { get; set; }
        public City City { get; set; }
        public Customer(int id, string name, string adress, string document, string district, City city) : base(id)
        {
            Name = name;
            Adress = adress;
            Document = document;
            District = district;
            City = city;
        }
        public Customer()
        {

        }
    }
}
