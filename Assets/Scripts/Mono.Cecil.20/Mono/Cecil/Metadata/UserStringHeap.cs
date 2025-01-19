using Mono.Cecil.PE;

namespace Mono.Cecil.Metadata
{
	internal sealed class UserStringHeap : StringHeap
	{
		public UserStringHeap(Section section, uint start, uint size)
			: base(null, 0u, 0u)
		{
		}

		protected override string ReadStringAt(uint index)
		{
			return null;
		}
	}
}
