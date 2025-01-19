namespace Mono.Cecil
{
	public sealed class ArrayMarshalInfo : MarshalInfo
	{
		internal NativeType element_type;

		internal int size_parameter_index;

		internal int size;

		internal int size_parameter_multiplier;

		public ArrayMarshalInfo()
			: base(default(NativeType))
		{
		}
	}
}
