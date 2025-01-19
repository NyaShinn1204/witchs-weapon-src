using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Spine.Unity
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class SkeletonRenderer : MonoBehaviour, ISkeletonComponent
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void SkeletonRendererDelegate(SkeletonRenderer skeletonRenderer);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void InstructionDelegate(SkeletonRendererInstruction instruction);

		public SkeletonDataAsset skeletonDataAsset;

		public string initialSkinName;

		public bool initialFlipX;

		public bool initialFlipY;

		public string[] separatorSlotNames;

		[NonSerialized]
		public readonly List<Slot> separatorSlots;

		public float zSpacing;

		public bool useClipping;

		public bool immutableTriangles;

		public bool pmaVertexColors;

		public bool clearStateOnDisable;

		public bool tintBlack;

		public bool singleSubmesh;

		public bool addNormals;

		public bool calculateTangents;

		public bool logErrors;

		public bool disableRenderingOnOverride;

		[NonSerialized]
		private readonly Dictionary<Material, Material> customMaterialOverride;

		[NonSerialized]
		private readonly Dictionary<Slot, Material> customSlotMaterials;

		private MeshRenderer meshRenderer;

		private MeshFilter meshFilter;

		[NonSerialized]
		public bool valid;

		[NonSerialized]
		public Skeleton skeleton;

		[NonSerialized]
		private readonly SkeletonRendererInstruction currentInstructions;

		private readonly MeshGenerator meshGenerator;

		[NonSerialized]
		private readonly MeshRendererBuffers rendererBuffers;

		public SkeletonDataAsset SkeletonDataAsset
		{
			get
			{
				return null;
			}
		}

		public Dictionary<Material, Material> CustomMaterialOverride
		{
			get
			{
				return null;
			}
		}

		public Dictionary<Slot, Material> CustomSlotMaterials
		{
			get
			{
				return null;
			}
		}

		public Skeleton Skeleton
		{
			get
			{
				return null;
			}
		}

		public event SkeletonRendererDelegate OnRebuild
		{
			add
			{
			}
			remove
			{
			}
		}

		public event MeshGeneratorDelegate OnPostProcessVertices
		{
			add
			{
			}
			remove
			{
			}
		}

		private event InstructionDelegate generateMeshOverride
		{
			add
			{
			}
			remove
			{
			}
		}

		public event InstructionDelegate GenerateMeshOverride
		{
			add
			{
			}
			remove
			{
			}
		}

		public static T NewSpineGameObject<T>(SkeletonDataAsset skeletonDataAsset) where T : SkeletonRenderer
		{
			return null;
		}

		public static T AddSpineComponent<T>(GameObject gameObject, SkeletonDataAsset skeletonDataAsset) where T : SkeletonRenderer
		{
			return null;
		}

		public virtual void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void ClearState()
		{
		}

		public virtual void Initialize(bool overwrite)
		{
		}

		public virtual void LateUpdate()
		{
		}
	}
}
