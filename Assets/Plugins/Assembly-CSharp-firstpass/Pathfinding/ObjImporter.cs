using System.Runtime.InteropServices;
using UnityEngine;

namespace Pathfinding
{
	public class ObjImporter
	{
		[StructLayout(LayoutKind.Sequential, Size = 88)]
		private struct meshStruct
		{
			public Vector3[] vertices;

			public Vector3[] normals;

			public Vector2[] uv;

			public Vector2[] uv1;

			public Vector2[] uv2;

			public int[] triangles;

			public int[] faceVerts;

			public int[] faceUVs;

			public Vector3[] faceData;

			public string name;

			public string fileName;
		}

		public static Mesh ImportFile(string filePath)
		{
			return null;
		}

		private static meshStruct createMeshStruct(string filename)
		{
			return default(meshStruct);
		}

		private static void populateMeshStruct(ref meshStruct mesh)
		{
		}
	}
}
