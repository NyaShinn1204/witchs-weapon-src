using System.Runtime.InteropServices;

namespace Mono.Cecil.Metadata
{
	[StructLayout(LayoutKind.Sequential, Size = 12)]
	internal struct TableInformation
	{
		public uint Offset;

		public uint Length;

		public uint RowSize;
	}
}
