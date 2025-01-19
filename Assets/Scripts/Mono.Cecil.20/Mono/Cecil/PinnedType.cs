namespace Mono.Cecil
{
	public sealed class PinnedType : TypeSpecification
	{
		public override bool IsValueType
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PinnedType(TypeReference type)
			: base(null)
		{
		}
	}
}
