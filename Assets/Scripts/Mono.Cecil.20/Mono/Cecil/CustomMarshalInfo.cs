using System;

namespace Mono.Cecil
{
	public sealed class CustomMarshalInfo : MarshalInfo
	{
		internal Guid guid;

		internal string unmanaged_type;

		internal TypeReference managed_type;

		internal string cookie;

		public CustomMarshalInfo()
			: base(default(NativeType))
		{
		}
	}
}
