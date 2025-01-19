using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	public class ScreenSpaceReflection : MonoBehaviour
	{
		public enum SSRDebugMode
		{
			None = 0,
			IncomingRadiance = 1,
			SSRResult = 2,
			FinalGlossyTerm = 3,
			SSRMask = 4,
			Roughness = 5,
			BaseColor = 6,
			SpecColor = 7,
			Reflectivity = 8,
			ReflectionProbeOnly = 9,
			ReflectionProbeMinusSSR = 10,
			SSRMinusReflectionProbe = 11,
			NoGlossy = 12,
			NegativeNoGlossy = 13,
			MipLevel = 14
		}

		public enum SSRResolution
		{
			FullResolution = 0,
			HalfTraceFullResolve = 1,
			HalfResolution = 2
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 108)]
		public struct SSRSettings
		{
			public class LayoutAttribute : PropertyAttribute
			{
			}

			[Layout]
			public BasicSettings basicSettings;

			[Layout]
			public ReflectionSettings reflectionSettings;

			[Layout]
			public AdvancedSettings advancedSettings;

			[Layout]
			public DebugSettings debugSettings;

			private static readonly SSRSettings s_Performance;

			private static readonly SSRSettings s_Default;

			private static readonly SSRSettings s_HighQuality;

			public static SSRSettings performanceSettings
			{
				get
				{
					return default(SSRSettings);
				}
			}

			public static SSRSettings defaultSettings
			{
				get
				{
					return default(SSRSettings);
				}
			}

			public static SSRSettings highQualitySettings
			{
				get
				{
					return default(SSRSettings);
				}
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 24)]
		public struct BasicSettings
		{
			public float reflectionMultiplier;

			public float maxDistance;

			public float fadeDistance;

			public float screenEdgeFading;

			public bool enableHDR;

			public bool additiveReflection;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 32)]
		public struct ReflectionSettings
		{
			public int maxSteps;

			public int rayStepSize;

			public float widthModifier;

			public float smoothFallbackThreshold;

			public float smoothFallbackDistance;

			public float fresnelFade;

			public float fresnelFadePower;

			public float distanceBlur;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 48)]
		public struct AdvancedSettings
		{
			public float temporalFilterStrength;

			public bool useTemporalConfidence;

			public bool traceBehindObjects;

			public bool highQualitySharpReflections;

			public bool traceEverywhere;

			public bool treatBackfaceHitAsMiss;

			public bool allowBackwardsRays;

			public bool improveCorners;

			public SSRResolution resolution;

			public bool bilateralUpsample;

			public bool reduceBanding;

			public bool highlightSuppression;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 4)]
		public struct DebugSettings
		{
			public SSRDebugMode debugMode;
		}

		private enum PassIndex
		{
			RayTraceStep1 = 0,
			RayTraceStep2 = 1,
			RayTraceStep4 = 2,
			RayTraceStep8 = 3,
			RayTraceStep16 = 4,
			CompositeFinal = 5,
			Blur = 6,
			CompositeSSR = 7,
			Blit = 8,
			EdgeGeneration = 9,
			MinMipGeneration = 10,
			HitPointToReflections = 11,
			BilateralKeyPack = 12,
			BlitDepthAsCSZ = 13,
			TemporalFilter = 14,
			AverageRayDistanceGeneration = 15,
			PoissonBlur = 16
		}

		[SerializeField]
		public SSRSettings settings;

		private bool useEdgeDetector;

		private float mipBias;

		private bool useOcclusion;

		private bool fullResolutionFiltering;

		private bool fallbackToSky;

		private bool computeAverageRayDistance;

		private bool m_HasInformationFromPreviousFrame;

		private Matrix4x4 m_PreviousWorldToCameraMatrix;

		private RenderTexture m_PreviousDepthBuffer;

		private RenderTexture m_PreviousHitBuffer;

		private RenderTexture m_PreviousReflectionBuffer;

		[NonSerialized]
		private RenderTextureUtility m_RTU;

		[SerializeField]
		private Shader m_Shader;

		private Material m_Material;

		public Shader shader
		{
			get
			{
				return null;
			}
		}

		public Material material
		{
			get
			{
				return null;
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void PreparePreviousBuffers(int w, int h)
		{
		}

		[ImageEffectOpaque]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
