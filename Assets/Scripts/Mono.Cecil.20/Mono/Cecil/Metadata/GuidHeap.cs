using System;
using Mono.Cecil.PE;

namespace Mono.Cecil.Metadata
{
	internal sealed class GuidHeap : Heap
	{
		public GuidHeap(Section section, uint start, uint size)
			: base(null, 0u, 0u)
		{
		}

		public Guid Read(uint index)
		{
			return default(Guid);
		}
	}
}
