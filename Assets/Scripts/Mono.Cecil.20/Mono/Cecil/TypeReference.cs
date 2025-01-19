using Mono.Cecil.Metadata;
using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public class TypeReference : MemberReference, IGenericParameterProvider, IMetadataTokenProvider, IGenericContext
	{
		private string @namespace;

		private bool value_type;

		internal IMetadataScope scope;

		internal ModuleDefinition module;

		internal ElementType etype;

		private string fullname;

		protected Collection<GenericParameter> generic_parameters;

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

		public virtual string Namespace
		{
			get
			{
				return null;
			}
		}

		public virtual bool IsValueType
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override ModuleDefinition Module
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

		public virtual IMetadataScope Scope
		{
			get
			{
				return null;
			}
		}

		public bool IsNested
		{
			get
			{
				return false;
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

		public virtual bool IsSentinel
		{
			get
			{
				return false;
			}
		}

		public virtual bool IsArray
		{
			get
			{
				return false;
			}
		}

		public virtual bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		public virtual bool IsPrimitive
		{
			get
			{
				return false;
			}
		}

		protected TypeReference(string @namespace, string name)
		{
		}

		public TypeReference(string @namespace, string name, ModuleDefinition module, IMetadataScope scope)
		{
		}

		public virtual TypeReference GetElementType()
		{
			return null;
		}

		public virtual TypeDefinition Resolve()
		{
			return null;
		}
	}
}
