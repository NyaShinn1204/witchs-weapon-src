using System;

namespace ShaderWeaver
{
	[Serializable]
	public enum SWOutputOP
	{
		blend = 0,
		blendInner = 1,
		add = 2,
		addInner = 3,
		mul = 4,
		mulIntersect = 5,
		mulRGB = 6,
		Darken = 20,
		ColorBurn = 21,
		LinearBurn = 22,
		DarkerColor = 23,
		Lighten = 24,
		Screen = 25,
		ColorDodge = 26,
		LinearDodge = 27,
		LighterColor = 28,
		Overlay = 29,
		SoftLight = 30,
		HardLight = 31,
		VividLight = 32,
		LinearLight = 33,
		PinLight = 34,
		HardMix = 35,
		Difference = 36,
		Exclusion = 37,
		Subtract = 38,
		Divide = 39,
		Hue = 40,
		Saturation = 41,
		Color = 42,
		Luminosity = 43
	}
}
