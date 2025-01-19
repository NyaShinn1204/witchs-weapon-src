using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	[Serializable]
	public class FXAA : IAntiAliasing
	{
		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 12)]
		public struct QualitySettings
		{
			public float subpixelAliasingRemovalAmount;

			public float edgeDetectionThreshold;

			public float minimumRequiredLuminance;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 16)]
		public struct ConsoleSettings
		{
			public float subpixelSpreadAmount;

			public float edgeSharpnessAmount;

			public float edgeDetectionThreshold;

			public float minimumRequiredLuminance;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 28)]
		public struct Preset
		{
			public class LayoutAttribute : PropertyAttribute
			{
			}

			[Layout]
			public QualitySettings qualitySettings;

			[Layout]
			public ConsoleSettings consoleSettings;

			private static readonly Preset s_ExtremePerformance;

			private static readonly Preset s_Performance;

			private static readonly Preset s_Default;

			private static readonly Preset s_Quality;

			private static readonly Preset s_ExtremeQuality;

			public static Preset extremePerformancePreset
			{
				get
				{
					return default(Preset);
				}
			}

			public static Preset performancePreset
			{
				get
				{
					return default(Preset);
				}
			}

			public static Preset defaultPreset
			{
				get
				{
					return default(Preset);
				}
			}

			public static Preset qualityPreset
			{
				get
				{
					return default(Preset);
				}
			}

			public static Preset extremeQualityPreset
			{
				get
				{
					return default(Preset);
				}
			}
		}

		private Shader m_Shader;

		private Material m_Material;

		[SerializeField]
		[HideInInspector]
		public Preset preset;

		public static Preset[] availablePresets;

		private Shader shader
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

		public bool validSourceFormat { get; private set; }

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
	}
}
