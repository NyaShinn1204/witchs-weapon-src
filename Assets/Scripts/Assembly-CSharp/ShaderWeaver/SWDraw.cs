using UnityEngine;

namespace ShaderWeaver
{
	public class SWDraw
	{
		protected static bool clippingEnabled;

		protected static Rect clippingBounds;

		protected static bool clip_test(float p, float q, ref float u1, ref float u2)
		{
			return false;
		}

		protected static bool segment_rect_intersection(Rect bounds, ref Vector2 p1, ref Vector2 p2)
		{
			return false;
		}

		public static void BeginGroup(Rect position)
		{
		}

		public static void EndGroup()
		{
		}

		public static void DrawLine(Vector2 start, Vector2 end, Color color, float width, Material mat = null)
		{
		}

		public static void DrawBox(Rect box, Color color, float width)
		{
		}

		public static void DrawBox(Vector2 topLeftCorner, Vector2 bottomRightCorner, Color color, float width)
		{
		}

		public static void DrawRoundedBox(Rect box, float radius, Color color, float width)
		{
		}

		public static void DrawConnectingCurve(Vector2 start, Vector2 end, Color color, float width)
		{
		}

		public static void DrawBezier(Vector2 start, Vector2 startTangent, Vector2 end, Vector2 endTangent, Color color, float width)
		{
		}

		public static void DrawBezier(Vector2 start, Vector2 startTangent, Vector2 end, Vector2 endTangent, Color color, float width, int segments)
		{
		}

		private static Vector2 CubeBezier(Vector2 s, Vector2 st, Vector2 e, Vector2 et, float t)
		{
			return default(Vector2);
		}
	}
}
