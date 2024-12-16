using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class CollectionTest
    {
        public List<string> student { get; set; }

        public List<string> Initialize()
        {
            return new List<string>
            {
                "Barry",
                "Alan",
                "Casly",
                "Dex"
            };

        }
    }
}
