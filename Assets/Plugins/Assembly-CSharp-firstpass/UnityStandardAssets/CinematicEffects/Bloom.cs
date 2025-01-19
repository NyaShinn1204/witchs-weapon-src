using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	public class Bloom : MonoBehaviour
	{
		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 20)]
		public struct Settings
		{
			[SerializeField]
			public float threshold;

			[SerializeField]
			public float radius;

			[SerializeField]
			public float intensity;

			[SerializeField]
			public bool highQuality;

			[SerializeField]
			public bool antiFlicker;

			public float thresholdGamma
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float thresholdLinear
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public static Settings defaultSettings
			{
				get
				{
					return default(Settings);
				}
			}
		}

		[SerializeField]
		public Settings settings;

		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		private Material m_Material;

		private const int kMaxIterations = 16;

		private RenderTexture[] m_blurBuffer1;

		private RenderTexture[] m_blurBuffer2;

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
