namespace Mono.Cecil
{
	public abstract class MemberReference : IMetadataTokenProvider
	{
		private string name;

		private TypeReference declaring_type;

		internal MetadataToken token;

		public virtual string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract string FullName { get; }

		public virtual TypeReference DeclaringType
		{
			get
			{
				return null;
			}
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

		internal bool HasImage
		{
			get
			{
				return false;
			}
		}

		public virtual ModuleDefinition Module
		{
			get
			{
				return null;
			}
		}

		public virtual bool IsDefinition
		{
			get
			{
				return false;
			}
		}

		internal virtual bool ContainsGenericParameter
		{
			get
			{
				return false;
			}
		}

		internal MemberReference()
		{
		}

		internal MemberReference(string name)
		{
		}

		internal string MemberFullName()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
