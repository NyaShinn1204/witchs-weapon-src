using BestHTTP.SignalR.Hubs;
using BestHTTP.SignalR.Messages;

internal class TypedDemoHub : Hub
{
	private string typedEchoResult;

	private string typedEchoClientResult;

	public TypedDemoHub()
		: base(null)
	{
	}

	private void Echo(Hub hub, MethodCallMessage methodCall)
	{
	}

	public void Echo(string msg)
	{
	}

	private void OnEcho_Done(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	public void Draw()
	{
	}
}
