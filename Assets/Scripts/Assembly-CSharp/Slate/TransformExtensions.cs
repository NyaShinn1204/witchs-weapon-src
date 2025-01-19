using System;
using System.Collections.Generic;
using UnityEngine;

namespace Slate
{
	public static class TransformExtensions
	{
		public static Vector3 GetLocalEulerAngles(this Transform transform)
		{
			return default(Vector3);
		}

		public static void SetLocalEulerAngles(this Transform transform, Vector3 value)
		{
		}

		public static T GetAddComponent<T>(this GameObject go) where T : Component
		{
			return null;
		}

		public static T GetAddComponent<T>(this Component comp) where T : Component
		{
			return null;
		}

		public static Component GetAddComponent(this GameObject go, Type type)
		{
			return null;
		}

		public static Transform FindInChildren(this Transform root, string name, bool includeHidden)
		{
			return null;
		}

		public static List<string> GetBlendShapeNames(this SkinnedMeshRenderer skinnedMesh)
		{
			return null;
		}

		public static int GetBlendShapeIndex(this SkinnedMeshRenderer skinnedMesh, string shapeName)
		{
			return 0;
		}

		public static string SplitCamelCase(this string s)
		{
			return null;
		}

		public static bool Encapsulates(this Rect a, Rect b)
		{
			return false;
		}

		public static Rect ToViewRect(this Bounds b, Camera cam)
		{
			return default(Rect);
		}
	}
}
