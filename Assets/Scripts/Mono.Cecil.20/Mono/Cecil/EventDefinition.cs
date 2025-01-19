using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class EventDefinition : EventReference, IMemberDefinition, ICustomAttributeProvider, IMetadataTokenProvider
	{
		private ushort attributes;

		private Collection<CustomAttribute> custom_attributes;

		internal MethodDefinition add_method;

		internal MethodDefinition invoke_method;

		internal MethodDefinition remove_method;

		internal Collection<MethodDefinition> other_methods;

		public MethodDefinition AddMethod
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

		public EventDefinition(string name, EventAttributes attributes, TypeReference eventType)
			: base(null, null)
		{
		}

		private void InitializeMethods()
		{
		}
	}
}
