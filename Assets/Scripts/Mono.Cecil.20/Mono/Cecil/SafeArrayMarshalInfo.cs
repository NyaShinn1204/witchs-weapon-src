namespace Mono.Cecil
{
	public sealed class SafeArrayMarshalInfo : MarshalInfo
	{
		internal VariantType element_type;

		public SafeArrayMarshalInfo()
			: base(default(NativeType))
		{
		}
	}
}
