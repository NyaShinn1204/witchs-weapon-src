using Mono.Cecil.Cil;
using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class MethodDefinition : MethodReference, IMemberDefinition, ICustomAttributeProvider, IMetadataTokenProvider, ISecurityDeclarationProvider
	{
		private ushort attributes;

		private ushort impl_attributes;

		internal bool sem_attrs_ready;

		internal MethodSemanticsAttributes sem_attrs;

		private Collection<CustomAttribute> custom_attributes;

		private Collection<SecurityDeclaration> security_declarations;

		internal uint rva;

		internal PInvokeInfo pinvoke;

		private Collection<MethodReference> overrides;

		internal MethodBody body;

		public MethodAttributes Attributes
		{
			set
			{
			}
		}

		public MethodImplAttributes ImplAttributes
		{
			set
			{
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

		public int RVA
		{
			get
			{
				return 0;
			}
		}

		public bool HasBody
		{
			get
			{
				return false;
			}
		}

		public MethodBody Body
		{
			get
			{
				return null;
			}
		}

		public PInvokeInfo PInvokeInfo
		{
			get
			{
				return null;
			}
		}

		public bool HasOverrides
		{
			get
			{
				return false;
			}
		}

		public Collection<MethodReference> Overrides
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

		public bool IsStatic
		{
			get
			{
				return false;
			}
		}

		public bool IsVirtual
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

		public bool IsPInvokeImpl
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

		internal MethodDefinition()
		{
		}
	}
}
