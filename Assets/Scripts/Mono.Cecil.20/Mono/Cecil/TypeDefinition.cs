using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class TypeDefinition : TypeReference, IMemberDefinition, ICustomAttributeProvider, IMetadataTokenProvider, ISecurityDeclarationProvider
	{
		private uint attributes;

		private TypeReference base_type;

		internal Range fields_range;

		internal Range methods_range;

		private short packing_size;

		private int class_size;

		private Collection<TypeReference> interfaces;

		private Collection<TypeDefinition> nested_types;

		private Collection<MethodDefinition> methods;

		private Collection<FieldDefinition> fields;

		private Collection<EventDefinition> events;

		private Collection<PropertyDefinition> properties;

		private Collection<CustomAttribute> custom_attributes;

		private Collection<SecurityDeclaration> security_declarations;

		public TypeAttributes Attributes
		{
			get
			{
				return default(TypeAttributes);
			}
		}

		public TypeReference BaseType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool HasLayoutInfo
		{
			get
			{
				return false;
			}
		}

		public short PackingSize
		{
			set
			{
			}
		}

		public int ClassSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool HasInterfaces
		{
			get
			{
				return false;
			}
		}

		public Collection<TypeReference> Interfaces
		{
			get
			{
				return null;
			}
		}

		public bool HasNestedTypes
		{
			get
			{
				return false;
			}
		}

		public Collection<TypeDefinition> NestedTypes
		{
			get
			{
				return null;
			}
		}

		public bool HasMethods
		{
			get
			{
				return false;
			}
		}

		public Collection<MethodDefinition> Methods
		{
			get
			{
				return null;
			}
		}

		public bool HasFields
		{
			get
			{
				return false;
			}
		}

		public Collection<FieldDefinition> Fields
		{
			get
			{
				return null;
			}
		}

		public bool HasEvents
		{
			get
			{
				return false;
			}
		}

		public Collection<EventDefinition> Events
		{
			get
			{
				return null;
			}
		}

		public bool HasProperties
		{
			get
			{
				return false;
			}
		}

		public Collection<PropertyDefinition> Properties
		{
			get
			{
				return null;
			}
		}

		public bool HasSecurityDeclarations
		{
			get
			{
				return false;
			}
		}

		public Collection<SecurityDeclaration> SecurityDeclarations
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

		public override bool HasGenericParameters
		{
			get
			{
				return false;
			}
		}

		public override Collection<GenericParameter> GenericParameters
		{
			get
			{
				return null;
			}
		}

		public bool IsSpecialName
		{
			get
			{
				return false;
			}
		}

		public bool IsEnum
		{
			get
			{
				return false;
			}
		}

		public override bool IsValueType
		{
			get
			{
				return false;
			}
		}

		public override bool IsPrimitive
		{
			get
			{
				return false;
			}
		}

		public override bool IsDefinition
		{
			get
			{
				return false;
			}
		}

		public new TypeDefinition DeclaringType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void ResolveLayout()
		{
		}

		public TypeDefinition(string @namespace, string name, TypeAttributes attributes)
			: base(null, null)
		{
		}

		public override TypeDefinition Resolve()
		{
			return null;
		}
	}
}
