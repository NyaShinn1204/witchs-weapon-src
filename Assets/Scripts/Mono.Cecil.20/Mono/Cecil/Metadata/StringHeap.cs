using System.Collections.Generic;
using Mono.Cecil.PE;

namespace Mono.Cecil.Metadata
{
	internal class StringHeap : Heap
	{
		private readonly Dictionary<uint, string> strings;

		public StringHeap(Section section, uint start, uint size)
			: base(null, 0u, 0u)
		{
		}

		public string Read(uint index)
		{
			return null;
		}

		protected virtual string ReadStringAt(uint index)
		{
			return null;
		}
	}
}
