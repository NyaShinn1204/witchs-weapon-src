using System;

namespace ParadoxNotion.Design
{
	public class IconAttribute : Attribute
	{
		public enum Mode
		{
			ReplaceTitle = 0,
			AppendToTitle = 1
		}

		public string iconName;

		public Mode mode;

		public bool fixedColor;

		public IconAttribute(string iconName, Mode mode, bool fixedColor = false)
		{
		}

		public IconAttribute(string iconName, bool fixedColor = false)
		{
		}
	}
}
