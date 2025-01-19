using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Pathfinding;
using UnityEngine;

public class Seeker : MonoBehaviour
{
	public enum ModifierPass
	{
		PreProcess = 0,
		PostProcessOriginal = 1,
		PostProcess = 2
	}

	public bool drawGizmos;

	public bool detailedGizmos;

	[HideInInspector]
	public bool saveGetNearestHints;

	public StartEndModifier startEndModifier;

	[HideInInspector]
	public TagMask traversableTags;

	[HideInInspector]
	public int[] tagPenalties;

	public OnPathDelegate pathCallback;

	public OnPathDelegate preProcessPath;

	public OnPathDelegate postProcessOriginalPath;

	public OnPathDelegate postProcessPath;

	[NonSerialized]
	public List<Vector3> lastCompletedVectorPath;

	[NonSerialized]
	public List<GraphNode> lastCompletedNodePath;

	[NonSerialized]
	protected Path path;

	private Path prevPath;

	private GraphNode startHint;

	private GraphNode endHint;

	private OnPathDelegate onPathDelegate;

	private OnPathDelegate onPartialPathDelegate;

	private OnPathDelegate tmpPathCallback;

	protected uint lastPathID;

	private List<IPathModifier> modifiers;

	public Path GetCurrentPath()
	{
		return null;
	}

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public void ReleaseClaimedPath()
	{
	}

	public void RegisterModifier(IPathModifier mod)
	{
	}

	public void DeregisterModifier(IPathModifier mod)
	{
	}

	public void PostProcess(Path p)
	{
	}

	public void RunModifiers(ModifierPass pass, Path p)
	{
	}

	public bool IsDone()
	{
		return false;
	}

	public void OnPathComplete(Path p)
	{
	}

	public void OnPathComplete(Path p, bool runModifiers, bool sendCallbacks)
	{
	}

	public void OnPartialPathComplete(Path p)
	{
	}

	public void OnMultiPathComplete(Path p)
	{
	}

	public ABPath GetNewPath(Vector3 start, Vector3 end)
	{
		return null;
	}

	public Path StartPath(Vector3 start, Vector3 end)
	{
		return null;
	}

	public Path StartPath(Vector3 start, Vector3 end, OnPathDelegate callback)
	{
		return null;
	}

	public Path StartPath(Vector3 start, Vector3 end, OnPathDelegate callback, int graphMask)
	{
		return null;
	}

	public Path StartPath(Path p, OnPathDelegate callback = null, int graphMask = -1)
	{
		return null;
	}

	public MultiTargetPath StartMultiTargetPath(Vector3 start, Vector3[] endPoints, bool pathsForAll, OnPathDelegate callback = null, int graphMask = -1)
	{
		return null;
	}

	public MultiTargetPath StartMultiTargetPath(Vector3[] startPoints, Vector3 end, bool pathsForAll, OnPathDelegate callback = null, int graphMask = -1)
	{
		return null;
	}

	public MultiTargetPath StartMultiTargetPath(MultiTargetPath p, OnPathDelegate callback = null, int graphMask = -1)
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerator DelayPathStart(Path p)
	{
		return null;
	}

	public void OnDrawGizmos()
	{
	}
}
