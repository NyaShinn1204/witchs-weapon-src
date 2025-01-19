namespace Mono.Cecil
{
	public sealed class ByReferenceType : TypeSpecification
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

		public ByReferenceType(TypeReference type)
			: base(null)
		{
		}
	}
}
