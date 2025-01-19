namespace Mono.Cecil
{
	public sealed class RequiredModifierType : TypeSpecification, IModifierType
	{
		private TypeReference modifier_type;

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

		private string Suffix
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

		internal override bool ContainsGenericParameter
		{
			get
			{
				return false;
			}
		}

		public RequiredModifierType(TypeReference modifierType, TypeReference type)
			: base(null)
		{
		}
	}
}
