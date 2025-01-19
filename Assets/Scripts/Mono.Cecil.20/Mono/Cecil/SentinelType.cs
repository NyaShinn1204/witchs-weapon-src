namespace Mono.Cecil
{
	public sealed class SentinelType : TypeSpecification
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

		public override bool IsSentinel
		{
			get
			{
				return false;
			}
		}

		public SentinelType(TypeReference type)
			: base(null)
		{
		}
	}
}
