using UnityEngine;

namespace ParadoxNotion
{
	public static class RectUtils
	{
		public static Rect GetBoundRect(params Rect[] rects)
		{
			return default(Rect);
		}

		public static Rect GetBoundRect(params Vector2[] positions)
		{
			return default(Rect);
		}

		public static bool Encapsulates(this Rect a, Rect b)
		{
			return false;
		}
	}
}
