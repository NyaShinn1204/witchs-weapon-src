using System;

public class TaskQueueData
{
	public Action<TaskQueueData> runAction;

	public Action<TaskQueueData> onComplete;

	public double elapsedMilliseconds;

	public object[] args;

	public int priority;

	public TaskQueueData(Action<TaskQueueData> runAction, Action<TaskQueueData> onComplete = null, int priority = 0, params object[] args)
	{
	}
}
