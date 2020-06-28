using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIproject.Logic
{
    class WeigthCoordinatesSearch
    {
		public Graph graph { get; set; }
		private double x;
		private double y;
		public WeigthCoordinatesSearch(Graph graph)
		{
			this.graph = graph;
		}

		public List<string> search(String from, String to)
		{

			Node startNode = graph.getNode(from);
			Node endNode = graph.getNode(to);

			if (startNode == null || endNode == null)
			{
				return null;
			}
			x = endNode.x;
			y = endNode.y;
			List<Node> queue = new List<Node>();

			startNode.depth = 0;

			queue.Add(startNode);

			while (queue.Count > 0)
			{
				Node testNode = queue.ElementAt(0);
				queue.RemoveAt(0);

				if (testNode.name.Equals(to))
				{
					List<string> path = new List<string>();
					path = displayPath(testNode, path);
					return path;
				}

				testNode.isTested = true;

				List<Node> relatedNodes = testNode.GetRelatedNodes();

				foreach (Node el in relatedNodes)
				{
					if (el.depth == -1)
						el.depth = testNode.depth + 1;

					addNodeToQueue(queue, el);
				}
			}

			return null;
		}


		private List<string> displayPath(Node currentEl, List<string> path)
		{

			path.Add(currentEl.name);

			if (currentEl.depth == 0)
			{
				return path;
			}

			
			List<Node> nodes = currentEl.GetRelatedNodes();

			foreach (Node el in nodes)
			{
				if (el.depth < currentEl.depth)
				{
					displayPath(el, path);
					break;
				}
			}

			return path;
		}

		private void addNodeToQueue(List<Node> nodes, Node node)
		{
			if (node.isTested || nodes.Contains(node))
				return;

			node.weight = calculateFinalWeight(node.x, node.y, node.weight);
			for (int i = 0; i < nodes.Count(); i++)
			{
				nodes[i].weight = calculateFinalWeight(nodes[i].x, nodes[i].y, nodes[i].weight);
				if (node.weight < nodes[i].weight)
				{
					nodes.Insert(i, node);
					return;
				}
			}

			nodes.Add(node);
		}

		private double calculateFinalWeight(double x, double y, double weight)
		{
			double a = Math.Abs(x - this.x);
			double b = Math.Abs(y - this.y);

			double xy = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

			double FW = (weight * 0.8) + (xy * 0.6);
			return FW;

		}
	}
}
