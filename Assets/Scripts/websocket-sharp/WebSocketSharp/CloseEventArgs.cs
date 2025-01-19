using System;

namespace WebSocketSharp
{
	public class CloseEventArgs : EventArgs
	{
		private bool _clean;

		private PayloadData _payloadData;

		public ushort Code
		{
			get
			{
				return 0;
			}
		}

		public string Reason
		{
			get
			{
				return null;
			}
		}

		internal bool WasClean
		{
			set
			{
			}
		}

		internal CloseEventArgs(PayloadData payloadData)
		{
		}
	}
}
