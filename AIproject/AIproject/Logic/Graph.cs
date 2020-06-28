using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIproject.Logic
{
    class Graph
    {
		private Dictionary<string, Node> graph = new Dictionary<string, Node>();

		public void addNode(Node node)
		{
			if (node == null)
			{
				Console.WriteLine("node is empty");
				return;
			}

			if (!graph.ContainsKey(node.name))
				graph.Add(node.name, node);
			else
				Console.WriteLine("Graph contains node");
		}
		public Node getNode(String name)
		{
			return graph[name];
		}

		public void AddLink(String nodeNameFrom, String nodeNameTo, bool isBiDirectional)
		{
			Node node1 = graph[nodeNameFrom];
			Node node2 = graph[nodeNameTo];

			if (node1 == null || node2 == null)
			{
				Console.WriteLine("empty roads");
				return;
			}

			try
			{
				node1.AddLink(new Link(node2));
			}
			catch (Exception e)
			{
				Console.WriteLine("no nononononn");
			}
			finally
			{
				Console.WriteLine("added");
			}

			if (isBiDirectional)
				try
				{
					node2.AddLink(new Link(node1));
				}
				catch (Exception e)
				{
					Console.WriteLine("no nononononn");
				}
		}

		public void addLink(String nodeNameFrom, String nodeNameTo, bool isBiDirectional)
		{

			Node node1 = graph[nodeNameFrom];
			Node node2 = graph[nodeNameTo];

			if (node1 == null || node2 == null)
			{
				Console.WriteLine("empty roads");
				return;
			}

			try
			{
				node1.AddLink(new Link(node2));

				if (isBiDirectional)
					node2.AddLink(new Link(node1));
			}
			catch (Exception e)
			{
				Console.WriteLine("sadasdasdaasd");
			}

		}

		public int GetGraphCount()
		{
			return graph.Count;
		}

		public List<string> getNodes()
		{
			List<string> nodes = new List<string>();
			foreach (var item in graph)
			{
				nodes.Add(item.Key);
			}
			return nodes;
		}

		public void ClearTested()
		{
			foreach (var item in graph)
			{
				item.Value.isTested = false;
				item.Value.depth = -1;
			}
		}
	}
}
