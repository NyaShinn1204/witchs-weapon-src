using System;

namespace WebSocketSharp
{
	public class MessageEventArgs : EventArgs
	{
		private string _data;

		private bool _dataSet;

		private Opcode _opcode;

		private byte[] _rawData;

		public string Data
		{
			get
			{
				return null;
			}
		}

		internal MessageEventArgs(WebSocketFrame frame)
		{
		}

		internal MessageEventArgs(Opcode opcode, byte[] rawData)
		{
		}

		private void setData()
		{
		}
	}
}
