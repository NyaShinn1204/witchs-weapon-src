using Mono.Cecil.PE;

namespace Mono.Cecil.Metadata
{
	internal sealed class BlobHeap : Heap
	{
		public BlobHeap(Section section, uint start, uint size)
			: base(null, 0u, 0u)
		{
		}

		public byte[] Read(uint index)
		{
			return null;
		}
	}
}
