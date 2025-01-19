using BestHTTP.Examples;
using BestHTTP.SignalR.Hubs;
using BestHTTP.SignalR.Messages;

internal class DemoHub : Hub
{
	private float longRunningJobProgress;

	private string longRunningJobStatus;

	private string fromArbitraryCodeResult;

	private string groupAddedResult;

	private string dynamicTaskResult;

	private string genericTaskResult;

	private string taskWithExceptionResult;

	private string genericTaskWithExceptionResult;

	private string synchronousExceptionResult;

	private string invokingHubMethodWithDynamicResult;

	private string simpleArrayResult;

	private string complexTypeResult;

	private string complexArrayResult;

	private string voidOverloadResult;

	private string intOverloadResult;

	private string readStateResult;

	private string plainTaskResult;

	private string genericTaskWithContinueWithResult;

	private GUIMessageList invokeResults;

	public DemoHub()
		: base(null)
	{
	}

	public void ReportProgress(string arg)
	{
	}

	public void OnLongRunningJob_Progress(Hub hub, ClientMessage originialMessage, ProgressMessage progress)
	{
	}

	public void OnLongRunningJob_Done(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	public void MultipleCalls()
	{
	}

	public void DynamicTask()
	{
	}

	private void OnDynamicTask_Failed(Hub hub, ClientMessage originalMessage, FailureMessage result)
	{
	}

	private void OnDynamicTask_Done(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	public void AddToGroups()
	{
	}

	public void GetValue()
	{
	}

	public void TaskWithException()
	{
	}

	public void GenericTaskWithException()
	{
	}

	public void SynchronousException()
	{
	}

	public void PassingDynamicComplex(object person)
	{
	}

	public void SimpleArray(int[] array)
	{
	}

	public void ComplexType(object person)
	{
	}

	public void ComplexArray(object[] complexArray)
	{
	}

	public void Overload()
	{
	}

	private void OnVoidOverload_Done(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	public void Overload(int number)
	{
	}

	private void OnIntOverload_Done(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	public void ReadStateValue()
	{
	}

	public void PlainTask()
	{
	}

	public void GenericTaskWithContinueWith()
	{
	}

	private void FromArbitraryCode(Hub hub, MethodCallMessage methodCall)
	{
	}

	private void GroupAdded(Hub hub, MethodCallMessage methodCall)
	{
	}

	private void Signal(Hub hub, MethodCallMessage methodCall)
	{
	}

	private void Invoke(Hub hub, MethodCallMessage methodCall)
	{
	}

	public void Draw()
	{
	}
}
