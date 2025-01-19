using System.IO;

namespace Mono.Cecil.PE
{
	internal class BinaryStreamReader : BinaryReader
	{
		public BinaryStreamReader(Stream stream)
			: base(null)
		{
		}

		protected void Advance(int bytes)
		{
		}

		protected DataDirectory ReadDataDirectory()
		{
			return default(DataDirectory);
		}
	}
}
