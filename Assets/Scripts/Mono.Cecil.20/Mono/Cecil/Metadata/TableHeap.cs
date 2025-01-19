using Mono.Cecil.PE;

namespace Mono.Cecil.Metadata
{
	internal sealed class TableHeap : Heap
	{
		public long Valid;

		public long Sorted;

		public const int TableCount = 45;

		public readonly TableInformation[] Tables;

		public TableInformation Item
		{
			get
			{
				return default(TableInformation);
			}
		}

		public TableHeap(Section section, uint start, uint size)
			: base(null, 0u, 0u)
		{
		}

		public bool HasTable(Table table)
		{
			return false;
		}
	}
}
