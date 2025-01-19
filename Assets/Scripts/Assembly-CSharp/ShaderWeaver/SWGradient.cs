using System;
using System.Collections.Generic;
using UnityEngine;

namespace ShaderWeaver
{
	[Serializable]
	public class SWGradient
	{
		public Texture2D tex;

		[SerializeField]
		public List<SWGradientFrame> frames;

		public Texture2D Tex
		{
			get
			{
				return null;
			}
		}

		public void UpdateTex()
		{
		}

		public void Sort()
		{
		}

		public float Evaluate(float time)
		{
			return 0f;
		}
	}
}
