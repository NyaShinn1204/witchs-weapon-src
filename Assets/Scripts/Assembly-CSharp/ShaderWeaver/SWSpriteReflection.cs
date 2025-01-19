using System.Collections.Generic;
using UnityEngine;

namespace ShaderWeaver
{
	[ExecuteInEditMode]
	public class SWSpriteReflection : SWSpriteComponent
	{
		public Camera cam;

		public float height;

		protected override void Awake()
		{
		}

		protected override void Update()
		{
		}

		protected List<Vector2> SpriteScreenUVs(SpriteRenderer sr, Camera cam)
		{
			return null;
		}

		protected Vector2 Local2ScreenUV(Vector3 localPos, Transform tran, Camera cam)
		{
			return default(Vector2);
		}
	}
}
