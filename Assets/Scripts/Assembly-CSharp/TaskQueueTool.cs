using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TaskQueueTool : MonoBehaviour
{
	private static readonly bool isDestroyOnLoad;

	private static TaskQueueTool current;

	private static int frameRateMin;

	private static float safeTimePerFrame;

	private static List<TaskQueueData> s_AsyncCompleteList;

	private bool isInit;

	private List<TaskQueueGroupData> groupList;

	private TaskQueueGroupData defaultGroup;

	private Stopwatch stopWatch;

	public int FrameRateMin
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void Init()
	{
	}

	public static TaskQueueTool GetInstance()
	{
		return null;
	}

	public void Run(TaskQueueData data)
	{
	}

	public void RunGroup(TaskQueueGroupData group)
	{
	}

	public void RunAsync(TaskQueueData data)
	{
	}
}
