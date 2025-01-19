namespace Mono.Cecil
{
	public class ModuleReference : IMetadataScope, IMetadataTokenProvider
	{
		private string name;

		internal MetadataToken token;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual MetadataScopeType MetadataScopeType
		{
			get
			{
				return default(MetadataScopeType);
			}
		}

		public MetadataToken MetadataToken
		{
			get
			{
				return default(MetadataToken);
			}
		}

		internal ModuleReference()
		{
		}

		public ModuleReference(string name)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
