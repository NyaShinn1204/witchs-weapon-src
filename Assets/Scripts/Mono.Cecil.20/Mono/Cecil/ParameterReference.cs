namespace Mono.Cecil
{
	public abstract class ParameterReference : IMetadataTokenProvider
	{
		private string name;

		internal int index;

		protected TypeReference parameter_type;

		internal MetadataToken token;

		public string Name
		{
			set
			{
			}
		}

		public int Index
		{
			get
			{
				return 0;
			}
		}

		public TypeReference ParameterType
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

		internal ParameterReference(string name, TypeReference parameterType)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
