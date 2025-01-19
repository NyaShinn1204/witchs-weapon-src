using System.IO;

namespace Pathfinding.Serialization
{
	public class GraphSerializationContext
	{
		private readonly GraphNode[] id2NodeMapping;

		public readonly BinaryReader reader;

		public readonly BinaryWriter writer;

		public readonly int graphIndex;

		public GraphSerializationContext(BinaryReader reader, GraphNode[] id2NodeMapping, int graphIndex)
		{
		}

		public GraphSerializationContext(BinaryWriter writer)
		{
		}

		public int GetNodeIdentifier(GraphNode node)
		{
			return 0;
		}

		public GraphNode GetNodeFromIdentifier(int id)
		{
			return null;
		}
	}
}
