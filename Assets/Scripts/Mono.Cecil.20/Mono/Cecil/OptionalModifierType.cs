namespace Mono.Cecil
{
	public sealed class OptionalModifierType : TypeSpecification, IModifierType
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

		public OptionalModifierType(TypeReference modifierType, TypeReference type)
			: base(null)
		{
		}
	}
}
