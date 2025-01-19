using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class MethodReturnType : IConstantProvider, IMetadataTokenProvider, ICustomAttributeProvider, IMarshalInfoProvider
	{
		internal IMethodSignature method;

		internal ParameterDefinition parameter;

		private TypeReference return_type;

		public TypeReference ReturnType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ParameterDefinition Parameter
		{
			get
			{
				return null;
			}
		}

		public MetadataToken MetadataToken
		{
			get
			{
				return default(MetadataToken);
			}
		}

		public bool HasCustomAttributes
		{
			get
			{
				return false;
			}
		}

		public Collection<CustomAttribute> CustomAttributes
		{
			get
			{
				return null;
			}
		}

		public bool HasConstant
		{
			get
			{
				return false;
			}
		}

		public object Constant
		{
			get
			{
				return null;
			}
		}

		public bool HasMarshalInfo
		{
			get
			{
				return false;
			}
		}

		public MarshalInfo MarshalInfo
		{
			get
			{
				return null;
			}
		}

		public MethodReturnType(IMethodSignature method)
		{
		}
	}
}
