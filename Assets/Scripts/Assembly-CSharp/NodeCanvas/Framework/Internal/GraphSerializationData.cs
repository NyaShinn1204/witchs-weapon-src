using System;
using System.Collections.Generic;
using UnityEngine;

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class GraphSerializationData
	{
		private const float SERIALIZATION_VERSION = 2.6f;

		public float version;

		public Type type;

		public string name;

		public string comments;

		public Vector2 translation;

		public float zoomFactor;

		public List<Node> nodes;

		public List<Connection> connections;

		public Node primeNode;

		public List<CanvasGroup> canvasGroups;

		public BlackboardSource localBlackboard;

		public object derivedData;

		public GraphSerializationData()
		{
		}

		public GraphSerializationData(Graph graph)
		{
		}

		public void Reconstruct(Graph graph)
		{
		}
	}
}
