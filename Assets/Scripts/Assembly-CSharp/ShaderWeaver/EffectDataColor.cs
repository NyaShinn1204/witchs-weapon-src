using System;
using UnityEngine;

namespace ShaderWeaver
{
	[Serializable]
	public class EffectDataColor
	{
		public bool hdr;

		public Color color;

		public SWOutputOP op;

		public string param;
	}
}
