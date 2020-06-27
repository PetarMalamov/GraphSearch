using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIproject.Logic
{
    class WeigthSearch
    {
		public Graph graph { get; set; }

		public WeigthSearch(Graph graph)
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

			startNode.depth = 0;

			queue.Add(startNode);

			while (queue.Count > 0)
			{
				Node testNode = queue.ElementAt(0);
				queue.RemoveAt(0);

				if (testNode.name.Equals(to))
				{

					Console.WriteLine("The path is:");
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

			Console.WriteLine(currentEl.name);

			if (currentEl.depth == 0)
			{
				return path;
			}

			List<Node> nodes = currentEl.GetRelatedNodes();

			foreach (Node el in nodes)
			{
				if (el.depth < currentEl.depth)
				{
					displayPath(el,path);
					break;
				}
			}
			return path;
		}

		private void addNodeToQueue(List<Node> queue, Node placingNode)
		{
			if (placingNode.isTested || queue.Contains(placingNode))
				return;

			for (int i = 0; i < queue.Count(); i++)
			{
				if (placingNode.weight < queue[i].weight)
				{
					queue.Insert(i, placingNode);
					return;
				}
			}

			queue.Add(placingNode);
		}
	}
}
