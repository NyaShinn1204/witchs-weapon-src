using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	public static class ImageEffectHelper
	{
		public static bool supportsDX11
		{
			get
			{
				return false;
			}
		}

		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			return false;
		}

		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			return null;
		}
	}
}
