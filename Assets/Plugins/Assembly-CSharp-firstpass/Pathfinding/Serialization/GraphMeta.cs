using System;

namespace Pathfinding.Serialization
{
	internal class GraphMeta
	{
		public Version version;

		public int graphs;

		public string[] guids;

		public string[] typeNames;

		public int[] nodeCounts;

		public Type GetGraphType(int i)
		{
			return null;
		}
	}
}
