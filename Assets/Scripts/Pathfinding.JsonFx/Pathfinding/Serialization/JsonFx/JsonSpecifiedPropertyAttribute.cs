using System;
using System.Reflection;

namespace Pathfinding.Serialization.JsonFx
{
	public class JsonSpecifiedPropertyAttribute : Attribute
	{
		private string specifiedProperty;

		public string SpecifiedProperty
		{
			get
			{
				return null;
			}
		}

		public static string GetJsonSpecifiedProperty(MemberInfo memberInfo)
		{
			return null;
		}
	}
}
