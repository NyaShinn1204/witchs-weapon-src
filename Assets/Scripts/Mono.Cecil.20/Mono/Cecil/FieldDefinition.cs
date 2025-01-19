using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class FieldDefinition : FieldReference, IMemberDefinition, ICustomAttributeProvider, IMetadataTokenProvider, IConstantProvider, IMarshalInfoProvider
	{
		private ushort attributes;

		private Collection<CustomAttribute> custom_attributes;

		private int offset;

		internal int rva;

		private byte[] initial_value;

		private object constant;

		private MarshalInfo marshal_info;

		public bool HasLayoutInfo
		{
			get
			{
				return false;
			}
		}

		public int Offset
		{
			get
			{
				return 0;
			}
		}

		public int RVA
		{
			get
			{
				return 0;
			}
		}

		public byte[] InitialValue
		{
			get
			{
				return null;
			}
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

		public bool IsStatic
		{
			get
			{
				return false;
			}
		}

		public bool IsSpecialName
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

		private void ResolveRVA()
		{
		}

		public FieldDefinition(string name, FieldAttributes attributes, TypeReference fieldType)
		{
		}
	}
}
