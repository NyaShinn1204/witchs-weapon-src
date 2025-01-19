namespace BestHTTP.SignalRCore.Messages
{
	public class Message
	{
		public MessageTypes type;

		public string invocationId;

		public bool nonblocking;

		public string target;

		public object[] arguments;

		public object item;

		public object result;

		public string error;

		public override string ToString()
		{
			return null;
		}
	}
}
