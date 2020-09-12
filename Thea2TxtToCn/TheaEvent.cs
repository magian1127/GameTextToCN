using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea2TxtToCn
{
    public class Event
    {
        public string Name { get; set; }

        public List<Node> NODE { get; set; }
    }
    public class Node
    {
        public string Name { get; set; }

        public string STORY { get; set; }

        public List<string> OUT { get; set; }

    }
}
