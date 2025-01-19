using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	public class TonemappingColorGrading : MonoBehaviour
	{
		public class SettingsGroup : Attribute
		{
		}

		public class IndentedGroup : PropertyAttribute
		{
		}

		public class ChannelMixer : PropertyAttribute
		{
		}

		public class ColorWheelGroup : PropertyAttribute
		{
			public int minSizePerWheel;

			public int maxSizePerWheel;

			public ColorWheelGroup()
			{
			}

			public ColorWheelGroup(int minSizePerWheel, int maxSizePerWheel)
			{
			}
		}

		public class Curve : PropertyAttribute
		{
			public Color color;

			public Curve()
			{
			}

			public Curve(float r, float g, float b, float a)
			{
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 24)]
		public struct EyeAdaptationSettings
		{
			public bool enabled;

			public float middleGrey;

			public float min;

			public float max;

			public float speed;

			public bool showDebug;

			public static EyeAdaptationSettings defaultSettings
			{
				get
				{
					return default(EyeAdaptationSettings);
				}
			}
		}

		public enum Tonemapper
		{
			ACES = 0,
			Curve = 1,
			Hable = 2,
			HejlDawson = 3,
			Photographic = 4,
			Reinhard = 5,
			Neutral = 6
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 48)]
		public struct TonemappingSettings
		{
			public bool enabled;

			public Tonemapper tonemapper;

			public float exposure;

			public AnimationCurve curve;

			public float neutralBlackIn;

			public float neutralWhiteIn;

			public float neutralBlackOut;

			public float neutralWhiteOut;

			public float neutralWhiteLevel;

			public float neutralWhiteClip;

			public static TonemappingSettings defaultSettings
			{
				get
				{
					return default(TonemappingSettings);
				}
			}
		}

		[Serializable]
		public struct LUTSettings
		{
			public bool enabled;

			public Texture texture;

			public float contribution;

			public static LUTSettings defaultSettings
			{
				get
				{
					return default(LUTSettings);
				}
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 48)]
		public struct ColorWheelsSettings
		{
			public Color shadows;

			public Color midtones;

			public Color highlights;

			public static ColorWheelsSettings defaultSettings
			{
				get
				{
					return default(ColorWheelsSettings);
				}
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 36)]
		public struct BasicsSettings
		{
			public float temperatureShift;

			public float tint;

			[Space]
			public float hue;

			public float saturation;

			public float vibrance;

			public float value;

			[Space]
			public float contrast;

			public float gain;

			public float gamma;

			public static BasicsSettings defaultSettings
			{
				get
				{
					return default(BasicsSettings);
				}
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 16)]
		public struct ChannelMixerSettings
		{
			public int currentChannel;

			public Vector3[] channels;

			public static ChannelMixerSettings defaultSettings
			{
				get
				{
					return default(ChannelMixerSettings);
				}
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 32)]
		public struct CurvesSettings
		{
			[Curve]
			public AnimationCurve master;

			[Curve]
			public AnimationCurve red;

			[Curve]
			public AnimationCurve green;

			[Curve]
			public AnimationCurve blue;

			public static CurvesSettings defaultSettings
			{
				get
				{
					return default(CurvesSettings);
				}
			}

			public static AnimationCurve defaultCurve
			{
				get
				{
					return null;
				}
			}
		}

		public enum ColorGradingPrecision
		{
			Normal = 0x10,
			High = 0x20
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 152)]
		public struct ColorGradingSettings
		{
			public bool enabled;

			public ColorGradingPrecision precision;

			[Space]
			[ColorWheelGroup]
			public ColorWheelsSettings colorWheels;

			[Space]
			[IndentedGroup]
			public BasicsSettings basics;

			[Space]
			[ChannelMixer]
			public ChannelMixerSettings channelMixer;

			[Space]
			[IndentedGroup]
			public CurvesSettings curves;

			[Space]
			public bool useDithering;

			public bool showDebug;

			public static ColorGradingSettings defaultSettings
			{
				get
				{
					return default(ColorGradingSettings);
				}
			}

			internal void Reset()
			{
			}
		}

		private enum Pass
		{
			LutGen = 0,
			AdaptationLog = 1,
			AdaptationExpBlend = 2,
			AdaptationExp = 3,
			TonemappingOff = 4,
			TonemappingACES = 5,
			TonemappingCurve = 6,
			TonemappingHable = 7,
			TonemappingHejlDawson = 8,
			TonemappingPhotographic = 9,
			TonemappingReinhard = 10,
			TonemappingNeutral = 11,
			AdaptationDebug = 12
		}

		[SerializeField]
		[SettingsGroup]
		private EyeAdaptationSettings m_EyeAdaptation;

		[SerializeField]
		[SettingsGroup]
		private TonemappingSettings m_Tonemapping;

		[SerializeField]
		[SettingsGroup]
		private LUTSettings m_Lut;

		[SerializeField]
		[SettingsGroup]
		private ColorGradingSettings m_ColorGrading;

		private Texture2D m_IdentityLut;

		private RenderTexture m_InternalLut;

		private Texture2D m_CurveTexture;

		private Texture2D m_TonemapperCurve;

		private float m_TonemapperCurveRange;

		[SerializeField]
		private Shader m_Shader;

		private Material m_Material;

		private bool m_Dirty;

		private bool m_TonemapperDirty;

		private RenderTexture m_SmallAdaptiveRt;

		private RenderTextureFormat m_AdaptiveRtFormat;

		public EyeAdaptationSettings eyeAdaptation
		{
			get
			{
				return default(EyeAdaptationSettings);
			}
			set
			{
			}
		}

		public TonemappingSettings tonemapping
		{
			get
			{
				return default(TonemappingSettings);
			}
			set
			{
			}
		}

		public LUTSettings lut
		{
			get
			{
				return default(LUTSettings);
			}
			set
			{
			}
		}

		public ColorGradingSettings colorGrading
		{
			get
			{
				return default(ColorGradingSettings);
			}
			set
			{
			}
		}

		private Texture2D identityLut
		{
			get
			{
				return null;
			}
		}

		private RenderTexture internalLutRt
		{
			get
			{
				return null;
			}
		}

		private Texture2D curveTexture
		{
			get
			{
				return null;
			}
		}

		private Texture2D tonemapperCurve
		{
			get
			{
				return null;
			}
		}

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

		public bool isGammaColorSpace
		{
			get
			{
				return false;
			}
		}

		public int lutSize
		{
			get
			{
				return 0;
			}
		}

		public bool validRenderTextureFormat { get; private set; }

		public bool validUserLutSize { get; private set; }

		public void SetDirty()
		{
		}

		public void SetTonemapperDirty()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnValidate()
		{
		}

		private static Texture2D GenerateIdentityLut(int dim)
		{
			return null;
		}

		private float StandardIlluminantY(float x)
		{
			return 0f;
		}

		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		private Vector3 GetWhiteBalance()
		{
			return default(Vector3);
		}

		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain)
		{
			lift = default(Color);
			gamma = default(Color);
			gain = default(Color);
		}

		private void GenCurveTexture()
		{
		}

		private bool CheckUserLut()
		{
			return false;
		}

		private bool CheckSmallAdaptiveRt()
		{
			return false;
		}

		private void OnGUI()
		{
		}

		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		public Texture2D BakeLUT()
		{
			return null;
		}
	}
}
