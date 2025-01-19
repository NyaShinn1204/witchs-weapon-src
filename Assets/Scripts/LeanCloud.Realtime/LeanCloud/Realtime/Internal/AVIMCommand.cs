using System.Collections.Generic;

namespace LeanCloud.Realtime.Internal
{
	public class AVIMCommand
	{
		protected readonly string cmd;

		protected readonly string op;

		protected string appId;

		protected string peerId;

		protected AVIMSignature signature;

		protected readonly IDictionary<string, object> arguments;

		protected readonly IDictionary<string, object> estimatedData;

		internal readonly object mutex;

		internal static readonly object Mutex;

		private static int lastCmdId;

		public int TimeoutInSeconds { get; set; }

		public bool IsValid
		{
			get
			{
				return false;
			}
		}

		internal static int NextCmdId
		{
			get
			{
				return 0;
			}
		}

		public AVIMCommand()
		{
		}

		protected AVIMCommand(string cmd = null, string op = null, string appId = null, string peerId = null, AVIMSignature signature = null, IDictionary<string, object> arguments = null)
		{
		}

		protected AVIMCommand(AVIMCommand source, string cmd = null, string op = null, string appId = null, string peerId = null, IDictionary<string, object> arguments = null, AVIMSignature signature = null)
		{
		}

		public AVIMCommand Command(string cmd)
		{
			return null;
		}

		public AVIMCommand Option(string op)
		{
			return null;
		}

		public AVIMCommand Argument(string key, object value)
		{
			return null;
		}

		public AVIMCommand AppId(string appId)
		{
			return null;
		}

		public AVIMCommand PeerId(string peerId)
		{
			return null;
		}

		public AVIMCommand IDlize()
		{
			return null;
		}

		public virtual IDictionary<string, object> Encode()
		{
			return null;
		}

		public virtual string EncodeJsonString()
		{
			return null;
		}
	}
}
