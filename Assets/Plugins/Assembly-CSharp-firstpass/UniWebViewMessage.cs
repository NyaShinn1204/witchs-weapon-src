using System.Collections.Generic;

public struct UniWebViewMessage
{
	public string RawMessage { get; private set; }

	public string Scheme { get; private set; }

	public string Path { get; private set; }

	public Dictionary<string, string> Args { get; private set; }

	public UniWebViewMessage(string rawMessage)
	{
		RawMessage = null;
		Scheme = null;
		Path = null;
		Args = null;
	}
}
