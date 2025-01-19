using System;

namespace Mono.Cecil
{
	public class AssemblyNameReference : IMetadataScope, IMetadataTokenProvider
	{
		private string name;

		private string culture;

		private Version version;

		private uint attributes;

		private byte[] public_key;

		private byte[] public_key_token;

		private AssemblyHashAlgorithm hash_algorithm;

		private byte[] hash;

		internal MetadataToken token;

		private string full_name;

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

		public string Culture
		{
			set
			{
			}
		}

		public Version Version
		{
			set
			{
			}
		}

		public AssemblyAttributes Attributes
		{
			set
			{
			}
		}

		public bool HasPublicKey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public byte[] PublicKey
		{
			set
			{
			}
		}

		public byte[] PublicKeyToken
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

		public string FullName
		{
			get
			{
				return null;
			}
		}

		public AssemblyHashAlgorithm HashAlgorithm
		{
			set
			{
			}
		}

		public virtual byte[] Hash
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

		private byte[] HashPublicKey()
		{
			return null;
		}

		public static AssemblyNameReference Parse(string fullName)
		{
			return null;
		}

		internal AssemblyNameReference()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
