using System;

namespace WebSocketSharp
{
	public class ErrorEventArgs : EventArgs
	{
		private Exception _exception;

		private string _message;

		public string Message
		{
			get
			{
				return null;
			}
		}

		internal ErrorEventArgs(string message, Exception exception)
		{
		}
	}
}
