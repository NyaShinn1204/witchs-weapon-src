using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class GenericInstanceType : TypeSpecification, IGenericInstance, IMetadataTokenProvider, IGenericContext
	{
		private Collection<TypeReference> arguments;

		public Collection<TypeReference> GenericArguments
		{
			get
			{
				return null;
			}
		}

		public override TypeReference DeclaringType
		{
			get
			{
				return null;
			}
			set
			{
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

		IGenericParameterProvider IGenericContext.Type
		{
			get
			{
				return null;
			}
		}

		public GenericInstanceType(TypeReference type)
			: base(null)
		{
		}
	}
}
