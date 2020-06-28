using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIproject.Logic
{
    class Node
    {
        public string name { get; set; }
        public double weight { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public bool isTested { get; set; }
        public int depth = -1;

        public List<Link> links { get; set; }

        public Node(String name)
        {
            this.name = name;
            links = new List<Link>();
        }

        public Node(String name, double weight) : this(name)
        {
            this.weight = weight;
        }

        public Node(String name, double weight, double x, double y) : this(name, weight)
        {
            this.x = x;
            this.y = x;
        }

        public void AddLink(Link link)
        {
            if (link == null)
            {
                throw new Exception("Link is valid");
            }

            links.Add(link);
        }

        public List<Node> GetRelatedNodes()
        {
            List<Node> nodes = new List<Node>();

            foreach (Link link in links)
            {
                if (!nodes.Contains(link.relatedNode))
                    nodes.Add(link.relatedNode);
            }

            return nodes;
        }
    }
}
