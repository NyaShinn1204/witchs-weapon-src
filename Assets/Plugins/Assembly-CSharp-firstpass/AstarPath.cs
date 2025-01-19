using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Pathfinding;
using Pathfinding.Util;
using UnityEngine;

public class AstarPath : MonoBehaviour
{
	public enum AstarDistribution
	{
		WebsiteDownload = 0,
		AssetStore = 1
	}

	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct AstarWorkItem
	{
		public OnVoidDelegate init;

		public Func<bool, bool> update;

		public AstarWorkItem(Func<bool, bool> update)
		{
			init = null;
			this.update = null;
		}

		public AstarWorkItem(OnVoidDelegate init, Func<bool, bool> update)
		{
			this.init = null;
			this.update = null;
		}
	}

	private enum GraphUpdateOrder
	{
		GraphUpdate = 0,
		FloodFill = 1
	}

	private struct GUOSingle
	{
		public GraphUpdateOrder order;

		public IUpdatableGraph graph;

		public GraphUpdateObject obj;
	}

	public static readonly AstarDistribution Distribution;

	public static readonly string Branch;

	public static readonly bool HasPro;

	public AstarData astarData;

	public static AstarPath active;

	public bool showNavGraphs;

	public bool showUnwalkableNodes;

	public GraphDebugMode debugMode;

	public float debugFloor;

	public float debugRoof;

	public bool showSearchTree;

	public float unwalkableNodeDebugSize;

	public PathLog logPathResults;

	public float maxNearestNodeDistance;

	public bool scanOnStartup;

	public bool fullGetNearestSearch;

	public bool prioritizeGraphs;

	public float prioritizeGraphsLimit;

	public AstarColor colorSettings;

	[SerializeField]
	protected string[] tagNames;

	public Heuristic heuristic;

	public float heuristicScale;

	public ThreadCount threadCount;

	public float maxFrameTime;

	public int minAreaSize;

	public bool limitGraphUpdates;

	public float maxGraphUpdateFreq;

	public static int PathsCompleted;

	public static long TotalSearchedNodes;

	public static long TotalSearchTime;

	public float lastScanTime;

	public Path debugPath;

	public string inGameDebugPath;

	public bool isScanning;

	private bool graphUpdateRoutineRunning;

	private bool isRegisteredForUpdate;

	public static OnVoidDelegate OnAwakeSettings;

	public static OnGraphDelegate OnGraphPreScan;

	public static OnGraphDelegate OnGraphPostScan;

	public static OnPathDelegate OnPathPreSearch;

	public static OnPathDelegate OnPathPostSearch;

	public static OnScanDelegate OnPreScan;

	public static OnScanDelegate OnPostScan;

	public static OnScanDelegate OnLatePostScan;

	public static OnScanDelegate OnGraphsUpdated;

	public static OnVoidDelegate On65KOverflow;

	private static OnVoidDelegate OnSafeCallback;

	private static OnVoidDelegate OnThreadSafeCallback;

	public OnVoidDelegate OnDrawGizmosCallback;

	[Obsolete]
	public OnVoidDelegate OnGraphsWillBeUpdated;

	[Obsolete]
	public OnVoidDelegate OnGraphsWillBeUpdated2;

	[NonSerialized]
	public Queue<GraphUpdateObject> graphUpdateQueue;

	[NonSerialized]
	public Stack<GraphNode> floodStack;

	private ThreadControlQueue pathQueue;

	private static Thread[] threads;

	private static PathThreadInfo[] threadInfos;

	private static IEnumerator threadEnumerator;

	private static LockFreeStack pathReturnStack;

	public bool showGraphs;

	public static bool isEditor;

	public uint lastUniqueAreaIndex;

	private static readonly object safeUpdateLock;

	private float lastGraphUpdate;

	private ushort nextFreePathID;

	private Queue<AstarWorkItem> workItems;

	private bool workItemsQueued;

	private bool queuedWorkItemFloodFill;

	private bool processingWorkItems;

	private AutoResetEvent graphUpdateAsyncEvent;

	private ManualResetEvent processingGraphUpdatesAsync;

	private Queue<GUOSingle> graphUpdateQueueAsync;

	private Queue<GUOSingle> graphUpdateQueueRegular;

	private int nextNodeIndex;

	private Stack<int> nodeIndexPool;

	private static int waitForPathDepth;

	private Path pathReturnPop;

	public static Version Version
	{
		get
		{
			return null;
		}
	}

	public Type[] graphTypes
	{
		get
		{
			return null;
		}
	}

	public NavGraph[] graphs
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float maxNearestNodeDistanceSqr
	{
		get
		{
			return 0f;
		}
	}

	public PathHandler debugPathData
	{
		get
		{
			return null;
		}
	}

	public static int NumParallelThreads
	{
		get
		{
			return 0;
		}
	}

	public static bool IsUsingMultithreading
	{
		get
		{
			return false;
		}
	}

	public bool IsAnyGraphUpdatesQueued
	{
		get
		{
			return false;
		}
	}

	public string[] GetTagNames()
	{
		return null;
	}

	public static string[] FindTagNames()
	{
		return null;
	}

	public ushort GetNextPathID()
	{
		return 0;
	}

	private void OnDrawGizmos()
	{
	}

	private bool DrawUnwalkableNode(GraphNode node)
	{
		return false;
	}

	private void OnGUI()
	{
	}

	private static void AstarLog(string s)
	{
	}

	private static void AstarLogError(string s)
	{
	}

	private void LogPathResults(Path p)
	{
	}

	private void Update()
	{
	}

	private void PerformBlockingActions(bool force = false, bool unblockOnComplete = true)
	{
	}

	public void QueueWorkItemFloodFill()
	{
	}

	public void EnsureValidFloodFill()
	{
	}

	public void AddWorkItem(AstarWorkItem itm)
	{
	}

	private int ProcessWorkItems(bool force)
	{
		return 0;
	}

	public void QueueGraphUpdates()
	{
	}

	[DebuggerHidden]
	private IEnumerator DelayedGraphUpdate()
	{
		return null;
	}

	public void UpdateGraphs(Bounds bounds, float t)
	{
	}

	public void UpdateGraphs(GraphUpdateObject ob, float t)
	{
	}

	[DebuggerHidden]
	private IEnumerator UpdateGraphsInteral(GraphUpdateObject ob, float t)
	{
		return null;
	}

	public void UpdateGraphs(Bounds bounds)
	{
	}

	public void UpdateGraphs(GraphUpdateObject ob)
	{
	}

	public void FlushGraphUpdates()
	{
	}

	public void FlushWorkItems()
	{
	}

	private void QueueGraphUpdatesInternal()
	{
	}

	private bool ProcessGraphUpdates(bool force)
	{
		return false;
	}

	private void ProcessGraphUpdatesAsync(object _astar)
	{
	}

	public void FlushThreadSafeCallbacks()
	{
	}

	public void LogProfiler()
	{
	}

	public void ResetProfiler()
	{
	}

	public static int CalculateThreadCount(ThreadCount count)
	{
		return 0;
	}

	public void Awake()
	{
	}

	public void VerifyIntegrity()
	{
	}

	public void SetUpReferences()
	{
	}

	private void Initialize()
	{
	}

	public void OnDestroy()
	{
	}

	public void FloodFill(GraphNode seed)
	{
	}

	public void FloodFill(GraphNode seed, uint area)
	{
	}

	public void FloodFill()
	{
	}

	public int GetNewNodeIndex()
	{
		return 0;
	}

	public void InitializeNode(GraphNode node)
	{
	}

	public void DestroyNode(GraphNode node)
	{
	}

	public void BlockUntilPathQueueBlocked()
	{
	}

	public void Scan()
	{
	}

	public void ScanLoop(OnScanStatus statusCallback)
	{
	}

	public void ApplyLinks()
	{
	}

	public static void WaitForPath(Path p)
	{
	}

	public static void RegisterSafeUpdate(OnVoidDelegate callback, bool threadSafe)
	{
	}

	private static void InterruptPathfinding()
	{
	}

	public static void StartPath(Path p, bool pushToFront = false)
	{
	}

	public void OnApplicationQuit()
	{
	}

	public void ReturnPaths(bool timeSlice)
	{
	}

	private static void CalculatePathsThreaded(object _threadInfo)
	{
	}

	[DebuggerHidden]
	private static IEnumerator CalculatePaths(object _threadInfo)
	{
		return null;
	}

	public NNInfo GetNearest(Vector3 position)
	{
		return default(NNInfo);
	}

	public NNInfo GetNearest(Vector3 position, NNConstraint constraint)
	{
		return default(NNInfo);
	}

	public NNInfo GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint)
	{
		return default(NNInfo);
	}

	public GraphNode GetNearest(Ray ray)
	{
		return null;
	}
}
