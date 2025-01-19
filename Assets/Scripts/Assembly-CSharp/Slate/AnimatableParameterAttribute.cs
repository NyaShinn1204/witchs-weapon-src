using UnityEngine;

namespace Slate
{
	public class AnimatableParameterAttribute : PropertyAttribute
	{
		public string link;

		public float? min;

		public float? max;

		public AnimatableParameterAttribute()
		{
		}

		public AnimatableParameterAttribute(float min, float max)
		{
		}
	}
}
