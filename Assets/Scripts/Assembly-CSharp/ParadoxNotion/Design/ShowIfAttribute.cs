using System;

namespace ParadoxNotion.Design
{
	public class ShowIfAttribute : Attribute
	{
		public string fieldName;

		public bool show;

		public ShowIfAttribute(string fieldName, bool show = true)
		{
		}
	}
}
