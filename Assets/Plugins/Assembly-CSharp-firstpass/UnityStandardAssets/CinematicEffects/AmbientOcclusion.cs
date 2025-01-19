using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityStandardAssets.CinematicEffects
{
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	public class AmbientOcclusion : MonoBehaviour
	{
		[StructLayout(LayoutKind.Sequential, Size = 20)]
		private struct PropertyObserver
		{
			private bool _downsampling;

			private OcclusionSource _occlusionSource;

			private bool _ambientOnly;

			private int _pixelWidth;

			private int _pixelHeight;

			public bool CheckNeedsReset(Settings setting, Camera camera)
			{
				return false;
			}

			public void Update(Settings setting, Camera camera)
			{
			}
		}

		public enum SampleCount
		{
			Lowest = 0,
			Low = 1,
			Medium = 2,
			High = 3,
			Variable = 4
		}

		public enum OcclusionSource
		{
			DepthTexture = 0,
			DepthNormalsTexture = 1,
			GBuffer = 2
		}

		[Serializable]
		public class Settings
		{
			[SerializeField]
			public float intensity;

			[SerializeField]
			public float radius;

			[SerializeField]
			public SampleCount sampleCount;

			[SerializeField]
			public int sampleCountValue;

			[SerializeField]
			public bool downsampling;

			[SerializeField]
			public bool ambientOnly;

			[SerializeField]
			public OcclusionSource occlusionSource;

			[SerializeField]
			public bool debug;

			public static Settings defaultSettings
			{
				get
				{
					return null;
				}
			}
		}

		[SerializeField]
		public Settings settings;

		[SerializeField]
		private Shader _aoShader;

		private Material _aoMaterial;

		private CommandBuffer _aoCommands;

		[SerializeField]
		private Mesh _quadMesh;

		public bool isAmbientOnlySupported
		{
			get
			{
				return false;
			}
		}

		public bool isGBufferAvailable
		{
			get
			{
				return false;
			}
		}

		private float intensity
		{
			get
			{
				return 0f;
			}
		}

		private float radius
		{
			get
			{
				return 0f;
			}
		}

		private SampleCount sampleCount
		{
			get
			{
				return default(SampleCount);
			}
		}

		private int sampleCountValue
		{
			get
			{
				return 0;
			}
		}

		private OcclusionSource occlusionSource
		{
			get
			{
				return default(OcclusionSource);
			}
		}

		private bool downsampling
		{
			get
			{
				return false;
			}
		}

		private bool ambientOnly
		{
			get
			{
				return false;
			}
		}

		private Shader aoShader
		{
			get
			{
				return null;
			}
		}

		private Material aoMaterial
		{
			get
			{
				return null;
			}
		}

		private CommandBuffer aoCommands
		{
			get
			{
				return null;
			}
		}

		private Camera targetCamera
		{
			get
			{
				return null;
			}
		}

		private PropertyObserver propertyObserver { get; set; }

		private Mesh quadMesh
		{
			get
			{
				return null;
			}
		}

		private void BuildAOCommands()
		{
		}

		private void ExecuteAOPass(RenderTexture source, RenderTexture destination)
		{
		}

		private void UpdateMaterialProperties()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
