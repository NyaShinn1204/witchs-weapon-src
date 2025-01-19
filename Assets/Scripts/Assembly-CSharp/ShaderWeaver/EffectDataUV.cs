using System;
using UnityEngine;

namespace ShaderWeaver
{
	[Serializable]
	public class EffectDataUV
	{
		public SWUVop op;

		public string param;

		public Vector2 amountR;

		public Vector2 amountG;

		public Vector2 amountB;

		public Vector2 amountA;
	}
}
