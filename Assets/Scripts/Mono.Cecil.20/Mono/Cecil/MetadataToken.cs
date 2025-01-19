using System.Runtime.InteropServices;

namespace Mono.Cecil
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	public struct MetadataToken
	{
		private readonly uint token;

		public static readonly MetadataToken Zero;

		public uint RID
		{
			get
			{
				return 0u;
			}
		}

		public TokenType TokenType
		{
			get
			{
				return default(TokenType);
			}
		}

		public MetadataToken(uint token)
		{
			this.token = 0u;
		}

		public MetadataToken(TokenType type)
		{
			token = 0u;
		}

		public MetadataToken(TokenType type, uint rid)
		{
			token = 0u;
		}

		public MetadataToken(TokenType type, int rid)
		{
			token = 0u;
		}

		public uint ToUInt32()
		{
			return 0u;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static bool operator ==(MetadataToken one, MetadataToken other)
		{
			return false;
		}

		public static bool operator !=(MetadataToken one, MetadataToken other)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
