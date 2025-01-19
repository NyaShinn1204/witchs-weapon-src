using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeanCloud
{
	public class AVRPCCloudFunctionBase<P, R>
	{
		public delegate R AVRPCDeserialize<R>(IDictionary<string, object> result);

		public delegate IDictionary<string, object> AVRPCSerialize<P>(P parameters);

		private AVRPCDeserialize<R> _decode;

		private AVRPCSerialize<P> _encode;

		public AVRPCDeserialize<R> Decode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AVRPCSerialize<P> Encode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FunctionName { get; set; }

		public AVRPCCloudFunctionBase()
		{
		}

		public AVRPCCloudFunctionBase(bool noneParameters)
		{
		}

		public Task<R> ExecuteAsync(P parameters)
		{
			return null;
		}
	}
}
