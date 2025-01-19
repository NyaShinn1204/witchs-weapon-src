using System.Runtime.InteropServices;

namespace Mono.Cecil
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	internal struct Range
	{
		public uint Start;

		public uint Length;

		public Range(uint index, uint length)
		{
			Start = 0u;
			Length = 0u;
		}
	}
}
