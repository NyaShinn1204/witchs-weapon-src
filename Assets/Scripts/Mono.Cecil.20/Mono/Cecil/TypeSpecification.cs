namespace Mono.Cecil
{
	public abstract class TypeSpecification : TypeReference
	{
		private readonly TypeReference element_type;

		public TypeReference ElementType
		{
			get
			{
				return null;
			}
		}

		public override string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string Namespace
		{
			get
			{
				return null;
			}
		}

		public override IMetadataScope Scope
		{
			get
			{
				return null;
			}
		}

		public override ModuleDefinition Module
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

		internal override bool ContainsGenericParameter
		{
			get
			{
				return false;
			}
		}

		internal TypeSpecification(TypeReference type)
			: base(null, null)
		{
		}

		public override TypeReference GetElementType()
		{
			return null;
		}
	}
}
