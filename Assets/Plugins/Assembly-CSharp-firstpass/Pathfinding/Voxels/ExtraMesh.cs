using UnityEngine;

namespace Pathfinding.Voxels
{
	public struct ExtraMesh
	{
		public MeshFilter original;

		public int area;

		public Vector3[] vertices;

		public int[] triangles;

		public Bounds bounds;

		public Matrix4x4 matrix;

		public ExtraMesh(Vector3[] v, int[] t, Bounds b)
		{
			original = null;
			area = 0;
			vertices = null;
			triangles = null;
			bounds = default(Bounds);
			matrix = default(Matrix4x4);
		}

		public ExtraMesh(Vector3[] v, int[] t, Bounds b, Matrix4x4 matrix)
		{
			original = null;
			area = 0;
			vertices = null;
			triangles = null;
			bounds = default(Bounds);
			this.matrix = default(Matrix4x4);
		}

		public void RecalculateBounds()
		{
		}
	}
}
