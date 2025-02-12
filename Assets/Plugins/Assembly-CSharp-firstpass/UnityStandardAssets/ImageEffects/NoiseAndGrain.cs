using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	public class NoiseAndGrain : PostEffectsBase
	{
		public float intensityMultiplier;

		public float generalIntensity;

		public float blackIntensity;

		public float whiteIntensity;

		public float midGrey;

		public bool dx11Grain;

		public float softness;

		public bool monochrome;

		public Vector3 intensities;

		public Vector3 tiling;

		public float monochromeTiling;

		public FilterMode filterMode;

		public Texture2D noiseTexture;

		public Shader noiseShader;

		private Material noiseMaterial;

		public Shader dx11NoiseShader;

		private Material dx11NoiseMaterial;

		private static float TILE_AMOUNT;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}
	}
}
