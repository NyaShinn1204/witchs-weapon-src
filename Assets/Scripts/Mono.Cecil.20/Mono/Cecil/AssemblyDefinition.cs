using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class AssemblyDefinition : ICustomAttributeProvider, IMetadataTokenProvider, ISecurityDeclarationProvider
	{
		private AssemblyNameDefinition name;

		internal ModuleDefinition main_module;

		private Collection<ModuleDefinition> modules;

		private Collection<CustomAttribute> custom_attributes;

		private Collection<SecurityDeclaration> security_declarations;

		public AssemblyNameDefinition Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FullName
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

		public Collection<ModuleDefinition> Modules
		{
			get
			{
				return null;
			}
		}

		public ModuleDefinition MainModule
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

		internal AssemblyDefinition()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
