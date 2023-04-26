using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part) => _parts.Add(part);

        public string ListParts()
        {
            return string.Join(", ", _parts.ToArray());
        }
    }
}
