using System;

namespace ShaderWeaver
{
	[Serializable]
	public enum SWNodeType
	{
		root = 0,
		mask = 1,
		remap = 2,
		color = 3,
		uv = 4,
		alpha = 5,
		blur = 6,
		retro = 7,
		coord = 8,
		dummy = 9,
		refract = 10,
		reflect = 11,
		mixer = 12,
		image = 13,
		code = 14
	}
}
