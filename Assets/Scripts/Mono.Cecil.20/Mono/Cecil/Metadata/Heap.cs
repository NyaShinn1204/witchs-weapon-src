using Mono.Cecil.PE;

namespace Mono.Cecil.Metadata
{
	internal abstract class Heap
	{
		public int IndexSize;

		public readonly Section Section;

		public readonly uint Offset;

		public readonly uint Size;

		protected Heap(Section section, uint offset, uint size)
		{
		}
	}
}
