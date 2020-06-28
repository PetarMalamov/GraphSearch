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
		public List<string> LastSearch { get; set; }
		private double Endx;
		private double Endy;
		public WeigthCoordinatesSearch(Graph graph)
		{
			this.graph = graph;
		}

		public List<string> search(String from, String to)
		{
			LastSearch = new List<string>();
			Node startNode = graph.getNode(from);
			Node endNode = graph.getNode(to);

			if (startNode == null || endNode == null)
			{
				return null;
			}
			Endx = endNode.x;
			Endy = endNode.y;
			List<Node> queue = new List<Node>();

			queue.Add(startNode);

			while (queue.Count > 0)
			{
				Node testNode = queue.ElementAt(0);
				queue.RemoveAt(0);

				LastSearch.Add(testNode.name);

				if (testNode.name.Equals(to))
				{
					return LastSearch;
				}

				testNode.isTested = true;

				List<Node> relatedNodes = testNode.GetRelatedNodes();

				foreach (Node el in relatedNodes)
				{

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
			double a = Math.Abs(x - Endx);
			double b = Math.Abs(y - Endy);

			double xy = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

			double FW = (xy * 0.8) + (weight * 0.6);
			return FW;

		}
	}
}
