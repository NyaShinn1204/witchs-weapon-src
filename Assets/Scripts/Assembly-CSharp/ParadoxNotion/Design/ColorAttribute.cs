using System;

namespace ParadoxNotion.Design
{
	public class ColorAttribute : Attribute
	{
		public string hexColor;

		public ColorAttribute(string hexColor)
		{
		}
	}
}
