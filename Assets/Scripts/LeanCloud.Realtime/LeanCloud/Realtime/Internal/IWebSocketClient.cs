using System;
using System.Threading.Tasks;

namespace LeanCloud.Realtime.Internal
{
	public interface IWebSocketClient
	{
		bool IsOpen { get; }

		event Action<int, string, string> OnClosed;

		event Action<string> OnError;

		event Action<string> OnLog;

		event Action<string> OnMessage;

		event Action OnOpened;

		void Close();

		void Disconnect();

		void Open(string url, string protocol = null);

		void Send(string message);

		Task<bool> Connect(string url, string protocol = null);
	}
}
