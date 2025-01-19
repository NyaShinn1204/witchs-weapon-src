using UnityEngine;

namespace ShaderWeaver
{
	[ExecuteInEditMode]
	public class SWSpriteAnimation : SWSpriteComponent
	{
		protected override void Awake()
		{
		}

		protected override void OnWillRenderObject()
		{
		}

		protected Vector4 CalAnimationSheetCurrentRect(Sprite sprite)
		{
			return default(Vector4);
		}
	}
}
