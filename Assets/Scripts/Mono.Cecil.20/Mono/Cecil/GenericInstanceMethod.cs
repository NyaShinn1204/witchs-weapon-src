using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class GenericInstanceMethod : MethodSpecification, IGenericInstance, IMetadataTokenProvider, IGenericContext
	{
		private Collection<TypeReference> arguments;

		public Collection<TypeReference> GenericArguments
		{
			get
			{
				return null;
			}
		}

		public override bool IsGenericInstance
		{
			get
			{
				return false;
			}
		}

		IGenericParameterProvider IGenericContext.Method
		{
			get
			{
				return null;
			}
		}

		IGenericParameterProvider IGenericContext.Type
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

		public override string FullName
		{
			get
			{
				return null;
			}
		}

		public GenericInstanceMethod(MethodReference method)
			: base(null)
		{
		}
	}
}
