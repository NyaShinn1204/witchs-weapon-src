namespace Mono.Cecil
{
	public sealed class FixedSysStringMarshalInfo : MarshalInfo
	{
		internal int size;

		public FixedSysStringMarshalInfo()
			: base(default(NativeType))
		{
		}
	}
}
