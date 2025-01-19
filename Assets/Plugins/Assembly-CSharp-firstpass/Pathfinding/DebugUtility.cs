using UnityEngine;

namespace Pathfinding
{
	public class DebugUtility : MonoBehaviour
	{
		public Material defaultMaterial;

		public static DebugUtility active;

		public float offset;

		public bool optimizeMeshes;

		public void Awake()
		{
		}

		public static void DrawCubes(Vector3[] topVerts, Vector3[] bottomVerts, Color[] vertexColors, float width)
		{
		}

		public static void DrawQuads(Vector3[] verts, float width)
		{
		}

		public static void TestMeshLimit()
		{
		}
	}
}
