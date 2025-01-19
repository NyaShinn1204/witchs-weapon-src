using BestHTTP.Examples;
using BestHTTP.SignalR.Hubs;
using BestHTTP.SignalR.Messages;

internal class BaseHub : Hub
{
	private string Title;

	private GUIMessageList messages;

	public BaseHub(string name, string title)
		: base(null)
	{
	}

	private void Joined(Hub hub, MethodCallMessage methodCall)
	{
	}

	private void Rejoined(Hub hub, MethodCallMessage methodCall)
	{
	}

	private void Left(Hub hub, MethodCallMessage methodCall)
	{
	}

	private void Invoked(Hub hub, MethodCallMessage methodCall)
	{
	}

	public void InvokedFromClient()
	{
	}

	private void OnInvoked(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	private void OnInvokeFailed(Hub hub, ClientMessage originalMessage, FailureMessage result)
	{
	}

	public void Draw()
	{
	}
}
