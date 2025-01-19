using System.Runtime.InteropServices;

namespace Mono.Cecil.PE
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	internal struct DataDirectory
	{
		public readonly uint VirtualAddress;

		public readonly uint Size;

		public bool IsZero
		{
			get
			{
				return false;
			}
		}

		public DataDirectory(uint rva, uint size)
		{
			VirtualAddress = 0u;
			Size = 0u;
		}
	}
}
