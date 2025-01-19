using System.IO;
using Mono.Cecil.Metadata;

namespace Mono.Cecil.PE
{
	internal sealed class ImageReader : BinaryStreamReader
	{
		private readonly Image image;

		private DataDirectory cli;

		private DataDirectory metadata;

		public ImageReader(Stream stream)
			: base(null)
		{
		}

		private void MoveTo(DataDirectory directory)
		{
		}

		private void MoveTo(uint position)
		{
		}

		private void ReadImage()
		{
		}

		private TargetArchitecture ReadArchitecture()
		{
			return default(TargetArchitecture);
		}

		private static ModuleKind GetModuleKind(ushort characteristics, ushort subsystem)
		{
			return default(ModuleKind);
		}

		private void ReadOptionalHeaders(out ushort subsystem, out ushort dll_characteristics)
		{
			subsystem = default(ushort);
			dll_characteristics = default(ushort);
		}

		private string ReadAlignedString(int length)
		{
			return null;
		}

		private string ReadZeroTerminatedString(int length)
		{
			return null;
		}

		private void ReadSections(ushort count)
		{
		}

		private void ReadSectionData(Section section)
		{
		}

		private void ReadCLIHeader()
		{
		}

		private void ReadMetadata()
		{
		}

		private void ReadMetadataStream(Section section)
		{
		}

		private void ReadTableHeap()
		{
		}

		private static void SetIndexSize(Heap heap, uint sizes, byte flag)
		{
		}

		private int GetTableIndexSize(Table table)
		{
			return 0;
		}

		private int GetCodedIndexSize(CodedIndex index)
		{
			return 0;
		}

		private void ComputeTableInformations()
		{
		}

		public static Image ReadImageFrom(Stream stream)
		{
			return null;
		}
	}
}
