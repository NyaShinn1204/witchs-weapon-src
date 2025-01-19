using Mono.Cecil.Metadata;
using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class GenericParameter : TypeReference, ICustomAttributeProvider, IMetadataTokenProvider
	{
		internal int position;

		internal GenericParameterType type;

		internal IGenericParameterProvider owner;

		private ushort attributes;

		private Collection<TypeReference> constraints;

		private Collection<CustomAttribute> custom_attributes;

		public GenericParameterAttributes Attributes
		{
			set
			{
			}
		}

		public IGenericParameterProvider Owner
		{
			get
			{
				return null;
			}
		}

		public bool HasConstraints
		{
			get
			{
				return false;
			}
		}

		public Collection<TypeReference> Constraints
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

		public override string Name
		{
			get
			{
				return null;
			}
		}

		public override string Namespace
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

		public override bool IsGenericParameter
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

		public GenericParameter(IGenericParameterProvider owner)
			: base(null, null)
		{
		}

		public GenericParameter(string name, IGenericParameterProvider owner)
			: base(null, null)
		{
		}

		public GenericParameter(int position, GenericParameterType type, ModuleDefinition module)
			: base(null, null)
		{
		}

		private static ElementType ConvertGenericParameterType(GenericParameterType type)
		{
			return default(ElementType);
		}

		public override TypeDefinition Resolve()
		{
			return null;
		}
	}
}
