using System;
using System.Collections.Generic;
using BestHTTP.Futures;
using BestHTTP.SignalRCore.Messages;

namespace BestHTTP.SignalRCore
{
	public sealed class HubConnection
	{
		public static readonly object[] EmptyArgs;

		private long lastInvocationId;

		private Dictionary<long, Action<Message>> invocations;

		private Dictionary<string, Subscription> subscriptions;

		public Uri Uri { get; private set; }

		public ConnectionStates State { get; private set; }

		public TransportTypes PreferedTransport { get; private set; }

		public ITransport Transport { get; private set; }

		public IProtocol Protocol { get; private set; }

		public IAuthenticationProvider AuthenticationProvider { get; set; }

		public NegotiationResult NegotiationResult { get; private set; }

		public event Action<HubConnection> OnConnected
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<HubConnection, string> OnError
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<HubConnection> OnClosed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Func<HubConnection, Message, bool> OnMessage
		{
			add
			{
			}
			remove
			{
			}
		}

		public HubConnection(Uri hubUri, IProtocol protocol)
		{
		}

		public HubConnection(Uri hubUri, IProtocol protocol, TransportTypes preferedTransport)
		{
		}

		public void StartConnect()
		{
		}

		private void OnAuthenticationSucceded(IAuthenticationProvider provider)
		{
		}

		private void OnAuthenticationFailed(IAuthenticationProvider provider, string reason)
		{
		}

		private void StartNegotiation()
		{
		}

		private void ConnectImpl()
		{
		}

		private bool IsTransportSupported(string transportName)
		{
			return false;
		}

		private void OnNegotiationRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		public void StartClose()
		{
		}

		public IFuture<StreamItemContainer<TResult>> Stream<TResult>(string target, params object[] args)
		{
			return null;
		}

		public void CancelStream<T>(StreamItemContainer<T> container)
		{
		}

		public IFuture<TResult> Invoke<TResult>(string target, params object[] args)
		{
			return null;
		}

		public IFuture<bool> Send(string target, params object[] args)
		{
			return null;
		}

		private long InvokeImp(string target, object[] args, Action<Message> callback, bool isStreamingInvocation = false)
		{
			return 0L;
		}

		private void SendMessage(Message message)
		{
		}

		public void On(string methodName, Action callback)
		{
		}

		public void On<T1>(string methodName, Action<T1> callback)
		{
		}

		public void On<T1, T2>(string methodName, Action<T1, T2> callback)
		{
		}

		public void On<T1, T2, T3>(string methodName, Action<T1, T2, T3> callback)
		{
		}

		public void On<T1, T2, T3, T4>(string methodName, Action<T1, T2, T3, T4> callback)
		{
		}

		public void On(string methodName, Type[] paramTypes, Action<object[]> callback)
		{
		}

		internal void OnMessages(List<Message> messages)
		{
		}

		private void Transport_OnStateChanged(TransportStates oldState, TransportStates newState)
		{
		}

		private void SetState(ConnectionStates state, string errorReason = null)
		{
		}
	}
}
