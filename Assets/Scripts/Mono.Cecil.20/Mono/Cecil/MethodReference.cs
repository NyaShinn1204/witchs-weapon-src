using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public class MethodReference : MemberReference, IMethodSignature, IMetadataTokenProvider, IGenericParameterProvider, IGenericContext
	{
		internal ParameterDefinitionCollection parameters;

		private MethodReturnType return_type;

		private bool has_this;

		private bool explicit_this;

		private MethodCallingConvention calling_convention;

		internal Collection<GenericParameter> generic_parameters;

		public virtual bool HasThis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual bool ExplicitThis
		{
			set
			{
			}
		}

		public virtual MethodCallingConvention CallingConvention
		{
			set
			{
			}
		}

		public virtual bool HasParameters
		{
			get
			{
				return false;
			}
		}

		public virtual Collection<ParameterDefinition> Parameters
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

		IGenericParameterProvider IGenericContext.Method
		{
			get
			{
				return null;
			}
		}

		GenericParameterType IGenericParameterProvider.GenericParameterType
		{
			get
			{
				return default(GenericParameterType);
			}
		}

		public virtual bool HasGenericParameters
		{
			get
			{
				return false;
			}
		}

		public virtual Collection<GenericParameter> GenericParameters
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

		public virtual MethodReturnType MethodReturnType
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

		public virtual bool IsGenericInstance
		{
			get
			{
				return false;
			}
		}

		internal override bool ContainsGenericParameter
		{
			get
			{
				return false;
			}
		}

		internal MethodReference()
		{
		}
	}
}
