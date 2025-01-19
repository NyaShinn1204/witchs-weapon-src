using System;
using System.Collections.Generic;

public class TaskQueueGroupData
{
	public List<TaskQueueData> asyncItemList;

	public Action<TaskQueueGroupData> onGroupComplete;

	public object[] args;

	public int priority;

	public TaskQueueGroupData(List<TaskQueueData> asyncItemList, Action<TaskQueueGroupData> onGroupComplete = null, int priority = 0, params object[] args)
	{
	}
}
