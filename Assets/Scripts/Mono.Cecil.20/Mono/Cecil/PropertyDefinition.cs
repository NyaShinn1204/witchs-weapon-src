using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class PropertyDefinition : PropertyReference, IMemberDefinition, ICustomAttributeProvider, IMetadataTokenProvider, IConstantProvider
	{
		private bool? has_this;

		private ushort attributes;

		private Collection<CustomAttribute> custom_attributes;

		internal MethodDefinition get_method;

		internal MethodDefinition set_method;

		internal Collection<MethodDefinition> other_methods;

		private object constant;

		public bool HasThis
		{
			set
			{
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

		public MethodDefinition GetMethod
		{
			get
			{
				return null;
			}
		}

		public bool HasParameters
		{
			get
			{
				return false;
			}
		}

		public override Collection<ParameterDefinition> Parameters
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

		public bool IsSpecialName
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

		public override bool IsDefinition
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

		private static Collection<ParameterDefinition> MirrorParameters(MethodDefinition method, int bound)
		{
			return null;
		}

		public PropertyDefinition(string name, PropertyAttributes attributes, TypeReference propertyType)
			: base(null, null)
		{
		}

		private void InitializeMethods()
		{
		}
	}
}
