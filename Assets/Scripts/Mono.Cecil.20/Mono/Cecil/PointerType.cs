namespace Mono.Cecil
{
	public sealed class PointerType : TypeSpecification
	{
		public override string Name
		{
			get
			{
				return null;
			}
		}

		public override string FullName
		{
			get
			{
				return null;
			}
		}

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

		public PointerType(TypeReference type)
			: base(null)
		{
		}
	}
}
