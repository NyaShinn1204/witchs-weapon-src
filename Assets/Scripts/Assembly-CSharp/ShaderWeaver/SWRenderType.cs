using System;

namespace ShaderWeaver
{
	[Serializable]
	public enum SWRenderType
	{
		Opaque = 0,
		Transparent = 1,
		TransparentCutout = 2,
		Background = 3,
		Overlay = 4,
		TreeOpaque = 5,
		TreeTransparentCutout = 6,
		Grass = 7,
		GrassBillboard = 8
	}
}
