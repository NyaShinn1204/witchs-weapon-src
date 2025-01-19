using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	public class RenderTextureUtility
	{
		private List<RenderTexture> m_TemporaryRTs;

		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			return null;
		}

		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		public void ReleaseAllTemporaryRenderTextures()
		{
		}
	}
}
