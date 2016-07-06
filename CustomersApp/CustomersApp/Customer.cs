using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class Customer : IComparable<Customer>, IEquatable<Customer>
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Address { get; set; }

        public int CompareTo(Customer other)
        {
            return String.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }

        public bool Equals(Customer other)
        {
            return string.Equals(this.Name, other.Name, StringComparison.OrdinalIgnoreCase) && (this.ID == other.ID);
        }
    }
}
