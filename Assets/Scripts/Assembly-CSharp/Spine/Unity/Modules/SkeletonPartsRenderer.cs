using UnityEngine;

namespace Spine.Unity.Modules
{
	public class SkeletonPartsRenderer : MonoBehaviour
	{
		private MeshGenerator meshGenerator;

		private MeshRenderer meshRenderer;

		private MeshFilter meshFilter;

		private MeshRendererBuffers buffers;

		private SkeletonRendererInstruction currentInstructions;

		public MeshGenerator MeshGenerator
		{
			get
			{
				return null;
			}
		}

		public MeshRenderer MeshRenderer
		{
			get
			{
				return null;
			}
		}

		public MeshFilter MeshFilter
		{
			get
			{
				return null;
			}
		}

		private void LazyIntialize()
		{
		}

		public void ClearMesh()
		{
		}

		public void RenderParts(ExposedList<SubmeshInstruction> instructions, int startSubmesh, int endSubmesh)
		{
		}

		public void SetPropertyBlock(MaterialPropertyBlock block)
		{
		}

		public static SkeletonPartsRenderer NewPartsRendererGameObject(Transform parent, string name)
		{
			return null;
		}
	}
}
