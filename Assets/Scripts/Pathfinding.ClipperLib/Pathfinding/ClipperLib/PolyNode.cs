using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pathfinding.ClipperLib
{
	public class PolyNode
	{
		internal PolyNode m_Parent;

		internal List<IntPoint> m_polygon;

		internal int m_Index;

		internal List<PolyNode> m_Childs;

		[CompilerGenerated]
		private bool _003CIsOpen_003Ek__BackingField;

		public int ChildCount
		{
			get
			{
				return 0;
			}
		}

		public List<IntPoint> Contour
		{
			get
			{
				return null;
			}
		}

		public List<PolyNode> Childs
		{
			get
			{
				return null;
			}
		}

		public bool IsOpen
		{
			[CompilerGenerated]
			set
			{
				_003CIsOpen_003Ek__BackingField = value;
			}
		}

		internal void AddChild(PolyNode Child)
		{
		}
	}
}
