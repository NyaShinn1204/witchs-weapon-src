using System;
using System.IO;
using BestHTTP.PlatformSupport.TcpClient.General;

namespace BestHTTP
{
	internal sealed class HTTPConnection : ConnectionBase
	{
		private TcpClient Client;

		private Stream Stream;

		private KeepAliveHeader KeepAlive;

		public override bool IsRemovable
		{
			get
			{
				return false;
			}
		}

		internal HTTPConnection(string serverAddress)
			: base(null)
		{
		}

		protected override void ThreadFunc(object param)
		{
		}

		private void Connect()
		{
		}

		private bool Receive()
		{
			return false;
		}

		private bool LoadFromCache(Uri uri)
		{
			return false;
		}

		private bool TryLoadAllFromCache()
		{
			return false;
		}

		private void TryStoreInCache()
		{
		}

		private Uri GetRedirectUri(string location)
		{
			return null;
		}

		internal override void Abort(HTTPConnectionStates newState)
		{
		}

		private void Close()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
