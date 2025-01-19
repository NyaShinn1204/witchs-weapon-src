using System.Runtime.InteropServices;

namespace Mono.Cecil.Cil
{
	[StructLayout(LayoutKind.Sequential, Size = 28)]
	public struct ImageDebugDirectory
	{
		public int Characteristics;

		public int TimeDateStamp;

		public short MajorVersion;

		public short MinorVersion;

		public int Type;

		public int SizeOfData;

		public int AddressOfRawData;

		public int PointerToRawData;
	}
}
