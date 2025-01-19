using System;

namespace ParadoxNotion.Design
{
	public class SliderFieldAttribute : Attribute
	{
		public float left;

		public float right;

		public SliderFieldAttribute(float left, float right)
		{
		}

		public SliderFieldAttribute(int left, int right)
		{
		}
	}
}
