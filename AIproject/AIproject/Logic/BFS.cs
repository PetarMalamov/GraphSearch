using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIproject.Logic
{
    class BFS
    {
		private Graph graph;

		public BFS(Graph graph)
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

			List<Node> queue = new List<Node>();
			List<Node> list = new List<Node>();

			queue.Add(startNode);

			while (queue.Count > 0)
			{

				Node testNode = queue.ElementAt(0);
				list.Add(testNode);
				queue.RemoveAt(0);

				testNode.isTested = true;

				if (testNode.name.Equals(to))
				{
					Console.WriteLine("path:");
					List<string> path = new List<string>();
					path = displayPath(testNode, list, path);
					return path;
				}

				List<Node> relatedNodes = testNode.GetRelatedNodes();

				foreach (Node el in relatedNodes)
				{
					if (!el.isTested && !queue.Contains(el))
					{
						queue.Add(el);
					}
				}

			}

			return null;
		}
		private List<string> displayPath(Node currentEl, List<Node> stack, List<string> path)
		{
			List<Node> links = currentEl.GetRelatedNodes();
			path.Add(currentEl.name);

			if (stack[0] == currentEl)
			{
				return path;
			}
			for (int i = 0; i < stack.Count; i++)
			{
				if (links.Contains(stack[i]))
				{
					displayPath(stack[i], stack, path);
					return path;
				}
			}

			return path;
		}
	}
}
