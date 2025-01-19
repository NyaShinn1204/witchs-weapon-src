namespace LeanCloud.Realtime.Internal
{
	internal interface IAVIMPlatformHooks
	{
		IWebSocketClient WebSocketClient { get; }

		string ua { get; }
	}
}
