using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIproject.Logic
{
    class Link
    {
        public string type { get; set; }
        public Node relatedNode { get; set; }

        public Link(Node relatedNode)
        {
            this.relatedNode = relatedNode;
        }
    }
}
