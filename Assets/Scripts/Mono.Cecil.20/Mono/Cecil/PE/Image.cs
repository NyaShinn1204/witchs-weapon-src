using Mono.Cecil.Cil;
using Mono.Cecil.Metadata;

namespace Mono.Cecil.PE
{
	internal sealed class Image
	{
		public ModuleKind Kind;

		public TargetRuntime Runtime;

		public TargetArchitecture Architecture;

		public ModuleCharacteristics Characteristics;

		public string FileName;

		public Section[] Sections;

		public Section MetadataSection;

		public uint EntryPointToken;

		public ModuleAttributes Attributes;

		public DataDirectory Debug;

		public DataDirectory Resources;

		public DataDirectory StrongName;

		public StringHeap StringHeap;

		public BlobHeap BlobHeap;

		public UserStringHeap UserStringHeap;

		public GuidHeap GuidHeap;

		public TableHeap TableHeap;

		private readonly int[] coded_index_sizes;

		private readonly Func<Table, int> counter;

		public bool HasTable(Table table)
		{
			return false;
		}

		public int GetTableLength(Table table)
		{
			return 0;
		}

		public int GetTableIndexSize(Table table)
		{
			return 0;
		}

		public int GetCodedIndexSize(CodedIndex coded_index)
		{
			return 0;
		}

		public uint ResolveVirtualAddress(uint rva)
		{
			return 0u;
		}

		public uint ResolveVirtualAddressInSection(uint rva, Section section)
		{
			return 0u;
		}

		public Section GetSectionAtVirtualAddress(uint rva)
		{
			return null;
		}

		public ImageDebugDirectory GetDebugHeader(out byte[] header)
		{
			header = null;
			return default(ImageDebugDirectory);
		}
	}
}
