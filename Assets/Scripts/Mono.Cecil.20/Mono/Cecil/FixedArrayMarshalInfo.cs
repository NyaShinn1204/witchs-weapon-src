namespace Mono.Cecil
{
	public sealed class FixedArrayMarshalInfo : MarshalInfo
	{
		internal NativeType element_type;

		internal int size;

		public FixedArrayMarshalInfo()
			: base(default(NativeType))
		{
		}
	}
}
