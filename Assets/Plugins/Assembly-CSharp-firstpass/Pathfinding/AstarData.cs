using System;
using System.Collections;
using System.Diagnostics;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class AstarData
	{
		[NonSerialized]
		public NavMeshGraph navmesh;

		[NonSerialized]
		public GridGraph gridGraph;

		[NonSerialized]
		public PointGraph pointGraph;

		[NonSerialized]
		public RecastGraph recastGraph;

		public Type[] graphTypes;

		[NonSerialized]
		public NavGraph[] graphs;

		[NonSerialized]
		public UserConnection[] userConnections;

		public bool hasBeenReverted;

		[SerializeField]
		private byte[] data;

		public uint dataChecksum;

		public byte[] data_backup;

		public byte[] data_cachedStartup;

		public byte[] revertData;

		[SerializeField]
		public bool cacheStartup;

		public bool compress;

		public AstarPath active
		{
			get
			{
				return null;
			}
		}

		public byte[] GetData()
		{
			return null;
		}

		public void SetData(byte[] data, uint checksum)
		{
		}

		public void Awake()
		{
		}

		public void UpdateShortcuts()
		{
		}

		public void LoadFromCache()
		{
		}

		public void SaveCacheData(SerializeSettings settings)
		{
		}

		public byte[] SerializeGraphs()
		{
			return null;
		}

		public byte[] SerializeGraphs(SerializeSettings settings)
		{
			return null;
		}

		public byte[] SerializeGraphs(SerializeSettings settings, out uint checksum)
		{
			checksum = default(uint);
			return null;
		}

		public void SerializeGraphsPart(AstarSerializer sr)
		{
		}

		public void DeserializeGraphs()
		{
		}

		private void ClearGraphs()
		{
		}

		public void OnDestroy()
		{
		}

		public void DeserializeGraphs(byte[] bytes)
		{
		}

		public void DeserializeGraphsAdditive(byte[] bytes)
		{
		}

		public void DeserializeGraphsPart(AstarSerializer sr)
		{
		}

		public void DeserializeGraphsPartAdditive(AstarSerializer sr)
		{
		}

		public void FindGraphTypes()
		{
		}

		public Type GetGraphType(string type)
		{
			return null;
		}

		public NavGraph CreateGraph(string type)
		{
			return null;
		}

		public NavGraph CreateGraph(Type type)
		{
			return null;
		}

		public NavGraph AddGraph(string type)
		{
			return null;
		}

		public NavGraph AddGraph(Type type)
		{
			return null;
		}

		public void AddGraph(NavGraph graph)
		{
		}

		public bool RemoveGraph(NavGraph graph)
		{
			return false;
		}

		public static NavGraph GetGraph(GraphNode node)
		{
			return null;
		}

		public GraphNode GetNode(int graphIndex, int nodeIndex)
		{
			return null;
		}

		public GraphNode GetNode(int graphIndex, int nodeIndex, NavGraph[] graphs)
		{
			return null;
		}

		public NavGraph FindGraphOfType(Type type)
		{
			return null;
		}

		[DebuggerHidden]
		public IEnumerable FindGraphsOfType(Type type)
		{
			return null;
		}

		[DebuggerHidden]
		public IEnumerable GetUpdateableGraphs()
		{
			return null;
		}

		[DebuggerHidden]
		public IEnumerable GetRaycastableGraphs()
		{
			return null;
		}

		public int GetGraphIndex(NavGraph graph)
		{
			return 0;
		}

		public int GuidToIndex(Pathfinding.Util.Guid guid)
		{
			return 0;
		}

		public NavGraph GuidToGraph(Pathfinding.Util.Guid guid)
		{
			return null;
		}
	}
}
