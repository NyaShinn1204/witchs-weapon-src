namespace BestHTTP.SignalR.Messages
{
	public sealed class DataMessage : IServerMessage
	{
		MessageTypes IServerMessage.Type
		{
			get
			{
				return default(MessageTypes);
			}
		}

		public object Data { get; private set; }

		void IServerMessage.Parse(object data)
		{
		}
	}
}
