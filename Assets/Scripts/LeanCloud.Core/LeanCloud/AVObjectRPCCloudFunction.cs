namespace LeanCloud
{
	public class AVObjectRPCCloudFunction : AVObjectRPCCloudFunction<AVObject>
	{
	}
	public class AVObjectRPCCloudFunction<R> : AVRPCCloudFunctionBase<object, R> where R : AVObject
	{
		public AVRPCDeserialize<R> AVObjectDeserializer()
		{
			return null;
		}
	}
}
