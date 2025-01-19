namespace Mono.Cecil
{
	public class ExportedType : IMetadataTokenProvider
	{
		private string @namespace;

		private string name;

		private uint attributes;

		private IMetadataScope scope;

		private ModuleDefinition module;

		private int identifier;

		private ExportedType declaring_type;

		internal MetadataToken token;

		public string Namespace
		{
			get
			{
				return null;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public TypeAttributes Attributes
		{
			set
			{
			}
		}

		public ExportedType DeclaringType
		{
			set
			{
			}
		}

		public MetadataToken MetadataToken
		{
			get
			{
				return default(MetadataToken);
			}
		}

		public int Identifier
		{
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

		public ExportedType(string @namespace, string name, ModuleDefinition module, IMetadataScope scope)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public TypeDefinition Resolve()
		{
			return null;
		}

		internal TypeReference CreateReference()
		{
			return null;
		}
	}
}
