using System;
using UnityEngine;

namespace Slate
{
	public class ShaderPropertyPopupAttribute : PropertyAttribute
	{
		public Type propertyType;

		public ShaderPropertyPopupAttribute()
		{
		}

		public ShaderPropertyPopupAttribute(Type propertyType)
		{
		}
	}
}
