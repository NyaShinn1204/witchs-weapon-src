using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Pathfinding
{
	public abstract class Path
	{
		public PathHandler pathHandler;

		public OnPathDelegate callback;

		private PathState state;

		private object stateLock;

		private PathCompleteState pathCompleteState;

		private string _errorLog;

		private GraphNode[] _path;

		private Vector3[] _vectorPath;

		public List<GraphNode> path;

		public List<Vector3> vectorPath;

		protected float maxFrameTime;

		protected PathNode currentR;

		public float duration;

		public int searchIterations;

		public int searchedNodes;

		public DateTime callTime;

		public bool recycled;

		protected bool hasBeenReset;

		public NNConstraint nnConstraint;

		public Path next;

		public int radius;

		public int walkabilityMask;

		public int height;

		public int turnRadius;

		public int speed;

		public Heuristic heuristic;

		public float heuristicScale;

		public ushort pathID;

		protected Int3 hTarget;

		public int enabledTags;

		protected int[] _tagPenalties;

		private List<object> claimed;

		private bool releasedNotSilent;

		public PathCompleteState CompleteState
		{
			get
			{
				return default(PathCompleteState);
			}
			protected set
			{
			}
		}

		public bool error
		{
			get
			{
				return false;
			}
		}

		public string errorLog
		{
			get
			{
				return null;
			}
		}

		public int[] tagPenalties
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float GetTotalLength()
		{
			return 0f;
		}

		[DebuggerHidden]
		public IEnumerator WaitForPath()
		{
			return null;
		}

		public uint CalculateHScore(GraphNode node)
		{
			return 0u;
		}

		public uint GetTagPenalty(int tag)
		{
			return 0u;
		}

		public Int3 GetHTarget()
		{
			return default(Int3);
		}

		public bool CanTraverse(GraphNode node)
		{
			return false;
		}

		public uint GetTraversalCost(GraphNode node)
		{
			return 0u;
		}

		public virtual uint GetConnectionSpecialCost(GraphNode a, GraphNode b, uint currentCost)
		{
			return 0u;
		}

		public bool IsDone()
		{
			return false;
		}

		public void AdvanceState(PathState s)
		{
		}

		public PathState GetState()
		{
			return default(PathState);
		}

		public void LogError(string msg)
		{
		}

		public void ForceLogError(string msg)
		{
		}

		public void Log(string msg)
		{
		}

		public void Error()
		{
		}

		private void ErrorCheck()
		{
		}

		public virtual void OnEnterPool()
		{
		}

		public virtual void Reset()
		{
		}

		protected bool HasExceededTime(int searchedNodes, long targetTime)
		{
			return false;
		}

		protected abstract void Recycle();

		public void Claim(object o)
		{
		}

		public void ReleaseSilent(object o)
		{
		}

		public void Release(object o)
		{
		}

		protected virtual void Trace(PathNode from)
		{
		}

		public virtual string DebugString(PathLog logMode)
		{
			return null;
		}

		public virtual void ReturnPath()
		{
		}

		public void PrepareBase(PathHandler pathHandler)
		{
		}

		public abstract void Prepare();

		public virtual void Cleanup()
		{
		}

		public abstract void Initialize();

		public abstract void CalculateStep(long targetTick);
	}
}
