using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	[Serializable]
	public class SMAA : IAntiAliasing
	{
		public class SettingsGroup : Attribute
		{
		}

		public class TopLevelSettings : Attribute
		{
		}

		public class ExperimentalGroup : Attribute
		{
		}

		public enum DebugPass
		{
			Off = 0,
			Edges = 1,
			Weights = 2,
			Accumulation = 3
		}

		public enum QualityPreset
		{
			Low = 0,
			Medium = 1,
			High = 2,
			Ultra = 3,
			Custom = 4
		}

		public enum EdgeDetectionMethod
		{
			Luma = 1,
			Color = 2,
			Depth = 3
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 12)]
		public struct GlobalSettings
		{
			public DebugPass debugPass;

			public QualityPreset quality;

			public EdgeDetectionMethod edgeDetectionMethod;

			public static GlobalSettings defaultSettings
			{
				get
				{
					return default(GlobalSettings);
				}
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 32)]
		public struct QualitySettings
		{
			public bool diagonalDetection;

			public bool cornerDetection;

			public float threshold;

			public float depthThreshold;

			public int maxSearchSteps;

			public int maxDiagonalSearchSteps;

			public int cornerRounding;

			public float localContrastAdaptationFactor;

			public static QualitySettings[] presetQualitySettings;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 8)]
		public struct TemporalSettings
		{
			public bool enabled;

			public float fuzzSize;

			public static TemporalSettings defaultSettings
			{
				get
				{
					return default(TemporalSettings);
				}
			}

			public bool UseTemporal()
			{
				return false;
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 16)]
		public struct PredicationSettings
		{
			public bool enabled;

			public float threshold;

			public float scale;

			public float strength;

			public static PredicationSettings defaultSettings
			{
				get
				{
					return default(PredicationSettings);
				}
			}
		}

		[TopLevelSettings]
		public GlobalSettings settings;

		[SettingsGroup]
		public QualitySettings quality;

		[SettingsGroup]
		public PredicationSettings predication;

		[SettingsGroup]
		[ExperimentalGroup]
		public TemporalSettings temporal;

		private Matrix4x4 m_ProjectionMatrix;

		private Matrix4x4 m_PreviousViewProjectionMatrix;

		private float m_FlipFlop;

		private RenderTexture m_Accumulation;

		private Shader m_Shader;

		private Texture2D m_AreaTexture;

		private Texture2D m_SearchTexture;

		private Material m_Material;

		public Shader shader
		{
			get
			{
				return null;
			}
		}

		private Texture2D areaTexture
		{
			get
			{
				return null;
			}
		}

		private Texture2D searchTexture
		{
			get
			{
				return null;
			}
		}

		private Material material
		{
			get
			{
				return null;
			}
		}

		public void OnEnable(AntiAliasing owner)
		{
		}

		public void OnDisable()
		{
		}

		public void OnPreCull(Camera camera)
		{
		}

		public void OnPostRender(Camera camera)
		{
		}

		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		private RenderTexture TempRT(int width, int height, RenderTextureFormat format)
		{
			return null;
		}
	}
}
