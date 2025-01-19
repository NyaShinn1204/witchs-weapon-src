using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	[ExecuteInEditMode]
	public class LensAberrations : MonoBehaviour
	{
		public class SettingsGroup : Attribute
		{
		}

		public class SimpleSetting : Attribute
		{
		}

		public class AdvancedSetting : Attribute
		{
		}

		public enum SettingsMode
		{
			Simple = 0,
			Advanced = 1
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 28)]
		public struct DistortionSettings
		{
			public bool enabled;

			public float amount;

			public float centerX;

			public float centerY;

			public float amountX;

			public float amountY;

			public float scale;

			public static DistortionSettings defaultSettings
			{
				get
				{
					return default(DistortionSettings);
				}
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 56)]
		public struct VignetteSettings
		{
			public bool enabled;

			public SettingsMode mode;

			public Color color;

			[SimpleSetting]
			public float intensity;

			[SimpleSetting]
			public float smoothness;

			[AdvancedSetting]
			public float radius;

			[AdvancedSetting]
			public float spread;

			[AdvancedSetting]
			public float falloff;

			[AdvancedSetting]
			public float roundness;

			public float blur;

			public float desaturate;

			public static VignetteSettings defaultSettings
			{
				get
				{
					return default(VignetteSettings);
				}
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 20)]
		public struct ChromaticAberrationSettings
		{
			public bool enabled;

			public SettingsMode mode;

			public float tangential;

			[AdvancedSetting]
			public float axial;

			[AdvancedSetting]
			public float contrastDependency;

			public static ChromaticAberrationSettings defaultSettings
			{
				get
				{
					return default(ChromaticAberrationSettings);
				}
			}
		}

		private enum Pass
		{
			BlurPrePass = 0,
			Simple = 1,
			Desaturate = 2,
			Blur = 3,
			BlurDesaturate = 4,
			ChromaticAberrationOnly = 5,
			DistortOnly = 6
		}

		[SettingsGroup]
		public DistortionSettings distortion;

		[SettingsGroup]
		public VignetteSettings vignette;

		[SettingsGroup]
		public ChromaticAberrationSettings chromaticAberration;

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

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
