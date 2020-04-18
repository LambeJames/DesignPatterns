using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Car
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string GetParts()
        {
            return $"Car parts included are: {string.Join(" ,", _parts)}";
        }
    }
}
