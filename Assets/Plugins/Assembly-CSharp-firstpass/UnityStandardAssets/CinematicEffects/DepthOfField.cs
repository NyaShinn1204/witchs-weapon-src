using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	[ExecuteInEditMode]
	public class DepthOfField : MonoBehaviour
	{
		private enum Passes
		{
			BlurAlphaWeighted = 0,
			BoxBlur = 1,
			DilateFgCocFromColor = 2,
			DilateFgCoc = 3,
			CaptureCoc = 4,
			CaptureCocExplicit = 5,
			VisualizeCoc = 6,
			VisualizeCocExplicit = 7,
			CocPrefilter = 8,
			CircleBlur = 9,
			CircleBlurWithDilatedFg = 10,
			CircleBlurLowQuality = 11,
			CircleBlowLowQualityWithDilatedFg = 12,
			Merge = 13,
			MergeExplicit = 14,
			MergeBicubic = 15,
			MergeExplicitBicubic = 16,
			ShapeLowQuality = 17,
			ShapeLowQualityDilateFg = 18,
			ShapeLowQualityMerge = 19,
			ShapeLowQualityMergeDilateFg = 20,
			ShapeMediumQuality = 21,
			ShapeMediumQualityDilateFg = 22,
			ShapeMediumQualityMerge = 23,
			ShapeMediumQualityMergeDilateFg = 24,
			ShapeHighQuality = 25,
			ShapeHighQualityDilateFg = 26,
			ShapeHighQualityMerge = 27,
			ShapeHighQualityMergeDilateFg = 28
		}

		private enum MedianPasses
		{
			Median3 = 0,
			Median3X3 = 1
		}

		private enum BokehTexturesPasses
		{
			Apply = 0,
			Collect = 1
		}

		public enum TweakMode
		{
			Basic = 0,
			Advanced = 1,
			Explicit = 2
		}

		public enum ApertureShape
		{
			Circular = 0,
			Hexagonal = 1,
			Octogonal = 2
		}

		public enum QualityPreset
		{
			Simple = 0,
			Low = 1,
			Medium = 2,
			High = 3,
			VeryHigh = 4,
			Ultra = 5,
			Custom = 6
		}

		public enum FilterQuality
		{
			None = 0,
			Normal = 1,
			High = 2
		}

		public class TopLevelSettings : Attribute
		{
		}

		public class SettingsGroup : Attribute
		{
		}

		public class AllTweakModes : Attribute
		{
		}

		public class Basic : Attribute
		{
		}

		public class Advanced : Attribute
		{
		}

		public class Explicit : Attribute
		{
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 20)]
		public struct GlobalSettings
		{
			public bool visualizeBluriness;

			public TweakMode tweakMode;

			public QualityPreset quality;

			[Space]
			public ApertureShape apertureShape;

			public float apertureOrientation;

			public static GlobalSettings defaultSettings
			{
				get
				{
					return default(GlobalSettings);
				}
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 20)]
		public struct QualitySettings
		{
			public bool prefilterBlur;

			public FilterQuality medianFilter;

			public bool dilateNearBlur;

			public bool highQualityUpsampling;

			public bool preventHaloing;

			public static QualitySettings[] presetQualitySettings;
		}

		[Serializable]
		public struct FocusSettings
		{
			[Basic]
			[Advanced]
			[Explicit]
			public Transform transform;

			[Basic]
			[Advanced]
			[Explicit]
			public float plane;

			[Explicit]
			public float nearPlane;

			[Explicit]
			public float farPlane;

			[Basic]
			[Advanced]
			public float fStops;

			[Basic]
			[Advanced]
			[Explicit]
			public float rangeAdjustment;

			public static FocusSettings defaultSettings
			{
				get
				{
					return default(FocusSettings);
				}
			}
		}

		[Serializable]
		public struct BokehTextureSettings
		{
			[Advanced]
			[Explicit]
			public Texture2D texture;

			[Advanced]
			[Explicit]
			public float scale;

			[Advanced]
			[Explicit]
			public float intensity;

			[Advanced]
			[Explicit]
			public float threshold;

			[Advanced]
			[Explicit]
			public float spawnHeuristic;

			public static BokehTextureSettings defaultSettings
			{
				get
				{
					return default(BokehTextureSettings);
				}
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 20)]
		public struct BlurSettings
		{
			[Basic]
			[Advanced]
			[Explicit]
			public float nearRadius;

			[Basic]
			[Advanced]
			[Explicit]
			public float farRadius;

			[Advanced]
			[Explicit]
			public float boostPoint;

			[Advanced]
			[Explicit]
			public float nearBoostAmount;

			[Advanced]
			[Explicit]
			public float farBoostAmount;

			public static BlurSettings defaultSettings
			{
				get
				{
					return default(BlurSettings);
				}
			}
		}

		private const float kMaxBlur = 35f;

		[TopLevelSettings]
		public GlobalSettings settings;

		[SettingsGroup]
		[AllTweakModes]
		public QualitySettings quality;

		[SettingsGroup]
		public FocusSettings focus;

		[SettingsGroup]
		public BokehTextureSettings bokehTexture;

		[SettingsGroup]
		public BlurSettings blur;

		[SerializeField]
		private Shader m_FilmicDepthOfFieldShader;

		[SerializeField]
		private Shader m_MedianFilterShader;

		[SerializeField]
		private Shader m_TextureBokehShader;

		private RenderTextureUtility m_RTU;

		private Material m_FilmicDepthOfFieldMaterial;

		private Material m_MedianFilterMaterial;

		private Material m_TextureBokehMaterial;

		private ComputeBuffer m_ComputeBufferDrawArgs;

		private ComputeBuffer m_ComputeBufferPoints;

		private QualitySettings m_CurrentQualitySettings;

		private float m_LastApertureOrientation;

		private Vector4 m_OctogonalBokehDirection1;

		private Vector4 m_OctogonalBokehDirection2;

		private Vector4 m_OctogonalBokehDirection3;

		private Vector4 m_OctogonalBokehDirection4;

		private Vector4 m_HexagonalBokehDirection1;

		private Vector4 m_HexagonalBokehDirection2;

		private Vector4 m_HexagonalBokehDirection3;

		public Shader filmicDepthOfFieldShader
		{
			get
			{
				return null;
			}
		}

		public Shader medianFilterShader
		{
			get
			{
				return null;
			}
		}

		public Shader textureBokehShader
		{
			get
			{
				return null;
			}
		}

		public Material filmicDepthOfFieldMaterial
		{
			get
			{
				return null;
			}
		}

		public Material medianFilterMaterial
		{
			get
			{
				return null;
			}
		}

		public Material textureBokehMaterial
		{
			get
			{
				return null;
			}
		}

		public ComputeBuffer computeBufferDrawArgs
		{
			get
			{
				return null;
			}
		}

		public ComputeBuffer computeBufferPoints
		{
			get
			{
				return null;
			}
		}

		private bool shouldPerformBokeh
		{
			get
			{
				return false;
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private void DoDepthOfField(RenderTexture source, RenderTexture destination)
		{
		}

		private void DoHexagonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		private void DoOctogonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		private void DoCircularBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		private void ComputeCocParameters(out Vector4 blurParams, out Vector4 blurCoe)
		{
			blurParams = default(Vector4);
			blurCoe = default(Vector4);
		}

		private void ReleaseComputeResources()
		{
		}

		private void ComputeBlurDirections(bool force)
		{
		}

		private static void Rotate2D(ref Vector4 direction, float cosinus, float sinus)
		{
		}

		private static void SwapRenderTexture(ref RenderTexture src, ref RenderTexture dst)
		{
		}

		private static void GetDirectionalBlurPassesFromRadius(RenderTexture blurredFgCoc, float maxRadius, out int blurPass, out int blurAndMergePass)
		{
			blurPass = default(int);
			blurAndMergePass = default(int);
		}
	}
}
