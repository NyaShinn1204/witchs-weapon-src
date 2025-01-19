using System;

namespace ParadoxNotion.Design
{
	public class PopupFieldAttribute : Attribute
	{
		public object[] values;

		public string staticPath;

		public PopupFieldAttribute(params object[] values)
		{
		}

		public PopupFieldAttribute(string staticPath)
		{
		}
	}
}
