using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class FunctionPointerType : TypeSpecification, IMethodSignature, IMetadataTokenProvider
	{
		private readonly MethodReference function;

		public bool HasThis
		{
			set
			{
			}
		}

		public bool ExplicitThis
		{
			set
			{
			}
		}

		public MethodCallingConvention CallingConvention
		{
			set
			{
			}
		}

		public bool HasParameters
		{
			get
			{
				return false;
			}
		}

		public Collection<ParameterDefinition> Parameters
		{
			get
			{
				return null;
			}
		}

		public TypeReference ReturnType
		{
			get
			{
				return null;
			}
		}

		public MethodReturnType MethodReturnType
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

		public override ModuleDefinition Module
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

		public FunctionPointerType()
			: base(null)
		{
		}

		public override TypeDefinition Resolve()
		{
			return null;
		}

		public override TypeReference GetElementType()
		{
			return null;
		}
	}
}
