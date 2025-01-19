using System.Collections.Generic;

namespace LeanCloud
{
	public class AVObjectListRPCCloudFunction : AVObjectListRPCCloudFunction<AVObject>
	{
	}
	public class AVObjectListRPCCloudFunction<R> : AVRPCCloudFunctionBase<object, IList<R>> where R : AVObject
	{
		public AVRPCDeserialize<IList<R>> AVObjectListDeserializer()
		{
			return null;
		}
	}
}
