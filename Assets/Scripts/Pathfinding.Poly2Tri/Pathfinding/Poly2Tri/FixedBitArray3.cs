using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Pathfinding.Poly2Tri
{
	[StructLayout(LayoutKind.Sequential, Size = 12)]
	public struct FixedBitArray3 : IEnumerable, IEnumerable<bool>
	{
		public bool _0;

		public bool _1;

		public bool _2;

		public bool Item
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}

		[DebuggerHidden]
		private IEnumerable<bool> Enumerate()
		{
			return null;
		}

		public IEnumerator<bool> GetEnumerator()
		{
			return null;
		}
	}
}
