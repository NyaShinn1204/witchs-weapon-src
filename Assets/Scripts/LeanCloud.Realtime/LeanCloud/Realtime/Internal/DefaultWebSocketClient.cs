using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WebSocketSharp;

namespace LeanCloud.Realtime.Internal
{
	public class DefaultWebSocketClient : IWebSocketClient
	{
		private WebSocket ws;

		private Action<string> m_OnMessage;

		private int onMesssageCount;

		public bool IsOpen
		{
			get
			{
				return false;
			}
		}

		public event Action<int, string, string> OnClosed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<string> OnError
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<string> OnLog
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<string> OnMessage
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action OnOpened
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Close()
		{
		}

		public void Disconnect()
		{
		}

		public void Open(string url, string protocol = null)
		{
		}

		private void OnWebSokectMessage(object sender, MessageEventArgs e)
		{
		}

		private void OnClose(object sender, CloseEventArgs e)
		{
		}

		private void OnWebSocketError(object sender, ErrorEventArgs e)
		{
		}

		private void OnOpen(object sender, EventArgs e)
		{
		}

		public void Send(string message)
		{
		}

		public Task<bool> Connect(string url, string protocol = null)
		{
			return null;
		}
	}
}
