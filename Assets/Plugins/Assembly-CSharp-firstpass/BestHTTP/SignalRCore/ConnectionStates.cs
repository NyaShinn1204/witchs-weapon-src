namespace BestHTTP.SignalRCore
{
	public enum ConnectionStates
	{
		Initial = 0,
		Authenticating = 1,
		Negotiating = 2,
		Connected = 3,
		CloseInitiated = 4,
		Closed = 5
	}
}
