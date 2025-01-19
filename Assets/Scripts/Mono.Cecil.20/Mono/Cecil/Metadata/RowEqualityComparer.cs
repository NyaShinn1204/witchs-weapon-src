using System.Collections.Generic;

namespace Mono.Cecil.Metadata
{
	internal sealed class RowEqualityComparer : IEqualityComparer<Row<string, string>>, IEqualityComparer<Row<uint, uint>>, IEqualityComparer<Row<uint, uint, uint>>
	{
		public bool Equals(Row<string, string> x, Row<string, string> y)
		{
			return false;
		}

		public int GetHashCode(Row<string, string> obj)
		{
			return 0;
		}

		public bool Equals(Row<uint, uint> x, Row<uint, uint> y)
		{
			return false;
		}

		public int GetHashCode(Row<uint, uint> obj)
		{
			return 0;
		}

		public bool Equals(Row<uint, uint, uint> x, Row<uint, uint, uint> y)
		{
			return false;
		}

		public int GetHashCode(Row<uint, uint, uint> obj)
		{
			return 0;
		}
	}
}
