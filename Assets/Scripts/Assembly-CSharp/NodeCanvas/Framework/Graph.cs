using System;
using System.Collections.Generic;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[Serializable]
	public abstract class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver, IScriptableComponent
	{
		[SerializeField]
		private string _serializedGraph;

		[SerializeField]
		private List<UnityEngine.Object> _objectReferences;

		[SerializeField]
		private bool _deserializationFailed;

		[NonSerialized]
		private bool hasDeserialized;

		public bool isInPool;

		private string _comments;

		private Vector2 _translation;

		private float _zoomFactor;

		private List<Node> _nodes;

		private Node _primeNode;

		private List<CanvasGroup> _canvasGroups;

		private BlackboardSource _localBlackboard;

		[NonSerialized]
		private Component _agent;

		[NonSerialized]
		private IBlackboard _blackboard;

		[NonSerialized]
		private static List<Graph> runningGraphs;

		[NonSerialized]
		private float timeStarted;

		[NonSerialized]
		private bool _isRunning;

		[NonSerialized]
		private bool _isPaused;

		public Node startNode;

		UnityEngine.Object ITaskSystem.contextObject
		{
			get
			{
				return null;
			}
		}

		public abstract Type baseNodeType { get; }

		public abstract bool requiresAgent { get; }

		public abstract bool requiresPrimeNode { get; }

		public abstract bool autoSort { get; }

		public abstract bool useLocalBlackboard { get; }

		public new string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string graphComments
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float elapsedTime
		{
			get
			{
				return 0f;
			}
		}

		public bool isRunning
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public bool isPaused
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public List<Node> allNodes
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Node primeNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<CanvasGroup> canvasGroups
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 translation
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float zoomFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Component agent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IBlackboard blackboard
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BlackboardSource localBlackboard
		{
			get
			{
				return null;
			}
		}

		public event Action<bool> OnFinish
		{
			add
			{
			}
			remove
			{
			}
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public void Serialize()
		{
		}

		public void Deserialize()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void OnDestroy()
		{
		}

		protected void OnValidate()
		{
		}

		public string Serialize(bool pretyJson, List<UnityEngine.Object> objectReferences)
		{
			return null;
		}

		public GraphSerializationData Deserialize(string serializedGraph, bool validate, List<UnityEngine.Object> objectReferences)
		{
			return null;
		}

		private bool LoadGraphData(GraphSerializationData data, bool validate)
		{
			return false;
		}

		public virtual object OnDerivedDataSerialization()
		{
			return null;
		}

		public virtual void OnDerivedDataDeserialization(object data)
		{
		}

		public void GetSerializationData(out string json, out List<UnityEngine.Object> references)
		{
			json = null;
			references = null;
		}

		public void SetSerializationObjectReferences(List<UnityEngine.Object> references)
		{
		}

		public static T Clone<T>(T graph) where T : Graph
		{
			return null;
		}

		public string SerializeLocalBlackboard()
		{
			return null;
		}

		public bool DeserializeLocalBlackboard(string json)
		{
			return false;
		}

		public void CopySerialized(Graph target)
		{
		}

		public void Validate()
		{
		}

		protected virtual void OnGraphValidate()
		{
		}

		public static List<Node> CopyNodesToGraph(List<Node> nodes, Graph targetGraph)
		{
			return null;
		}

		public void UpdateReferences()
		{
		}

		private void UpdateNodeBBFields()
		{
		}

		public void SendTaskOwnerDefaults()
		{
		}

		public void UpdateNodeIDs(bool alsoReorderList)
		{
		}

		public void StartGraph(Component agent, IBlackboard blackboard, bool autoUpdate, Action<bool> callback = null)
		{
		}

		public void StartGraph2(int startNodeID, Component agent, IBlackboard blackboard, bool autoUpdate, Action<bool> callback = null)
		{
		}

		public void Stop(bool success = true)
		{
		}

		public void Pause()
		{
		}

		public void Unpause()
		{
		}

		public void UpdateGraph()
		{
		}

		protected virtual void OnGraphStarted()
		{
		}

		protected virtual void OnGraphUpdate()
		{
		}

		protected virtual void OnGraphStoped()
		{
		}

		protected virtual void OnGraphPaused()
		{
		}

		protected virtual void OnGraphUnpaused()
		{
		}

		protected virtual void OnShowCustomGUI(UnityEngine.Object contextParent)
		{
		}

		public void SendEvent(string name)
		{
		}

		public void SendEvent<T>(string name, T value)
		{
		}

		public void SendEvent(EventData eventData)
		{
		}

		public static void SendGlobalEvent(string name)
		{
		}

		public static void SendGlobalEvent<T>(string name, T value)
		{
		}

		public static void SendGlobalEvent(EventData eventData)
		{
		}

		public Node GetNodeWithID(int searchID)
		{
			return null;
		}

		public List<T> GetAllNodesOfType<T>() where T : Node
		{
			return null;
		}

		public T GetNodeWithTag<T>(string tagName) where T : Node
		{
			return null;
		}

		public List<T> GetNodesWithTag<T>(string tagName) where T : Node
		{
			return null;
		}

		public List<T> GetAllTagedNodes<T>() where T : Node
		{
			return null;
		}

		public T GetNodeWithName<T>(string name) where T : Node
		{
			return null;
		}

		private string StripNameColor(string name)
		{
			return null;
		}

		public List<Node> GetRootNodes()
		{
			return null;
		}

		public List<T> GetAllNestedGraphs<T>(bool recursive) where T : Graph
		{
			return null;
		}

		public List<Graph> GetAllInstancedNestedGraphs()
		{
			return null;
		}

		public List<T> GetAllTasksOfType<T>() where T : Task
		{
			return null;
		}

		public Node GetParentNodeOfTask(Task task)
		{
			return null;
		}

		public BBParameter[] GetDefinedParameters()
		{
			return null;
		}

		public void CreateDefinedParameterVariables(IBlackboard bb)
		{
		}

		public T AddNode<T>() where T : Node
		{
			return null;
		}

		public T AddNode<T>(Vector2 pos) where T : Node
		{
			return null;
		}

		public Node AddNode(Type nodeType)
		{
			return null;
		}

		public Node AddNode(Type nodeType, Vector2 pos)
		{
			return null;
		}

		public void RemoveNode(Node node, bool recordUndo = true)
		{
		}

		public Connection ConnectNodes(Node sourceNode, Node targetNode)
		{
			return null;
		}

		public Connection ConnectNodes(Node sourceNode, Node targetNode, int indexToInsert)
		{
			return null;
		}

		public void RemoveConnection(Connection connection, bool recordUndo = true)
		{
		}

		private void RecordUndo(string name)
		{
		}
	}
}
