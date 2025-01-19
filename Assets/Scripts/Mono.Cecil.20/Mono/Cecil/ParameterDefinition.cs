using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class ParameterDefinition : ParameterReference, ICustomAttributeProvider, IMetadataTokenProvider, IConstantProvider, IMarshalInfoProvider
	{
		private ushort attributes;

		internal IMethodSignature method;

		private object constant;

		private Collection<CustomAttribute> custom_attributes;

		private MarshalInfo marshal_info;

		public ParameterAttributes Attributes
		{
			set
			{
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

		internal ParameterDefinition(TypeReference parameterType, IMethodSignature method)
			: base(null, null)
		{
		}

		public ParameterDefinition(TypeReference parameterType)
			: base(null, null)
		{
		}

		public ParameterDefinition(string name, ParameterAttributes attributes, TypeReference parameterType)
			: base(null, null)
		{
		}
	}
}
